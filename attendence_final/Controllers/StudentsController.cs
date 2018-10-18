using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using attendence_final.Models;

namespace attendence_final.Controllers
{
    //[Authorize(Roles =RoleName.AdminFacultyStudent)]
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.dept);
            if(User.IsInRole(RoleName.Student))
                return View("Index-Student",students.ToList());
            if(User.IsInRole(RoleName.AdminFaculty))
                return View("Index", students.ToList());
            return View("GuestUser");
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        [Authorize(Roles = RoleName.AdminFaculty)]
        public ActionResult Create()
        {
            ViewBag.Dept_Id = new SelectList(db.departments, "Dept_Id", "Dept_Name");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Stud_Id,Student_Name,Password,Dept_Id,Attendance,Total_Days")] Student student)
        {
            if (ModelState.IsValid)
            {
                //var rolestore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                    //var roleManager = new RoleManager<IdentityRole>(rolestore);
                    //await roleManager.CreateAsync(new IdentityRole("Student"));
                    //await UserManager.AddToRoleAsync(user.Id, "Student");
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Dept_Id = new SelectList(db.departments, "Dept_Id", "Dept_Name", student.Dept_Id);
            return View(student);
        }

        // GET: Students/Edit/5
        [Authorize(Roles = RoleName.AdminFaculty)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.Dept_Id = new SelectList(db.departments, "Dept_Id", "Dept_Name", student.Dept_Id);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Stud_Id,Student_Name,Password,Dept_Id,Attendance,Total_Days")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Dept_Id = new SelectList(db.departments, "Dept_Id", "Dept_Name", student.Dept_Id);
            return View(student);
        }

        // GET: Students/Delete/5
        [Authorize(Roles = RoleName.AdminFaculty)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

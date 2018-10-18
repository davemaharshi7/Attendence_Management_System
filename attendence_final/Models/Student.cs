using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace attendence_final.Models
{
    public class Student
    {
        [Key]
        public int Stud_Id { get; set; }
        public string Student_Name { get; set; }
        public string Password { get; set; }
        [ForeignKey("dept")]
        public int Dept_Id { get; set; }
        public int Attendance { get; set; }
        public int Total_Days { get; set; }

        public department dept { get; set; }
    }
}
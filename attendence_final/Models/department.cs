using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace attendence_final.Models
{
    public class department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace attendence_final.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
        public string Admin_Name { get; set; }
        public string Password { get; set; }
    }
}
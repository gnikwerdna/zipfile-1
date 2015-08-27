using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SynergeticHelper.Models
{
    public class Staff
    {
        [Display(Name = "Staff ID Select")]
        public int staffId { get; set; }
        [Display(Name = "First Name")]
        public string fname { get; set; }
        [Display(Name = "Last Name")]
        public string lname {get;set;}
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return fname + " " + lname;
            }
        }
        public int SynergeticId { get; set; }
        public string NetworkLogin { get; set; }
        public string StaffDepartment { get; set; }

    }
}
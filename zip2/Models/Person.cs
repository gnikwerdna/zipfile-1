using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zip2.Models
{
    public class Person
    {
        [Key]
       public int PersonId { get; set; }
       [Display(Name = "Full Name")]
       public  string PName { get; set; }
       public virtual ICollection<File> Files { get; set; }

    }
}
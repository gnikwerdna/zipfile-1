using SynergeticHelper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SynergeticHelper.DB
{
    public class SynHelpContext: DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
    }
}
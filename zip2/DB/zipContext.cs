using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using zip2.Models;

namespace zip2.DB
{
    public class zipContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Audit> AuditRecords { get; set; }

    }
}
using ReportGen.Tools.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.DAL
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new MySqlInitializer());
        }


        public DatabaseContext() : base("ReportGenConnection") { }

        public virtual DbSet<BookMark> BookMarks { get; set; }
    }
}

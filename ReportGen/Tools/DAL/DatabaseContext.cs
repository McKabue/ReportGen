using ReportGen.Tools.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.DAL
{
    //public class DatabaseContext : DbContext
    //{
    //    static DatabaseContext()
    //    {
    //        Database.SetInitializer(new MySqlInitializer());
    //    }

    //    public DatabaseContext() : base("ReportGenConnection") { }




    //    public virtual DbSet<Template> Templates { get; set; }

    //    public virtual DbSet<AutoDocument> AutoDocuments { get; set; }

    //    public virtual DbSet<BookMarkData> BookMarkDatas { get; set; }

    //    public virtual DbSet<BookMark> BookMarks { get; set; }

    //    public virtual DbSet<BookMarkType> BookMarkTypes { get; set; }


    //}

    public class DatabaseContext : DbContext
    {
        //static DatabaseContext()
        //{
        //    Database.SetInitializer(new MySqlInitializer());
        //}

        public DatabaseContext() : base("ReportGenConnectionLocalDB") { }




        public virtual DbSet<Template> Templates { get; set; }

        public virtual DbSet<AutoDocument> AutoDocuments { get; set; }

        public virtual DbSet<BookMarkData> BookMarkDatas { get; set; }

        public virtual DbSet<BookMark> BookMarks { get; set; }

        public virtual DbSet<BookMarkType> BookMarkTypes { get; set; }


    }

    //public class DatabaseContext : DbContext
    //{
    //    static DatabaseContext()
    //    {
    //        //Database.SetInitializer(new SQLITEInitializer());
    //        Database.SetInitializer<DatabaseContext>(null);
    //    }

    //    public DatabaseContext() : base("ReportGenConnectionSQLITE") { }




    //    public virtual DbSet<Template> Templates { get; set; }

    //    public virtual DbSet<AutoDocument> AutoDocuments { get; set; }

    //    public virtual DbSet<BookMarkData> BookMarkDatas { get; set; }

    //    public virtual DbSet<BookMark> BookMarks { get; set; }

    //    public virtual DbSet<BookMarkType> BookMarkTypes { get; set; }


    //}
}

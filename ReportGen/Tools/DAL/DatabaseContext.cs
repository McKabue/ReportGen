using ReportGen.Tools.Models;
using System.Data.Entity;

namespace ReportGen.Tools.DAL
{

    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("ReportGenConnectionLocalDB") { }




        public virtual DbSet<Template> Templates { get; set; }

        public virtual DbSet<AutoDocument> AutoDocuments { get; set; }

        public virtual DbSet<BookMarkData> BookMarkDatas { get; set; }

        public virtual DbSet<BookMark> BookMarks { get; set; }

        public virtual DbSet<BookMarkType> BookMarkTypes { get; set; }


    }
    
}

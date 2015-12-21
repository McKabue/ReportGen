namespace ReportGen.Migrations
{
    using MySql.Data.Entity;
    using Tools.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ReportGen.Tools.DAL.DatabaseContext>
    {
        public Configuration()
        {
           // SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ReportGen.Tools.DAL.DatabaseContext context)
        {
            if (!context.BookMarkTypes.Any())
            {
                context.BookMarkTypes.AddOrUpdate(
                    new BookMarkType { BookMarkTypeID = Guid.NewGuid().ToString("D"),  BookMarkTypeString = "PlainText"},
                    new BookMarkType { BookMarkTypeID = Guid.NewGuid().ToString("D"), BookMarkTypeString = "DataTime" }
                );

                context.SaveChanges();
            }
        }
    }
}

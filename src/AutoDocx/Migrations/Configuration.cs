namespace AutoDocx.Migrations
{
    using Tools.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoDocx.Tools.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AutoDocx.Tools.DAL.DatabaseContext context)
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

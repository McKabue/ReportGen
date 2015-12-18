using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.DAL
{
    public class MySqlInitializer : IDatabaseInitializer<DatabaseContext>
    {
        public void InitializeDatabase(DatabaseContext context)
        {
            if (!context.Database.Exists())
            {
                // if database did not exist before - create it
                context.Database.Create();
                //context.Database.AsRelational().ApplyMigrations();
            }
            //else
            //{
            //    // query to check if MigrationHistory table is present in the database 
            //    var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(
            //    string.Format(
            //      "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '__MigrationHistory'",
            //      "[Insert your database schema here - such as 'users']"));

            //    // if MigrationHistory table is not there (which is the case first time we run) - create it
            //    if (migrationHistoryTableExists.FirstOrDefault() == 0)
            //    {
            //        context.Database.Delete();
            //        context.Database.Create();
            //    }
            //}
        }
    }
}

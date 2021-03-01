using RCPSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using RCPSystem.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace RCPSystem
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new Configuration();

            var migrator = new DbMigrator(configuration);



            var scriptor = new MigratorScriptingDecorator(migrator);

            var script = scriptor.ScriptUpdate(sourceMigration: null, targetMigration: null);
            Database.SetInitializer<EFModel>(new MigrateDatabaseToLatestVersion<EFModel, Configuration>());
          //  Database.SetInitializer<EFModel>(null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logon());
        }
    }
}

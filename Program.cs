using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Views;
using UnicomTicManagementSystem.Repositories;
using SchoolManageSystem.Data;

namespace UnicomTICManagementSystem
{
    internal static class Programs
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the database and create all tables

            DatabaseInitializer.CreateTables();
            // Removed: DatabaseManager.CreatTable(); // ❌ This was throwing NotImplementedException

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}

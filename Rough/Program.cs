using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rough
{
    static class Program
    {
        public static string StartPath = Application.StartupPath + @"\" + "ROUGHConn";
        public static ApplicationContext Context;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.Context = new ApplicationContext();
            Program.Context.MainForm = new frmDSSplash();
            
            Application.Run(Program.Context);
        }
    }
}
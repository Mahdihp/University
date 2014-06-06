using System;
using System.Windows.Forms;
using University.Forms;

namespace University
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmUsers());
            //Application.Run(new frmOstad());
           // Application.Run(new frmDaneshjoo());
         //   Application.Run(new frmDars());
           // Application.Run(new frmKarnameh());
        }
    }
}

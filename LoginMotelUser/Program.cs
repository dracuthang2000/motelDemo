using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMotelUser
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
        begin:
            Form1 f1 = new Form1();
            Admin_Formcs ad = new Admin_Formcs();
            Application.Run(f1);
            if (f1.isLoggedIn == true)
            {
                if(f1.checkRole == true)
                {
                    ad.checkRole = true;
                }
                else
                {
                    ad.checkRole = false;
                }
                Application.Run(ad);                
            }
            if(ad.isClose==true)
            {
                goto begin;
            }
            
        }
    }
}

﻿using System;
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
            Application.EnableVisualStyles();//566asdaasdasdasdadasdasdasdasdsadasdsas
            Application.SetCompatibleTextRenderingDefault(false);//xxxxxxxxxxxxxxx
        begin:
            Form1 f1 = new Form1();
            Admin_Formcs ad = new Admin_Formcs();
            Application.Run(new showStaffForm());
            if (f1.isLoggedIn == true)
            {
                if (f1.checkRole == true)
                {
                    ad.checkRole = true;
                }
                else
                {
                    ad.checkRole = false;
                }
                ad.checkUsername = f1.checkUsername;
                Application.Run(ad);
            }
            if (ad.isClose == true)
            {
                goto begin;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;


namespace StudentManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Display login form
            FrmUserLogin objLoginForm = new FrmUserLogin();
            DialogResult result = objLoginForm.ShowDialog();

            //Determine if the login was successful
            if (result == DialogResult.OK)
                Application.Run(new FrmMain());
            else
                Application.Exit(); //Exit the entire application

        }

        //Global variable
        public static Admin currentAdmin = null;

    }
}

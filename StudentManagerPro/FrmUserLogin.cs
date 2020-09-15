using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        private AdminService objAdminService = new AdminService(); //Create a data access class object
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        //Log in
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Data validation
            if(this.txtLoginId.Text.Trim().Length==0)
            {
                MessageBox.Show("Please enter your login account！", "Login prompt");
                this.txtLoginId.Focus();
                return;
            }
            if(!DataValidate.IsInteger(this.txtLoginId.Text.Trim()))
            {
                MessageBox.Show("The login account must be a positive integer！", "Login prompt");
                this.txtLoginId.Focus();
                this.txtLoginId.SelectAll();
                return;
            }

            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your login password！", "Login prompt");
                this.txtLoginPwd.Focus();
                return;
            }

            //Encapsulates user information into user objects
            Admin objAdmin = new Admin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };
            //Submit user program information
            try
            {
                objAdmin = objAdminService.AdminLogin(objAdmin);
                if(objAdmin==null)
                {
                    MessageBox.Show("Logon account or password error!", "Login prompt");
                }
                else
                {
                    Program.currentAdmin = objAdmin; //store current user
                    this.DialogResult = DialogResult.OK; //set success login information
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login failure");
            }
        }

        //Click X
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorMessage.Text = "You Must Provide UserName And Password";
                lblErrorMessage.Visible = true;
            }
            else
            {
                AppContext context = new AppContext();
                var admin = (from d in context.Admins
                             where d.UserName == txtUserName.Text && d.Password == txtPassword.Text
                             select d).FirstOrDefault();
                if (admin is null)
                {
                    lblErrorMessage.Text = "InValid UserName Or Password";
                    lblErrorMessage.Visible = true;
                }
                else
                {
                    HomeForm homeForm = new HomeForm();

                    Hide();
                    homeForm.Show();
                }

            }
        }
    }
}

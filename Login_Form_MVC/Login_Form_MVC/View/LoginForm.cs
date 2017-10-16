using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Form_MVC.Controller;
using Login_Form_MVC.View;

namespace Login_Form_MVC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Form_MVC.Controller.UserController usctrl = new Login_Form_MVC.Controller.UserController();
            if (usctrl.ValidLogin(txbName.Text,txbSurname.Text,txvPass.Text,txbUsername.Text) == false)
            {
                if (!string.IsNullOrWhiteSpace(txbRetypePass.Text))
                {
                    new Home().Show();
                }
                else { }
                
            }
                
            else
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία!","Null Values",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }
}

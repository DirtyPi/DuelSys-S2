using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        private UserManager userManager;
        private UserMediator userMediator = new UserMediator();
        public login()
        {
            InitializeComponent();
            userManager = new UserManager(userMediator);
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter the credentials!");
            }
            else
            {
                if(userManager.CheckIfUserCredentials(tbEmail.Text, tbPassword.Text))
                {
                    User u = userManager.GetUserEmail(tbEmail.Text);
                    if (u.Role == UserRoleEnum.EmployeeUser)
                    {
                        Form1 mF = new Form1();
                        mF.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Access denied!");

                    }
                }
                else
                {
                    MessageBox.Show("Not found!");
                }
            }
        }
    }
}

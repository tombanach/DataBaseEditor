using SmayDbEditor.UserInterface.Forms.Base;
using SmayDbEditor.UserInterface.Helpers;
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

namespace SmayDbEditor.UserInterface.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();

            txtUserName.Text = "weekend";
            txtPassword.Text = "Dupa54321";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var username = txtUserName.Text;
                var password = txtPassword.Text;

                var userViewModel = MappingHelper.MapUserModelToUserViewModel(AuthRepository.Login(username, password));
                if (userViewModel != null)
                {
                    UserHelper.ActiveUser = userViewModel;

                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
            }
        }

        private bool isValid()
        {
            if (txtUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Wpisz nazwę użytkownika!", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Wpisz hasło!", "Error");
                return false;
            }
            return true;
        }
    }
}

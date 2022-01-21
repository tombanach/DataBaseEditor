using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.UserInterface.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms
{
    public partial class RegisterForm : BaseForm
    {
        private static RegisterForm _instance = null;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static RegisterForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegisterForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private void btnAddRegister_Click(object sender, EventArgs e)
        {
            var username = txtLoginUser.Text;
            var password = txtPasswordUser.Text;

            var result = AuthRepository.Register(username, password);
            MessageBox.Show($"Uzytkownik {result.Username} zostal dodany");
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            _instance = null;
        }
    }
}

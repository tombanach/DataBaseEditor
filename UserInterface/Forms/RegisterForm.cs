using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.UserInterface.Forms.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms
{
    public partial class RegisterForm : BaseForm
    {
        private static RegisterForm _instance = null;
        public RegisterForm()
        {
            InitializeComponent();
            InitUserGroupDropdown();
        }

        private void InitUserGroupDropdown()
        {
            var bs = new BindingSource();
            bs.DataSource = UserRepository.GetUserGroups();

            cbAccountType.DataSource = bs.DataSource;

            cbAccountType.DisplayMember = "GroupName";
            cbAccountType.ValueMember = "Id";
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

            var selectedIndex = cbAccountType.SelectedIndex;
            var selectedAccountType = (UserGroupModel)cbAccountType.Items[selectedIndex];

            try
            {
                var result = AuthRepository.Register(username, password, selectedAccountType);
                MessageBox.Show($"Uzytkownik {result.Username} zostal dodany");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}

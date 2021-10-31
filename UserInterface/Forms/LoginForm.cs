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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=WmsSmayDb_Conn;User Id=dbEditorUser;Password=Dupa54321;"))
                //using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Wms_SmayDb_Conn;User Id=dbEditorUser;Password=Dupa54321;"))
                {
                    string query = "SELECT * FROM Login WHERE Username = '" + txtUserName.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.Show();
                    }
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

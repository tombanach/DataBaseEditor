using SmayDbEditor.DataAccessLayer.Repository;
using SmayDbEditor.DataAccessLayer.ViewModel;
using SmayDbEditor.UserInterface.Forms.Base;
using SmayDbEditor.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.Logs
{
    public partial class LogsForm : BaseForm
    {
        private static LogsForm _instance = null;
        private static IList<LogViewModel> fakeLogs;

        public static LogsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogsForm();
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

        private LogsForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            fakeLogs = GetFakeLogs();
            PrepareLogsData();
        }   

        private void PrepareLogsData()
        {
            bsLogs.DataSource = new BindingList<LogViewModel>(fakeLogs);
            dgvLogs.DataSource = bsLogs;
        }

        private IList<LogViewModel> GetFakeLogs()
        {
            var logs = LogRepository.GetLogs();
            return MappingHelper.MapLogModelToLogViewModel(logs);
        }

        private void LogsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }        

        private void LogsSearchBar_TextChanged(object sender, EventArgs e)
        {
            var mainconn = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            var sql = "select * from [dbo].[logi] where log_num like '" + LogsSearchBar.Text + "%'";

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sql, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            bsLogs.DataSource = dt;
            sqlconn.Close();
        }
    }
}

using SmayDbEditor.DataAccessLayer.ViewModel;
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
    public partial class LogsForm : Form
    {
        #region Fields

        private static LogsForm _instance = null;
        private static IList<LogViewModel> fakeLogs;

        #endregion
        #region Properties

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

        #endregion
        #region Constructor

        private LogsForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeLogs = GetFakeLogs();
            PrepareLogsData();
        }

        // Wyświetlanie danych w Gridzie
        private void PrepareLogsData()
        {
            var fakeLogsSorted = fakeLogs.OrderBy(x => x.porel_pono).ToList();
            bsLogs.DataSource = new BindingList<LogViewModel>(fakeLogsSorted);
            dgvLogs.DataSource = bsLogs;
        }

        private IList<LogViewModel> GetFakeLogs()
        {
            var logs = LogRepository.GetLogs();
            return MappingHelper.MapLogModelToLogViewModel(logs);
        }

        #endregion
        #region Events        

        private void LogsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        #endregion

        private void LogsSearchBar_TextChanged(object sender, EventArgs e)
        {
            var mainconn = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            var sql = "select * from [dbo].[podet_rel] where porel_pono like '" + LogsSearchBar.Text + "%'";

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

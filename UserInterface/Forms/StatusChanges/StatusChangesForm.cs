using SmayDbEditor.DataAccessLayer.ViewModel;
using SmayDbEditor.UserInterface.Classes;
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

namespace SmayDbEditor.UserInterface.Forms.StatusChanges
{
    public partial class StatusChangesForm : BaseForm
    {
        #region Fields

        private static StatusChangesForm _instance = null;
        private static IList<StatusChangeViewModel> fakeStatusChanges;

        #endregion
        #region Properties

        public static StatusChangesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StatusChangesForm();
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

        private StatusChangesForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeStatusChanges = GetFakeStatusChanges();
            PrepareStatusChangesData();
        }

        private void PrepareStatusChangesData()
        {
            bsStatusChanges.DataSource = new BindingList<StatusChangeViewModel>(fakeStatusChanges);
            dgvStatusChanges.DataSource = bsStatusChanges;
        }

        private IList<StatusChangeViewModel> GetFakeStatusChanges()
        {
            //throw new Exception();
            var statuses = StatusChangeRepository.GetStatuses();
            return MappingHelper.MapStatusChangeModelToStatusChangeViewModel(statuses);
        }

        #endregion
        #region Events        

        private void btnModify_Click(object sender, EventArgs e)
        {
            int statusChangeId = Convert.ToInt32(dgvStatusChanges.CurrentRow.Cells["col_imph_id"].Value);
            int selectedRowIndex = dgvStatusChanges.CurrentRow.Index;

            StatusChangeEditForm frm = new StatusChangeEditForm(statusChangeId);

            frm.ReloadStatusChanges += (s, ea) =>
            {
                StatusChangeEventArgs eventArgs = ea as StatusChangeEventArgs;
                if (eventArgs != null)
                {
                    StatusChangeViewModel statusChange
                        = MappingHelper.MapStatusChangeModelToStatusChangeViewModel(eventArgs.StatusChange);
                    bsStatusChanges[selectedRowIndex] = statusChange;
                }
            };

            frm.ShowDialog();
        }

        private void StatusChangesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        #endregion

        private void StatusChangesSearchBar_TextChanged(object sender, EventArgs e)
        {
            var mainconn = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            var sql = "select * from [dbo].[imphead] where imph_num like '" + StatusChangesSearchBar.Text + "%'";

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sql, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            bsStatusChanges.DataSource = dt;
            sqlconn.Close();
        }
    }
}

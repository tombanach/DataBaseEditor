using MySql.Data.MySqlClient;
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
using System.Linq;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.OrdersCorrection
{
    public partial class OrdersCorrectionForm : BaseForm
    {
        #region Fields

        private static OrdersCorrectionForm _instance = null;
        private static IList<OrderCorrectionViewModel> fakeOrdersCorrection;

        #endregion
        #region Properties

        public static OrdersCorrectionForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrdersCorrectionForm();
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

        private OrdersCorrectionForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeOrdersCorrection = GetFakeOrdersCorrection();
            PrepareOrdersCorrectionData();
        }

        // Wyświetlanie danych w Gridzie
        private void PrepareOrdersCorrectionData()
        {
            var fakeOrdersCorrectionSorted = fakeOrdersCorrection.OrderBy(x => x.porel_pono).ToList();
            bsOrdersCorrection.DataSource = new BindingList<OrderCorrectionViewModel>(fakeOrdersCorrectionSorted);
            dgvOrdersCorrection.DataSource = bsOrdersCorrection;
        }

        private IList<OrderCorrectionViewModel> GetFakeOrdersCorrection()
        {
            var orders = OrderCorrectionRepository.GetOrders();
            return MappingHelper.MapOrderCorrectionModelToOrderCorrectionViewModel(orders);
        }        

        #endregion
        #region Events

        private void btnModify_Click(object sender, EventArgs e)
        {
            int orderCorrectionId = Convert.ToInt32(dgvOrdersCorrection.CurrentRow.Cells["col_porel_id"].Value);
            int selectedRowIndex = dgvOrdersCorrection.CurrentRow.Index;

            OrderCorrectionEditForm frm = new OrderCorrectionEditForm(orderCorrectionId);

            frm.ReloadOrdersCorrection += (s, ea) =>
            {
                OrderCorrectionEventArgs eventArgs = ea as OrderCorrectionEventArgs;
                if (eventArgs != null)
                {
                    OrderCorrectionViewModel orderCorrection
                        = MappingHelper.MapOrderCorrectionModelToOrderCorrectionViewModel(eventArgs.OrderCorrection);
                    bsOrdersCorrection[selectedRowIndex] = orderCorrection;
                }
            };

            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int orderCorrectionId = Convert.ToInt32(dgvOrdersCorrection.CurrentRow.Cells["col_porel_id"].Value);
            int selectedRowIndex = dgvOrdersCorrection.CurrentRow.Index;

            // RemoveOrderCorrection(orderCorrection);

            OrderCorrectionRepository.DeleteOrder(orderCorrectionId);
            RefreshGrid();
        }

        private void OrdersCorrectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        #endregion

        private void OrdersCorrectionSearchBar_TextChanged(object sender, EventArgs e)
        {
            var mainconn = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            var sql = "select * from [dbo].[podet_rel] where porel_pono like '" + OrdersCorrectionSearchBar.Text + "%'";

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sql, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            bsOrdersCorrection.DataSource = dt;
            sqlconn.Close();
        }                      
    }
}
using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.ViewModel;
using SmayDbEditor.UserInterface.Classes;
using SmayDbEditor.UserInterface.Forms.Base;
using SmayDbEditor.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.OrdersAddressChange
{
    public partial class OrdersAddressChangeForm : BaseForm
    {
        #region Fields

        private static OrdersAddressChangeForm _instance = null;
        private static IList<OrderAddressChangeViewModel> fakeOrdersAddressChange;

        #endregion
        #region Properties

        public static OrdersAddressChangeForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrdersAddressChangeForm();
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

        public OrdersAddressChangeForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeOrdersAddressChange = GetFakeOrdersAddressChange();
            PrepareOrdersAddressChangeData();
        }

        private void PrepareOrdersAddressChangeData()
        {
            bsOrdersAddressChange.DataSource = new BindingList<OrderAddressChangeViewModel>(fakeOrdersAddressChange);
            dgvOrdersAddressChange.DataSource = bsOrdersAddressChange;
        }

        private IList<OrderAddressChangeViewModel> GetFakeOrdersAddressChange()
        {
            var ordersAddress = OrderAddressChangeRepository.GetOrdersAddress();
            return MappingHelper.MapOrderAddressChangeModelToOrderAddressChangeViewModel(ordersAddress);
        }

        #endregion
        #region Events

        private void btnModify_Click(object sender, EventArgs e)
        {
            int orderAddressChangeId = Convert.ToInt32(dgvOrdersAddressChange.CurrentRow.Cells["col_SOid"].Value);
            int selectedRowIndex = dgvOrdersAddressChange.CurrentRow.Index;

            OrderAddressChangeEditForm frm = new OrderAddressChangeEditForm(orderAddressChangeId);

            frm.ReloadOrdersAddressChange += (s, ea) =>
            {
                OrderAddressChangeEventArgs eventArgs = ea as OrderAddressChangeEventArgs;
                if (eventArgs != null)
                {
                    OrderAddressChangeViewModel orderAddressChange
                        = MappingHelper.MapOrderAddressChangeModelToOrderAddressChangeViewModel(eventArgs.OrderAddressChange);
                    bsOrdersAddressChange[selectedRowIndex] = orderAddressChange;
                }
            };

            frm.ShowDialog();
        }

        private void OrdersAddressChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        #endregion
    }
}

using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.UserInterface.Classes;
using SmayDbEditor.UserInterface.Extensions;
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

namespace SmayDbEditor.UserInterface.Forms.OrdersAddressChange
{
    public partial class OrderAddressChangeEditForm : BaseEditForm
    {
        #region Fields

        public EventHandler ReloadOrdersAddressChange;
        private OrderAddressChangeModel _orderAddressChange;        

        #endregion
        #region Constructor

        public OrderAddressChangeEditForm(int orderAddressChangeId)
        {
            InitializeComponent();
            _orderAddressChange = GetFakeOrderAddressChange(orderAddressChangeId);
            PrepareOrderAddressChangeData(_orderAddressChange);
        }

        #endregion
        #region Private Methods

        private void PrepareOrderAddressChangeData(OrderAddressChangeModel orderAddressChange)
        {
            txt_SOno.Text = orderAddressChange.SOno;
            txt_CustCode.Text = orderAddressChange.CustCode;
            txt_ItemCode.Text = orderAddressChange.ItemCode;
            txt_textline1.Text = orderAddressChange.textline1;
            dtp_orddate.SetDateTimePickerValue(orderAddressChange.orddate);
            txt_DestAddress.Text = orderAddressChange.DestAddress;
        }

        private OrderAddressChangeModel GetFakeOrderAddressChange(int orderAddressChangeId)
        {
            return OrderAddressChangeRepository.GetOrderAddress(orderAddressChangeId);
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        #endregion
        #region Override

        protected override void Save()
        {
            var orderAddressChange = new OrderAddressChangeModel
            {
                SOid = _orderAddressChange.SOid,
                //SOno = txt_SOno.Text,
                //CustCode = txt_CustCode.Text,
                //ItemCode = txt_ItemCode.Text,
                //textline1 = txt_textline1.Text,
                //orddate = dtp_orddate.Value,
                DestAddress = txt_DestAddress.Text
            };

            UpdateOrderAddressChange(orderAddressChange);

            ReloadOrdersAddressChange?.Invoke(btnSave, new OrderAddressChangeEventArgs(orderAddressChange));

            Close();
        }

        private void UpdateOrderAddressChange(OrderAddressChangeModel orderAddressChange)
        {
            OrderAddressChangeRepository.UpdateOrderAddress(orderAddressChange);
        }

        protected override void Cancel()
        {

            Close();
        }

        #endregion
    }
}

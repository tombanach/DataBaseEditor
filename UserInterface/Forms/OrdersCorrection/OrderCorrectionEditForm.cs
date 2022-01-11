using SmayDbEditor.DataAccessLayer;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Repository;
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

namespace SmayDbEditor.UserInterface.Forms.OrdersCorrection
{
    public partial class OrderCorrectionEditForm : BaseEditForm
    {
        #region Fields

        public EventHandler ReloadOrdersCorrection;
        private OrderCorrectionModel _orderCorrection;

        #endregion
        #region Constructor

        public OrderCorrectionEditForm(int orderCorrectionId)
        {
            InitializeComponent();
            _orderCorrection = GetFakeOrderCorrection(orderCorrectionId);
            PrepareOrderCorrectionData(_orderCorrection);
            ValidateControls();
        }

        #endregion
        #region Private Methods

        private void PrepareOrderCorrectionData(OrderCorrectionModel orderCorrection)
        {
            txtPodet_Id.Text = orderCorrection.Podet_Id;
            txtPorel_Itemcode.Text = orderCorrection.Porel_Itemcode;
            txtPorel_Pono.Text = orderCorrection.Porel_Pono;
            txtPorel_Poline.Text = orderCorrection.Porel_Poline;
            txtPorel_Qty.Text = orderCorrection.Porel_Qty;
            dtpPorel_Tstamp.SetDateTimePickerValue(orderCorrection.Porel_Tstamp);

            lblOrderCorrection.Text = $"{orderCorrection.Porel_Pono} - {orderCorrection.Porel_Itemcode}";
        }

        private OrderCorrectionModel GetFakeOrderCorrection(int orderCorrectionId)
        {
            return OrderCorrectionRepository.GetOrder(orderCorrectionId);
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtPorel_Pono.Text))
            {
                epPorel_Pono.SetError(txtPorel_Pono, "Pole Numer Zamówienia jest wymagane. ");
            }
            else
            {
                epPorel_Pono.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtPorel_Qty.Text))
            {
                epPorel_Qty.SetError(txtPorel_Qty, "Pole Ilość jest wymagane. ");
            }
            else
            {
                epPorel_Qty.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string Porel_PonoErrorMessage = epPorel_Pono.GetError(txtPorel_Pono);
            if (!string.IsNullOrEmpty(Porel_PonoErrorMessage))
            {
                sbErrorMessage.Append(Porel_PonoErrorMessage);
            }

            string Porel_QtyErrorMessage = epPorel_Qty.GetError(txtPorel_Qty);
            if (!string.IsNullOrEmpty(Porel_QtyErrorMessage))
            {
                sbErrorMessage.Append(Porel_QtyErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Edytowanie zamówienia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void txtPorel_Pono_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPorel_Qty_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPorel_Pono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPorel_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        #endregion
        #region Override

        protected override void Save()
        {
            if (ValidateForm())
            {
                var orderCorrection = new OrderCorrectionModel
                {
                    porel_id = _orderCorrection.porel_id,
                    Podet_Id = txtPodet_Id.Text,
                    Porel_Itemcode = txtPorel_Itemcode.Text,
                    Porel_Pono = txtPorel_Pono.Text,
                    Porel_Poline = txtPorel_Poline.Text,
                    Porel_Qty = txtPorel_Qty.Text,
                    Porel_Tstamp = dtpPorel_Tstamp.Value
                };

                UpdateOrderCorrection(orderCorrection);

                ReloadOrdersCorrection?.Invoke(btnSave, new OrderCorrectionEventArgs(orderCorrection));

                Close();
            }
        }

        private void UpdateOrderCorrection(OrderCorrectionModel orderCorrection)
        {
            OrderCorrectionRepository.UpdateOrder(orderCorrection);
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion  
    }
}

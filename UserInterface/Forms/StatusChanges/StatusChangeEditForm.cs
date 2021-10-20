using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.UserInterface.Classes;
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

namespace SmayDbEditor.UserInterface.Forms.StatusChanges
{
    public partial class StatusChangeEditForm : BaseEditForm
    {
        #region Fields

        public EventHandler ReloadStatusChanges;
        private StatusChangeModel _statusChange;

        #endregion
        #region Constructor

        public StatusChangeEditForm(int statusChangeId)
        {
            InitializeComponent();
            _statusChange = GetFakeStatusChange(statusChangeId);
            PrepareStatusChangeData(_statusChange);
            ValidateControls();
        }

        #endregion
        #region Private Methods

        private void PrepareStatusChangeData(StatusChangeModel statusChange)
        {
            txtimph_num.Text = statusChange.imph_num;
            txtimph_type.Text = statusChange.imph_type;
            txtimph_status.Text = statusChange.imph_status;
        }

        private StatusChangeModel GetFakeStatusChange(int statusChangeId)
        {
            return StatusChangeRepository.GetStatus(statusChangeId);
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtimph_status.Text))
            {
                epStatus.SetError(txtimph_status, "Pole status jest wymagane.");
            }
            else
            {
                epStatus.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string statusErrorMessage = epStatus.GetError(txtimph_status);
            if (!string.IsNullOrEmpty(statusErrorMessage))
            {
                sbErrorMessage.Append(statusErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show("Pole nie może być puste");
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

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion
        #region Override

        protected override void Save()
        {
            if (ValidateForm())
            {
                var statusChange = new StatusChangeModel
                {
                    imph_id = _statusChange.imph_id,
                    //imph_num = txtimph_num.Text,
                    imph_type = txtimph_type.Text,
                    imph_status = txtimph_status.Text
                };

                UpdateStatusChange(statusChange);



                ReloadStatusChanges?.Invoke(btnSave, new StatusChangeEventArgs(statusChange));

                Close();
            }
        }

        private void UpdateStatusChange(StatusChangeModel statusChange)
        {
            StatusChangeRepository.UpdateStatus(statusChange);
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion
    }
}

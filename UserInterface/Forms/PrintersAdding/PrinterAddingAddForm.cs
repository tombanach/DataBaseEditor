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

namespace SmayDbEditor.UserInterface.Forms.PrintersAdding
{
    public partial class PrinterAddingAddForm : BaseEditForm
    {
        #region Fields
        public EventHandler ReloadPrintersAdding;
        private PrinterAddingModel _printerAdding;

        #endregion
        #region Constructor

        public PrinterAddingAddForm()
        {
            InitializeComponent();
            _printerAdding = new PrinterAddingModel();
            PreparePrinterAddingData(_printerAdding);
            ValidateControls();
        }

        #endregion
        #region Private Methods

        private void PreparePrinterAddingData(PrinterAddingModel printerAdding)
        {
            txtComputerName.Text = printerAdding.hostname;
            txtPrinterName.Text = printerAdding.PrinterName;
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtPrinterName.Text))
            {
                epPrinterName.SetError(txtPrinterName, "Nazwa Drukarki jest wymagana.");
            }
            else
            {
                epPrinterName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtComputerName.Text))
            {
                epComputerName.SetError(txtComputerName, "Nazwa Komputera jest wymagana.");
            }
            else
            {
                epComputerName.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string printerNameErrorMessage = epPrinterName.GetError(txtPrinterName);
            if (!string.IsNullOrEmpty(printerNameErrorMessage))
            {
                sbErrorMessage.Append(printerNameErrorMessage);
            }

            string computerNameErrorMessage = epComputerName.GetError(txtComputerName);
            if (!string.IsNullOrEmpty(computerNameErrorMessage))
            {
                sbErrorMessage.Append(computerNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show("Pole nie może być puste.");
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

        private void txtPrinterName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        #endregion
        #region Override

        protected override void Save()
        {
            if (!ValidateForm())
            {
                return;
            }

            var printerAdding = new PrinterAddingModel
            {
                PrinterName = txtPrinterName.Text,
                hostname = txtComputerName.Text
            };

            PrinterAddingRepository.AddPrinter(printerAdding);

            // printerAdding = ModifyPrinterAdding(printerAdding);

            ReloadPrintersAdding?.Invoke(btnSave, new PrinterAddingEventArgs(printerAdding));
            Close();
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion

        private void PrinterAddingAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

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
    public partial class PrinterAddingEditForm : BaseEditForm
    {
        #region Fields

        private PrinterAddingModel printerAdding;
        public EventHandler ReloadPrintersAdding;

        #endregion
        #region Constructor

        public PrinterAddingEditForm(int printerAddingId)
        {
            InitializeComponent();
            printerAdding = GetFakePrinterAdding(printerAddingId);
            PreparePrinterAddingData(printerAdding);
            ValidateControls();
        }

        private void PreparePrinterAddingData(PrinterAddingModel printerAdding)
        {
            txtPrinterName.Text = printerAdding.PrinterName;
            txtComputerName.Text = printerAdding.hostname;
        }

        #endregion
        #region Private Methods

        private PrinterAddingModel GetFakePrinterAdding(int printerAddingId)
        {
            IList<PrinterAddingModel> fakePrintersAddingModel = new List<PrinterAddingModel>()
            {
                new PrinterAddingModel()
                {
                    id = 1,
                    PrinterName = "Bullzip PDF Printer",
                    hostname = "LAPT87"
                },

                new PrinterAddingModel()
                {
                    id = 2,
                    PrinterName = "ZebraSPIDI",
                    hostname = "KOMP130"
                },

                new PrinterAddingModel()
                {
                    id = 3,
                    PrinterName = "ZebraMagC78",
                    hostname = "x"
                }
            };

            PrinterAddingModel fakePrinterAddingModel = fakePrintersAddingModel.Where(x => x.id == printerAddingId).FirstOrDefault();
            return fakePrinterAddingModel;
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
            if (ValidateForm())
            {

                printerAdding.PrinterName = txtPrinterName.Text;
                printerAdding.hostname = txtComputerName.Text;    
                
                // printerAdding = ModifyPrinterAdding(printerAdding);

                ReloadPrintersAdding?.Invoke(btnSave, new PrinterAddingEventArgs(printerAdding));

                Close();
            }
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion
    }
}

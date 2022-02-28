using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Repository;
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

namespace SmayDbEditor.UserInterface.Forms.PrintersAdding
{
    public partial class PrintersAddingForm : BaseForm
    {
        #region Fields

        private static PrintersAddingForm _instance = null;
        private static IList<PrinterAddingViewModel> fakePrintersAdding;

        #endregion
        #region Properties

        public static PrintersAddingForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PrintersAddingForm();
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

        public PrintersAddingForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakePrintersAdding = GetFakePrintersAdding();
            PreparePrintersAddingData();
        }

        private void PreparePrintersAddingData()
        {
            bsPrintersAdding.DataSource = new BindingList<PrinterAddingViewModel>(fakePrintersAdding);
            dgvPrintersAdding.DataSource = bsPrintersAdding;
        }

        private IList<PrinterAddingViewModel> GetFakePrintersAdding()
        {
            var printers = PrinterAddingRepository.GetPrinters();
            return MappingHelper.MapPrinterAddingModelToPrinterAddingViewModel(printers);
        }

        #endregion
        #region Events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PrinterAddingAddForm frm = new PrinterAddingAddForm();
            frm.ReloadPrintersAdding += (s, ea) =>
            {
                PrinterAddingEventArgs eventArgs = ea as PrinterAddingEventArgs;
                if (eventArgs != null)
                {
                    PrinterAddingViewModel printerAdding
                        = MappingHelper.MapPrinterAddingModelToPrinterAddingViewModel(eventArgs.PrinterAdding);
                }
                RefreshGrid();
            };
            frm.ShowDialog();
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int printerAddingId = Convert.ToInt32(dgvPrintersAdding.CurrentRow.Cells["col_id"].Value);
            int selectedRowIndex = dgvPrintersAdding.CurrentRow.Index;

            PrinterAddingEditForm frm = new PrinterAddingEditForm(printerAddingId);
            frm.ReloadPrintersAdding += (s, ea) =>
            {
                PrinterAddingEventArgs eventArgs = ea as PrinterAddingEventArgs;
                if (eventArgs != null)
                {
                    PrinterAddingViewModel printerAdding
                        = MappingHelper.MapPrinterAddingModelToPrinterAddingViewModel(eventArgs.PrinterAdding);
                    bsPrintersAdding[selectedRowIndex] = printerAdding;
                }
                RefreshGrid();
            };
            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int printerAddingId = Convert.ToInt32(dgvPrintersAdding.CurrentRow.Cells["col_id"].Value);
            int selectedRowIndex = dgvPrintersAdding.CurrentRow.Index;

            PrinterAddingRepository.DeletePrinter(printerAddingId);
            RefreshGrid();
        }

        private void PrintersAddingForm_FormClosed(object sender, FormClosedEventArgs e)
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

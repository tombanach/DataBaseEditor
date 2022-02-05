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
            fakePrintersAdding = GetFakePrintersAdding();
            PreparePrintersAddingData();
        }

        #endregion
        #region Private Methods

        private void PreparePrintersAddingData()
        {
            bsPrintersAdding.DataSource = new BindingList<PrinterAddingViewModel>(fakePrintersAdding);
            dgvPrintersAdding.DataSource = bsPrintersAdding;
        }

        private IList<PrinterAddingViewModel> GetFakePrintersAdding()
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

            return MappingHelper.MapPrinterAddingModelToPrinterAddingViewModel(fakePrintersAddingModel);
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
                    bsPrintersAdding.Add(printerAdding);

                    dgvPrintersAdding.ClearSelection();
                    dgvPrintersAdding.Rows[dgvPrintersAdding.Rows.Count - 1].Selected = true;
                }
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
            };
            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int printerAddingId = Convert.ToInt32(dgvPrintersAdding.CurrentRow.Cells["col_id"].Value);
            int selectedRowIndex = dgvPrintersAdding.CurrentRow.Index;

            // RemovePrinterAdding(printerAddingId);

            PrinterAddingViewModel printerAdding = fakePrintersAdding.Where(x => x.id == printerAddingId).FirstOrDefault();
            if (printerAdding != null)
            {
                bsPrintersAdding.Remove(printerAdding);

                if (dgvPrintersAdding.Rows.Count > 1)
                {
                    dgvPrintersAdding.ClearSelection();
                    dgvPrintersAdding.Rows[dgvPrintersAdding.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void PrintersAddingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion        
    }
}

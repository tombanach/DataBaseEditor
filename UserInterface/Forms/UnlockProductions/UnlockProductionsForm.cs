using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Repository;
using SmayDbEditor.DataAccessLayer.ViewModel;
using SmayDbEditor.UserInterface.Forms.Base;
using SmayDbEditor.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmayDbEditor.UserInterface.Forms.UnlockProductions
{
    public partial class UnlockProductionsForm : BaseForm
    {
        #region Fields

        private static UnlockProductionsForm _instance = null;
        private static IList<UnlockProductionViewModel> fakeUnlockProductions;

        #endregion
        #region Properties

        public static UnlockProductionsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UnlockProductionsForm();
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

        public UnlockProductionsForm()
        {
            InitializeComponent();
            RefreshGrid();            
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeUnlockProductions = GetFakeUnlockProductions();
            PrepareUnlockProductionsData();
        }

        private void PrepareUnlockProductionsData()
        {
            bsUnlockProductions.DataSource = new BindingList<UnlockProductionViewModel>(fakeUnlockProductions);
            dgvUnlockProductions.DataSource = bsUnlockProductions;
        }

        private IList<UnlockProductionViewModel> GetFakeUnlockProductions()
        {
            var documents = UnlockProductionRepository.GetDocuments();
            return MappingHelper.MapUnlockProductionModelToUnlockProductionViewModel(documents);
        }        

        #endregion
        #region Events

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int unlockProductionId = Convert.ToInt32(dgvUnlockProductions.CurrentRow.Cells["col_proccode"].Value);
            int selectedRowIndex = dgvUnlockProductions.CurrentRow.Index;

            // UnlockProductionRemove(unlockProductionId);

            UnlockProductionRepository.DeleteDocument(unlockProductionId);
            RefreshGrid();
        }

        private void UnlockProductionsForm_FormClosed(object sender, FormClosedEventArgs e)
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

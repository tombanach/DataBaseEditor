using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Repository;
using SmayDbEditor.DataAccessLayer.ViewModel;
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

namespace SmayDbEditor.UserInterface.Forms.KanbansRemove
{
    public partial class KanbansRemoveForm : BaseForm
    {
        #region Fields

        private static KanbansRemoveForm _instance = null;
        private static IList<KanbanRemoveViewModel> fakeKanbansRemove;

        #endregion
        #region Properties

        public static KanbansRemoveForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KanbansRemoveForm();
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

        public KanbansRemoveForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        #endregion
        #region Private Methods

        private void RefreshGrid()
        {
            fakeKanbansRemove = GetFakeKanbansRemove();
            PrepareKanbansRemoveData();
        }

        private void PrepareKanbansRemoveData()
        {
            bsKanbansRemove.DataSource = new BindingList<KanbanRemoveViewModel>(fakeKanbansRemove);
            dgvKanbansRemove.DataSource = bsKanbansRemove;
        }

        private IList<KanbanRemoveViewModel> GetFakeKanbansRemove()
        {
            var kanbans = KanbanRemoveRepository.GetKanbans();
            return MappingHelper.MapKanbanRemoveModelToKanbanRemoveViewModel(kanbans);
        }

        #endregion
        #region Events

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int kanbanRemoveId = Convert.ToInt32(dgvKanbansRemove.CurrentRow.Cells["col_kbtr_id"].Value);
            int selectedRowIndex = dgvKanbansRemove.CurrentRow.Index;

            // RemoveKanbanRemove(kanbanRemoveId);

            KanbanRemoveRepository.DeleteKanban(kanbanRemoveId);
            RefreshGrid();
        }

        private void KanbansRemoveForm_FormClosed(object sender, FormClosedEventArgs e)
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

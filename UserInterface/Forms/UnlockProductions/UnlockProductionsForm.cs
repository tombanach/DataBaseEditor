using SmayDbEditor.DataAccessLayer.Models;
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

namespace SmayDbEditor.UserInterface.Forms.UnlockProductions
{
    public partial class UnlockProductionsForm : BaseForm
    {
        private static UnlockProductionsForm _instance = null;
        private static IList<UnlockProductionViewModel> fakeUnlockProductions;

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

        public UnlockProductionsForm()
        {
            InitializeComponent();
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
            IList<UnlockProductionModel> fakeUnlockProductionsModel = new List<UnlockProductionModel>()
            {
                new UnlockProductionModel()
                {
                    ProcCode = 1,
                    ProcName = "",
                    UserName = "",
                    TimeStarted = DateTime.Now,
                }
            };        
            
            return MappingHelper.MapUnlockProductionModelToUnlockProductionViewModel(fakeUnlockProductionsModel);
        }

        private void UnlockProductionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}

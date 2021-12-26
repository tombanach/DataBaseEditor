using SmayDbEditor.DataAccessLayer;
using SmayDbEditor.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface;

namespace SmayDbEditor.UserInterface.Forms.Base
{
    public partial class BaseForm : Form
    {
        #region Constructor

        public BaseForm()
        {
            InitializeComponent();
        }

        #endregion
        #region OrderCorrectionRepository

        private IOrderCorrectionRepository _orderCorrectionRepository;

        protected IOrderCorrectionRepository OrderCorrectionRepository
        {
            get
            {
                if (_orderCorrectionRepository == null)
                {
                    _orderCorrectionRepository = (IOrderCorrectionRepository)Program.ServiceProvider.GetService(typeof(IOrderCorrectionRepository));
                }
                return _orderCorrectionRepository;
            }
        }

        #endregion
        #region StatusChangeRepository

        private IStatusChangeRepository _statusChangeRepository;

        protected IStatusChangeRepository StatusChangeRepository
        {
            get
            {
                if (_statusChangeRepository == null)
                {
                    _statusChangeRepository = (IStatusChangeRepository)Program.ServiceProvider.GetService(typeof(IStatusChangeRepository));
                }
                return _statusChangeRepository;
            }
        }

        #endregion
        #region KanbanRemoveRepository

        private IKanbanRemoveRepository _kanbanRemoveRepository;

        protected IKanbanRemoveRepository KanbanRemoveRepository
        {
            get
            {
                if (_kanbanRemoveRepository == null)
                {
                    _kanbanRemoveRepository = (IKanbanRemoveRepository)Program.ServiceProvider.GetService(typeof(IKanbanRemoveRepository));
                }
                return _kanbanRemoveRepository;
            }
        }

        #endregion
        #region OrderAddressChangeRepository

        private IOrderAddressChangeRepository _orderAddressChangeRepository;

        protected IOrderAddressChangeRepository OrderAddressChangeRepository
        {
            get
            {
                if (_orderAddressChangeRepository == null)
                {
                    _orderAddressChangeRepository = (IOrderAddressChangeRepository)Program.ServiceProvider.GetService(typeof(IOrderAddressChangeRepository));
                }
                return _orderAddressChangeRepository;
            }
        }

        #endregion
        #region UnlockProductionRepository

        private IUnlockProductionRepository _unlockProductionRepository;

        protected IUnlockProductionRepository UnlockProductionRepository
        {
            get
            {
                if (_unlockProductionRepository == null)
                {
                    _unlockProductionRepository = (IUnlockProductionRepository)Program.ServiceProvider.GetService(typeof(IUnlockProductionRepository));
                }
                return _unlockProductionRepository;
            }
        }

        #endregion
        #region LogRepository



        #endregion
    }
}

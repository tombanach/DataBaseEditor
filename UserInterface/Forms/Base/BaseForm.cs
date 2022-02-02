using SmayDbEditor.DataAccessLayer;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.ViewModel;
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

        private ILogRepository _logRepository;

        protected ILogRepository LogRepository
        {
            get
            {
                if (_logRepository == null)
                {
                    _logRepository = (ILogRepository)Program.ServiceProvider.GetService(typeof(ILogRepository));
                }
                return _logRepository;
            }
        }

        #endregion


        private IAuthRepository _authRepository;

        protected IAuthRepository AuthRepository
        {
            get
            {
                if (_authRepository == null)
                {
                    _authRepository = (IAuthRepository)Program.ServiceProvider.GetService(typeof(IAuthRepository));
                }
                return _authRepository;
            }
        }

        private IUserRepository _userRepository;

        protected IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = (IUserRepository)Program.ServiceProvider.GetService(typeof(IUserRepository));
                }
                return _userRepository;
            }
        }
    }
}

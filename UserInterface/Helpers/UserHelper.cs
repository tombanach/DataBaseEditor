using SmayDbEditor.DataAccessLayer.ViewModel;

namespace SmayDbEditor.UserInterface.Helpers
{
    internal static class UserHelper
    {
        private static UserViewModel _userViewModel;

        public static UserViewModel ActiveUser
        {
            get
            {
                return _userViewModel;
            }

            set
            {
                if (_userViewModel == null)
                {
                    _userViewModel = value;
                }
            }
        }
    }
}

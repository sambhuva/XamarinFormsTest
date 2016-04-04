using GalaSoft.MvvmLight;

namespace XamarinFormsTest.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string _password;
        private string _userName;
        public string MainText => "Login Page";

        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged();}
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; RaisePropertyChanged();}
        }
    }
}

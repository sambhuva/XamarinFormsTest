using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XamarinFormsTest.Services;

namespace XamarinFormsTest.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        private string _password;
        private string _userName;
        private ICommand _loginCommand;
        private ILoginManager _loginManager;
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

        public ICommand LoginCommand
        {
            get { return _loginCommand ?? (_loginCommand = new RelayCommand(Login)); }
        }

        private void Login()
        {
            var result = _loginManager.LoginAsync();
        }
    }
}

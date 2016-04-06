using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsTest.ViewModel;

namespace XamarinFormsTest.Services
{
    public class LoginManager : ILoginManager
    {
        private readonly IDbService _dataBaseService;

        public LoginManager(IDbService databaseService)
        {
            _dataBaseService = databaseService;
        }

        public bool Login()
        {
            _dataBaseService.Open();
            var userData = _dataBaseService.GetUserNameAndPassword();
            return false;
        }
    }
}

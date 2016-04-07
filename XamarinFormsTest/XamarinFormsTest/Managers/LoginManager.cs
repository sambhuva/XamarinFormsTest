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
        private readonly IWebService _webService;

        public LoginManager(IDbService databaseService, IWebService webService)
        {
            _dataBaseService = databaseService;
            _webService = webService;
        }

        public async Task<bool> LoginAsync()
        {
            return await Task.Run(async () =>
             {
                 try
                 {
                     _dataBaseService.Open();
                     var userData = _dataBaseService.GetUserNameAndPassword();
                     await _webService.LoginToPage(userData);
                     if (userData == null)
                         return false;
                 }
                 catch
                 {
                     return false;
                 }
                 return true;
             });
        }
    }
}

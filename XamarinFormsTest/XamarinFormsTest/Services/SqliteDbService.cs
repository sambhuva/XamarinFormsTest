using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using SQLite;
using XamarinFormsTest.Model;

namespace XamarinFormsTest.Services
{
    public class SqliteDbService : IDbService
    {
        private SQLiteConnection _sqlService;

        public bool Open()
        {
            try
            {
                _sqlService = ServiceLocator.Current.GetInstance<ISQLite>().GetConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public UserLoginData GetUserNameAndPassword()
        {
            _sqlService.CreateTable<LoginInfo>();
            var userTable = _sqlService.Table<LoginInfo>();
            var userTableInfo = userTable.FirstOrDefault();
            if (userTableInfo == null)
            {
                return null;
            }
            return new UserLoginData() { Password = userTableInfo.Password, UserName = userTableInfo.UserName };
        }
    }

    [Table("LoginTable")]
    public class LoginInfo
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}

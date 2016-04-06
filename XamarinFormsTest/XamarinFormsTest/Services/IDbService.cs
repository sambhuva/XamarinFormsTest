using XamarinFormsTest.Model;

namespace XamarinFormsTest.Services
{
    public interface IDbService
    {
        bool Open();
        UserLoginData GetUserNameAndPassword();
    }
}
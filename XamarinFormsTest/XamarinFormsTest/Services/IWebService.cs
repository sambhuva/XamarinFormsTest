using System.Threading.Tasks;
using XamarinFormsTest.Model;

namespace XamarinFormsTest.Services
{
    public interface IWebService
    {
        Task LoginToPage(UserLoginData userData);
    }
}
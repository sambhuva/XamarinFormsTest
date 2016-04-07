using System.Threading.Tasks;

namespace XamarinFormsTest.Services
{
    public interface ILoginManager
    {
        Task<bool> LoginAsync();
    }
}
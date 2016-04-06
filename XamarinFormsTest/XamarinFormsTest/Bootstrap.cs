using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using XamarinFormsTest.Services;

namespace XamarinFormsTest
{
    public class Bootstrap
    {
        public static void Run()
        {
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IDbService, SqliteDbService>();
            SimpleIoc.Default.Register<ILoginManager, LoginManager>();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
        }
    }
}
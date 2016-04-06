using GalaSoft.MvvmLight.Ioc;
using XamarinFormsTest.Services;

namespace XamarinFormsTest.Droid
{
    public class AndroidBootstrap
    {
        public static void Run()
        {
            SimpleIoc.Default.Register<ISQLite, SQLite_Android>(); ;
        }
    }
}
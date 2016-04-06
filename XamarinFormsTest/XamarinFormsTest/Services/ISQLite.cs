using SQLite;

namespace XamarinFormsTest.Services
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
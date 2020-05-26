

using SQLite;

namespace SqlLiteExample.Helper
{
    public interface ISqliteConnection 
    {
        SQLiteConnection GetConnection();
        
    }
}

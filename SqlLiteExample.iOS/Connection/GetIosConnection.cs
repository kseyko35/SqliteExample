using System;
using SQLite;
using SqlLiteExample.Helper;
using SqlLiteExample.iOS.Connection;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetIosConnection))]
namespace SqlLiteExample.iOS.Connection
{
    public class GetIosConnection : ISqliteConnection
    {
        public SQLiteConnection GetConnection()
        {
            try
            {
                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string path = System.IO.Path.Combine(documentPath, App.DB_NAME);
                var connection = new SQLiteConnection(path);
                return connection;
            }
            catch (Exception ex)
            {
                Console.Write(ex + "Android Sqlite Problem");
                return null;
            }
        }
    }
}

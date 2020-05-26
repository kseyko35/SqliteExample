using SQLite;
using SqlLiteExample.Droid.ConnectionHelper;
using SqlLiteExample.Helper;
using System;
using System.Diagnostics;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetDroidConnection))]
namespace SqlLiteExample.Droid.ConnectionHelper
{
    public class GetDroidConnection : ISqliteConnection
    {
        public SQLiteConnection GetConnection()
        {
            try
            {
                string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                var path = System.IO.Path.Combine(documentPath, App.DB_NAME);
                //var platform = new SQLitePlatformAndroid();
                var connection = new SQLiteConnection(path);

                return connection;
            }
            catch (Exception ex)
            {
                Debug.Write(ex + "Error Sqlite");
                return null;
            }
            


        }
    }
}

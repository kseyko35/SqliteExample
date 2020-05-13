using System;
using System.Collections.Generic;
using SQLite;
using SqlLiteExample.Models;
using Xamarin.Forms;

namespace SqlLiteExample.Helper
{
    public class SqlitManager
    {
        SQLiteConnection _sqlconnection;

        public SqlitManager()
        {
            _sqlconnection = DependencyService.Get<ISqliteConnection>().GetConnection();
            _sqlconnection.CreateTable<Student>(); // Sqlite icerisinde Student modelinden olusan bir tablo olusturuldu
        }

        #region CRUD

        public int Insert(Student s)
        {
            return _sqlconnection.Insert(s);
        }
        public int Update(Student s)
        {
            return _sqlconnection.Update(s);
        }
        public int Delete(int id)
        {
            return _sqlconnection.Delete<Student>(id);
        }
        public IEnumerable<Student> GetAll()
        {
            return _sqlconnection.Table<Student>();
        }
        public Student Get(int id)
        {
            return _sqlconnection.Table<Student>().Where(x => x.Id == id).FirstOrDefault();
        }
        public void Dispose()
        {
            _sqlconnection.Dispose();
        }


        #endregion
    }
}

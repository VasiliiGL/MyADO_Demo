using MySql.Data.MySqlClient;
using System;
//using System.Data.Common;

namespace ADO_Demo.DB
{
    public class DataBase
    {
        //private DbConnection _db;

        //public DataBase(DbConnection db)
        //{
        //    _db = db;
        //}

        private MySqlConnection _db;
        private const string Str = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";

        public DataBase()
        {
            _db = new MySqlConnection (Str);
        }


    }
}

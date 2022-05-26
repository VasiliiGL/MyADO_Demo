using MySql.Data.MySqlClient;
using System;
//using System.Data.Common;

namespace ADO_Demo.DB
{
    public abstract class DataBase
    {
        //private DbConnection _db;

        //public DataBase(DbConnection db)
        //{
        //    _db = db;
        //}

       
        private const string Str = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        protected MySqlConnection _db;
        protected MySqlCommand _command;

        protected DataBase()
        {
            _db = new MySqlConnection (Str);
            _command = new MySqlCommand { Connection =_db};
            //_command.Connection = _db;
        }


    }
}

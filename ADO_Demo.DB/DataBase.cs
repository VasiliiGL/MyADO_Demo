using ADO_Demo.DB.Config;
using MySql.Data.MySqlClient;
using System;
using System.IO;
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

       
       // private const string Str = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        protected MySqlConnection _db;
        protected MySqlCommand _command;

        protected DataBase()
        {
            
            using var file = new StreamReader("config_db.json");
            var condig =ConfigDb.ImportFromJson(file.ReadToEnd());
            _db = new MySqlConnection (condig.ToString());
            _command = new MySqlCommand { Connection =_db};
            //_command.Connection = _db;
        }


    }
}

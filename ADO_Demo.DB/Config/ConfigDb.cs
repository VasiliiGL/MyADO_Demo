using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ADO_Demo.DB.Config
{
    class ConfigDb
    {
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }

        public static ConfigDb ImportFromJson( string json )
        {
           return JsonSerializer.Deserialize<ConfigDb>(json);
        }

        public override string ToString ()
        {
            return $"Server={Server};Database={DataBase};Uid={Uid};Pwd={Pwd};";
        }
    }
}

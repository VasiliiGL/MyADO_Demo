using System;
using System.Collections.Generic;
using System.Text;
using ADO_Demo.DB.Models;
using Dapper;

namespace ADO_Demo.DB.CRUDs
{
    public class AccountCrud : DataBase
    {
        public AccountCrud() : base()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
        public IEnumerable<Account> GetAllAcounts()
        {
            _db.Open();
            //// var sql = "SELECT tab_users.id AS 'id', first_name, last_name, email FROM tab_users JOIN tab_user_email.id = tab_user_emails.user_id";
            //var sql = " SELECT * FROM host1323541_itstep1.tab_users";
            //var result = _db.Query<User>(sql);

            var sql = "SELECT * FROM tab_accounts";
            var result = _db.Query<Account>(sql);

            _db.Close();
            return result;
        }
    }
}

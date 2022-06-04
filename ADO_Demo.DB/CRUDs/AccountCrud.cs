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

        public Role roleAccount { get; set; }
        public IEnumerable<Account> GetAllAcounts()
        {
            _db.Open();
           
            var sql = "SELECT * FROM tab_accounts";
            var result = _db.Query<Account>(sql);

            _db.Close();
            return result;
        }

       public Role GetRole( Account account)
        {
            var roles = new List<Role>();
            var roleCrud = new RoleCrud();
            _db.Open();
            roles = new List<Role>(roleCrud.GetAllRoles());
            foreach (var role in roles)
            {
                if (account.RoleId == role.Id)
                {
                    roleAccount = role;
                }
            }
            _db.Close();

            return roleAccount;
        }
    }
}

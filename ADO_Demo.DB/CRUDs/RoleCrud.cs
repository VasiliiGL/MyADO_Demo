using ADO_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_Demo.DB.CRUDs
{
    public class RoleCrud: DataBase
    {
        public RoleCrud() : base() { }

        public List<Role> GetAllRoles ()
        {
            var roles = new List<Role>();
            _db.Open();

            //var sql = "SELECT id, role FROM tab_roles;";
            _command.CommandText = "SELECT id, role FROM tab_roles;"; 
            var result = _command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    roles.Add(new Role
                    {
                        Id=result.GetInt32("Id"),
                        RoleName = result.GetString ("role")
                    });
                }

            }
            _db.Close();

            return roles;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_Demo.DB.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}

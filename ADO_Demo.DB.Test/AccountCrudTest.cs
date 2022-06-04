using ADO_Demo.DB.CRUDs;
using ADO_Demo.DB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADO_Demo.DB.Test
{
    public class AccountCrudTest
    {
        [Fact]
        public void GetAllAccount_Test()
        {
            var expectedAccount = new List<Account>
            {
                new Account
                {
                    Id = 1,
                    Login = "_guest",
                    Password = "123",
                    RoleId = 1,
                    IsActive = true
                },
                new Account
                {
                    Id = 2,
                    Login = "anna",
                    Password = "12345",
                    RoleId = 2,
                    IsActive = true
                },
                 new Account
                {
                    Id = 3,
                    Login = "ad",
                    Password = "123",
                    RoleId = 3,
                    IsActive = true
                }
            };

            var accountCrud = new AccountCrud();
            var actualAccount = accountCrud.GetAllAcounts();
            Assert.Equal(expectedAccount, actualAccount);
        }
    }
}

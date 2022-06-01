using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ADO_Demo.DB.Models;
using ADO_Demo.DB.CRUDs;

namespace ADO_Demo.DB.Test
{
    public class UserCrudTest
    {
        [Fact]
        public void GetAlUsers_Test()
        {
            var expectedUsers = new List<User>
            {
                new User
                {
                    id = 1,
                    FirstName = "Anonim",
                    LastName = "Anonimus"
                },
                new User
                {
                    id = 2,
                    FirstName = "Anna",
                    LastName = "Karenina"
                }
                ,
                new User
                {
                    id = 3,
                    FirstName = "Admin",
                    LastName = "Adminus"
                }

            };

            var userCrud = new UserCrud();
            var actualUsers = userCrud.GetAllUsers();
            Assert.Equal(expectedUsers,actualUsers);
        }
    }
}

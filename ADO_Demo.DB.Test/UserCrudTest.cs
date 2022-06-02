using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ADO_Demo.DB.Models;
using ADO_Demo.DB.CRUDs;
using System.Linq;

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
                    LastName = "Anonimus",
                    Emails = new List <string> ()
                },
                new User
                {
                    id = 2,
                    FirstName = "Anna",
                    LastName = "Karenina",
                    Emails = new List <string> ()
                    {
                        "anna@karenina.ru"
                    }
                }
                ,
                new User
                {
                    id = 3,
                    FirstName = "Admin",
                    LastName = "Adminus",
                     Emails = new List <string> ()
                    {
                        "admin@admin.ru",
                        "ad@admin.ru"
                    }
                }

            };

            var userCrud = new UserCrud();
            var actualUsers = userCrud.GetAllUsers().ToList();
            //Assert.Equal(expectedUsers,actualUsers);
            Assert.Equal(expectedUsers[0].Emails, actualUsers[0].Emails);
        }
    }
}

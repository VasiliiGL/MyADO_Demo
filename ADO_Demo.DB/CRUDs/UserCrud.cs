using ADO_Demo.DB.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ADO_Demo.DB.CRUDs
{
    public class UserCrud : DataBase
    {
        class User
        {
            public int id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class UserEmails
        {
            public int id { get; set; }
            public int UserId { get; set; }
            public string Email{ get; set; }
        }

        private IEnumerable<User> getAllUsers ()
        {
            _db.Open();
            var sql = " SELECT * FROM host1323541_itstep1.tab_users";
            var result = _db.Query<User>(sql);
            _db.Close();
            return result;

        }

        private IEnumerable<UserEmails> getAllEmails ()
        {
            _db.Open();
            var sql = " SELECT * FROM host1323541_itstep1.tab_user_emails";
            var result = _db.Query<UserEmails>(sql);
            _db.Close();
            return result;
        }

        public UserCrud() : base() 
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        public IEnumerable<Models.User> GetAllUsers()
        {
            //_db.Open();
            //// var sql = "SELECT tab_users.id AS 'id', first_name, last_name, email FROM tab_users JOIN tab_user_email.id = tab_user_emails.user_id";
            //var sql = " SELECT * FROM host1323541_itstep1.tab_users";
            //var result = _db.Query<User>(sql);
            //_db.Close();
            //return result;


            var users = getAllUsers();
            var emails = getAllEmails();

            //return (from user in users
            //        let resultEmails = (from email in emails
            //                            where email.UserId == user.id
            //                            select email.Email).ToList()
            //        select new Models.User
            //        {
            //            id = user.id,
            //            FirstName = user.FirstName,
            //            LastName = user.LastName,
            //            Emails = resultEmails

            //        }).ToList();


            var result = new List<Models.User>();
            foreach (var user in users)
            {
                var resultEmails = new List<string>();
                //foreach (var email in emails )
                //{
                //    if (email.UserId == user.id)
                //    {
                //        resultEmails.Add(email.Email);
                //    }
                //}
                resultEmails.AddRange(from email in emails
                                      where email.UserId == user.id
                                      select email.Email);
                //resultEmails = (from email in emails
                //                where email.UserId == user.id
                //                select email.Email).ToList();

                result.Add(new Models.User
                {
                    id = user.id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Emails = resultEmails
                });
            }

            return result;

        }


    }
}

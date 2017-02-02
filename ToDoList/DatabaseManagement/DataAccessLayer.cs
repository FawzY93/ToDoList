using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models.DataModels;

namespace ToDoList.DatabaseManagement
{
    public class DataAccessLayer : IDataAccessLayer
    {
        public bool AddUser(User user)
        {
            using (var dbCntxt = this.getDatabaseContext())
            {
                try
                {
                    dbCntxt.Users.Add(user);
                    dbCntxt.SaveChanges();
                    return true;
                } catch
                {
                    return false;
                }
            }
        }

        public List<User> getAllUsers()
        {
            using (var dbCntxt = this.getDatabaseContext())
            {
                var users = dbCntxt.Users.ToList<User>();
                return users;
            }
        }

        public User getUser(string employeeId)
        {
             using (var dbCntxt = this.getDatabaseContext()) {
                var user = dbCntxt.Users.Find(employeeId);
                return user;
            }
        }

        private DBContext getDatabaseContext ()
        {
            return new DBContext();
        }

    }
}
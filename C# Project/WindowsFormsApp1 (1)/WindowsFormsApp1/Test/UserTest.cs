using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Models;

namespace WinFormsApp1.test
{
    public  class usertest
    {

        AppContext appContext; 
        public usertest()
        {

            appContext = new AppContext(); 
        }


        public  bool FindUser(string username)
        {
            if(appContext.Users.Select(e => e.Name).ToList().Contains(username))
            {
                return true; 
            }
            return false; 
        }

        public bool AddUser(User user)
        {
            appContext.Users.Add(user);
            appContext.SaveChanges();

            if (appContext.Users.Select(e => e.SSN).ToList().Contains(user.SSN))
            {
                return true;
            }

            return false;
        }

        public bool GetAllUsers()
        {
            var users = appContext.Users.ToList();
            if (users != null) 
            {
                return true;
            }        
            return false;
        }

        public bool GetUserById(int userId)
        {
            var user = appContext.Users.Where(u => u.ID == userId).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateUser(User updatedUser)
        {
            appContext.Users.Add(updatedUser);
            appContext.SaveChanges();
            var existingUser = appContext.Users.FirstOrDefault(u => u.ID == updatedUser.ID);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Email = updatedUser.Email;
                existingUser.SSN = updatedUser.SSN;

                appContext.SaveChanges();
                appContext.Users.Remove(updatedUser);
                appContext.SaveChanges();

                return true;
            }
            return false;
        }

        public bool DeleteUser(string ssn)
        {
            var userToDelete = appContext.Users.Where(u => u.SSN == ssn).FirstOrDefault();
            var user = userToDelete;
            if (userToDelete != null)
            {
                appContext.Users.Remove(userToDelete);
                appContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

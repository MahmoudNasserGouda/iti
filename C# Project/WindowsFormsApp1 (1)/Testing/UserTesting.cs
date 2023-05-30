using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WinFormsApp1.Models;
using WinFormsApp1.test;

namespace Testing
{
    [TestClass]
    public class UserTesting
    {
        [TestMethod]
        public void FindUserTesting()
        {
            usertest UserTest = new usertest();
            var result = UserTest.FindUser("John Doe"); 
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void AddUSerTesting()
        {
            User user = new User() 
            {
                  Name =  "ahmedsss", SSN = "ffffff", Phone = "25fff22fff", Email = "aafffa@gmail.com"
            };
            usertest UserTest = new usertest();
            var result = UserTest.AddUser(user);

            Assert.IsTrue(result); 
        
        }

        [TestMethod]
        public void GetAllUsersTesting()
        {
            usertest UserTest = new usertest();

            Assert.IsTrue(UserTest.GetAllUsers());

        }

        [TestMethod]
        public void GetUserByIdTesting()
        {
            usertest UserTest = new usertest();
            var result = UserTest.GetUserById(1);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void UpdateUserTesting()
        {
            User user = new User()
            {
                Name = "ahmedsss",
                SSN = "ffffff",
                Phone = "25fff22fff",
                Email = "aafffa@gmail.com"
            };
            usertest UserTest = new usertest();
            var result = UserTest.UpdateUser(user);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void DeleteUserTesting()
        {
            usertest UserTest = new usertest();
            var result = UserTest.DeleteUser("ffffff");

            Assert.IsTrue(result);
        }
    }
}

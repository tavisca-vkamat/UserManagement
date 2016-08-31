using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;
using UserManagement.Operations;


namespace UserManagement.Test
{
    [TestClass]
    public class CreateUserTest
    {
        [TestMethod]
        public void TestForUserIdZero()
        {
           
            User user = new User();
            user.Id = 0;
            user.firstName = "vivekkk";
            user.lastName = "kamatllll";
            user.emailId = "vkahjgmat@tavisca.com";
            user.phoneNumber = "0123456789";

            int id = InsertUser.Insert(user);

            Assert.IsTrue(id > 0,"User created");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFirstNameNull()
        {
            User user = new User();
            user.Id = 0;
            user.lastName = "bond";
            user.emailId = "bond@tavisca.com";
            user.phoneNumber = "4563456789";

            int id = InsertUser.Insert(user);

            Assert.IsTrue(id > 0, "User created");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestForUserIdNotSet()
        {
            User user = new User();
            user.Id = -1;
            user.firstName = "vivek";
            user.lastName = "kamat";
            user.emailId = "vkamat@tavisca.com";
            user.phoneNumber = "0123456789";

            InsertUser.Insert(user);
        }
    }
}

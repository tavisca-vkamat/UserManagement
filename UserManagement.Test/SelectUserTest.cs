using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;
using System.Collections.Generic;
using UserManagement.Operations;

namespace UserManagement.Test
{
    [TestClass]
    public class SelectUserTest
    {
        [TestMethod]
        public void TestSelectAllUsers()
        {
            List<User> arrayOfUsers =  SelectUser.SelectAll();

            Assert.IsNotNull(arrayOfUsers);

        }

        [TestMethod]
        public void testSelectByIdUser()
        {
            UserTable user = SelectUser.SelectById(1);

            Assert.IsNotNull(user);
            Assert.IsTrue(user.FIrstName == "vivek");

        }
    }
}

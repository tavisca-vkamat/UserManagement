using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Operations;

namespace UserManagement.Test
{
    [TestClass]
    public class DeleteUserTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDeleteUserById()
        {
            bool result = DeleteUser.DeleteById(15);
            Assert.IsTrue(result);
        }
    }
}

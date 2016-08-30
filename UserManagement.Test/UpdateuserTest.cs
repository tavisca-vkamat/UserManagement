using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Operations;

namespace UserManagement.Test
{
    [TestClass]
    public class UpdateuserTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateUserById()
        {
            bool result = UpdateUser.UpdateFirstName(15,"vicky");
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateUserTestPhoneNumber()
        {
            bool result = UpdateUser.UpdatePhoneNumber(7, "9876541230");
            Assert.IsTrue(result);
        }
    }
}

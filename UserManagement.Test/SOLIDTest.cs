using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagement.Entities;

namespace UserManagement.Test
{
    [TestClass]
    public class SOLIDTest
    {
        [TestMethod]
        public void UserSelectTestUsingSoldPrinciple()
        {
            IUser user = ObjectFactory.GetInstanceIUser();

            UserTable u = user.SelectById(15);
            Assert.AreEqual(u.FIrstName.ToString(), "vicky");
        }

        [TestMethod]
        public void UserUpdateFirstNameTest()
        {
            IUser user = ObjectFactory.GetInstanceIUser();

            bool result = user.UpdateFirstName(19,"Don");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UserDeleteByIdTest()
        {
            IUser user = ObjectFactory.GetInstanceIUser();

            bool result = user.DeleteById(17);
            Assert.IsTrue(result);
        }
    }
}

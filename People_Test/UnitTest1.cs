using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("KOKC", "54321", "Ilya@gmail.com", 79992647826);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("KOKC", people.Login);
            
        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("Ilya@gmail.com", people.Email);

        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(79992647826, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("54321", people.Pass);

        }
    }
}

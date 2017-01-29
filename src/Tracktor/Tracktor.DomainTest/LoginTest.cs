using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void BasicLoginTest()
        {
            var le = new LoginEntity();
            le.Username = "user";
            le.Password = "pass";

            Assert.AreEqual(le.Username, "user", "Wrong username");
            Assert.AreEqual(le.Password, "pass", "Wrong password");
        }
    }
}

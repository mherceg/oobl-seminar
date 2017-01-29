using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void BasicCategoryTest()
        {
            var ce = new CategoryEntity();
            ce.Id = 2;
            ce.Name = "CategoryOne";
            Assert.AreEqual(ce.Id, 2, 0, "Wrong Id");
            Assert.AreEqual(ce.Name, "CategoryOne", "Wrong Name");
        }
    }
}

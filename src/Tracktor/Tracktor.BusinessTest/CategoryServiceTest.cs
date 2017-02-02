using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.DAL.Database;
using Moq;
using Tracktor.Business.Implementation;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Tracktor.BusinessTest
{
    [TestClass]
    public class CategoryServiceTest
    {
        [TestMethod]
        public void TestMethod1() {

            var data = new List<Category>
            {
                new Category { Id = 4, Name = "Mirko"},
                new Category { Id = 2, Name = "Slavko"},
            };
            var data2 = data.AsQueryable();
            var mockSet = new Mock<DbSet<Category>>();
            var mockContext = new Mock<TracktorDb>();
            mockContext.Setup(m => m.Category).Returns(mockSet.Object);
            /*mockSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());*/

            var cs = new CategoryServices(mockContext.Object);
            //cs.Insert(new Domain.CategoryEntity() { Id = 4, Name = "7" });

            //Assert.AreEqual(1, cs.ListAll().Count, "Wrong count");


        }
    }
}

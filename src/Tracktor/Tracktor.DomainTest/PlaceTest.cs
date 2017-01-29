using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class PlaceTest
    {
        [TestMethod]
        public void BasicPlaceTest()
        {
            var pe = new PlaceEntity();
            pe.Id = 7;
            pe.Name = "FER";
            var loc = new GeoCoordinate(12.25, 25.5);
            pe.Location = loc;

            Assert.AreEqual(pe.Id, 7, "Wrong Id");
            Assert.AreEqual(pe.Name, "FER", "Wrong Name");
            Assert.AreEqual(pe.Location, loc, "Wrong Location");
        }
    }
}

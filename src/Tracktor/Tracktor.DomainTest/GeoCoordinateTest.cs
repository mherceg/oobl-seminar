using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class GeoCoordinateTest
    {
        [TestMethod]
        public void BasicGeoCoordinateTest()
        {
            var gc = new GeoCoordinate(2.14, 3.65);
            Assert.AreEqual(gc.Latitude, 2.14, 0.001, "Wrong Latitude");
            Assert.AreEqual(gc.Longitude, 3.65, 0.001, "Wrong Longitude");
        }
    }
}

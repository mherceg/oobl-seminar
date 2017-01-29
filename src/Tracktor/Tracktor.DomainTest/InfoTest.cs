using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;
using System.Collections.Generic;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class InfoTest
    {
        [TestMethod]
        public void BasicInfoTest()
        {
            var ie = new InfoEntity();
            ie.Id = 8;
            var time = DateTime.Now;
            ie.time = time;
            ie.endTime = time.AddHours(100);
            ie.content = "Info content";

            Assert.AreEqual(ie.Id, 8, "Wrong Id");
            Assert.AreEqual(ie.time, time, "Wrong time");
            Assert.AreEqual(ie.endTime, time.AddHours(100), "Wrong endTime");
            Assert.AreEqual(ie.content, "Info content", "Wrong content");

            var reputation = new List<ReputationInfoEntity>();
            var rep = new ReputationInfoEntity();
            rep.ContentCommentId = 7;
            rep.Id = 4;
            rep.Score = true;
            rep.UserId = 6;
            reputation.Add(rep);
            reputation.Add(rep);
            ie.reputation = reputation;
            Assert.AreEqual(ie.GetReputation(), 2, 0, "Wrong reputation calculation");

            rep = new ReputationInfoEntity();
            rep.Score = false;
            reputation.Add(rep);
            ie.reputation = reputation;
            Assert.AreEqual(ie.GetReputation(), 1, 0, "Wrong reputation subtraction");

        }
    }
}

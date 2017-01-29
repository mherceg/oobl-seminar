using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracktor.Domain;
using System.Collections.Generic;

namespace Tracktor.DomainTest
{
    [TestClass]
    public class CommentTest
    {
        [TestMethod]
        public void BasicCommentTest()
        {
            var ce = new CommentEntity();
            ce.Id = 7;
            ce.UserId = 2;
            ce.ContentInfoId = 14;
            var time = DateTime.Now;
            ce.EndTime = time;
            ce.Content = "Comment content";

            Assert.AreEqual(ce.Id, 7, 0, "Wrong Id");
            Assert.AreEqual(ce.UserId, 2, 0, "Wrong UserId");
            Assert.AreEqual(ce.EndTime, time, "Wrong EndTime");
            Assert.AreEqual(ce.ContentInfoId, 14, 0, "Wrong ContentInfoId");
            Assert.AreEqual(ce.Content, "Comment content", "Wrong content");

            var reputation = new List<ReputationCommentEntity>();
            var rep = new ReputationCommentEntity();
            rep.ContentCommentId = 7;
            rep.Id = 4;
            rep.Score = true;
            rep.UserId = 6;
            reputation.Add(rep);
            reputation.Add(rep);
            ce.reputation = reputation;
            Assert.AreEqual(ce.GetReputation(), 2, 0, "Wrong reputation calculation");

            rep = new ReputationCommentEntity();
            rep.Score = false;
            reputation.Add(rep);
            ce.reputation = reputation;
            Assert.AreEqual(ce.GetReputation(), 1, 0, "Wrong reputation subtraction");

        }
    }
}

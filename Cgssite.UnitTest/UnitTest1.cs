using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cgssite.Domain;
using Cgssite.Application;
using Cgssite.Infrastructure;

namespace Cgssite.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PagingTest()
        {
            Paging page1 = new Paging(100);
            Paging page2 = new Paging(100, 10);
            Paging page3 = new Paging(101);
            Assert.AreEqual(2, page1.NextPage);
            Assert.AreEqual(-1, page2.NextPage);
            Assert.AreEqual(11, page3.TotalPage);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CgsSite.Domain;
using CgsSite.Application;
using CgsSite.Infrastructure;

namespace CgsSite.UnitTest
{
    [TestClass]
    public class PagingTest
    {
        [TestMethod]
        public void Paging_Constructor_IsNextPageRight()
        {
            Paging page1 = new Paging(100);
            Paging page2 = new Paging(100, 10);
            
            Assert.AreEqual(2, page1.NextPage);
            Assert.AreEqual(-1, page2.NextPage);
            
        }
        [TestMethod]
        public void Paging_Constructor_IsTotalPageRight()
        {
            Paging page3 = new Paging(101);
            Assert.AreEqual(11, page3.TotalPage);
        }
    }
}

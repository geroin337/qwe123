using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegTDD;
using System;

namespace Reg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Search searchPays = new Search();
            Assert.IsTrue(searchPays.SearchEnter("123", "123"));
        }
        public void Test2()
        {
           
        }

    }
}

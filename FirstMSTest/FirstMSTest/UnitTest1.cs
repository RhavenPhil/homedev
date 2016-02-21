using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            int y = 4;
            int result = x + y;
            Assert.IsTrue(result == 8);
        }


        [TestMethod]
        public void TestMethod2()
        {
            
            int x = 5;
            int y = 4;
            int result = x + y;
            Assert.IsTrue(result == 9);
        }
    }
}

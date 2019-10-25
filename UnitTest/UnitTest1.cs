using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test1
            Util util = new Util();

            // act

            var result = util.Person();


            // assert

            Assert.Equals('B', );
        }
    }
}

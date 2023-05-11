using lb8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lb8.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class Task1Test
        {
            Task1 t = new Task1();
            [TestMethod]
            public void functionTest()
            {
                int a = 5, b = 0, c = -6;

                Assert.AreEqual(0, t.function(a));
                Assert.AreEqual(0, t.function(b));
                Assert.AreEqual(11, t.function(c));
            }

            [TestMethod]
            public void changeTest()
            {
                int a = 3, b = 6;
                Assert.AreEqual((6, 3), t.change(a, b));
            }
        }

        [TestClass]
        public class Task2Test
        {
            Task2 t = new Task2();
            [TestMethod]
            public void theLargestTest()
            {
                int a = 5, b = 2, c = 10;
                Assert.AreEqual(10, t.theLargest(a, b, c));
            }

            [TestMethod]
            public void sumAndProizTest()
            {
                int a = 325;
                Assert.AreEqual((10, 30), t.sumAndProiz(a));
            }
        }

        [TestClass]
        public class Task3Test
        {
            Task3 t = new Task3();
            [TestMethod]
            public void factorialTest()
            {
                int a = 4;
                Assert.AreEqual(24, t.factorial(a));
            }

            [TestMethod]
            public void largestNumberTest()
            {
                int a = 764580;
                Assert.AreEqual(8, t.largestNumber(a));
            }
        }
    }
}

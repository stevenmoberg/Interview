using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Test06 : BaseTest
    {
        [TestMethod]
        public void Should_Know_Call_Hierarchy()
        {
            Assert.Fail("remove and fill in expected behavior below");

            Sample obj = new Sample();
            Sample.First();
            obj.Second(10);

            // what will be the output
            // 1) write answer here
            // 2) verify against test output
        }

        class Sample
        {
            public static void First()
            {
                Console.WriteLine("first method");
            }
            public void Second()
            {
                First();
                Console.WriteLine("second method");
            }
            public void Second(int i)
            {
                Console.WriteLine(i);
                Second();
            }
        }


        [TestMethod]
        public void Should_Know_Parameter_Passing()
        {
            // Arrange
            int num = 2;

            // Act
            Fun1(ref num);

            // Assert
            // {code} - define the expected results
            Assert.AreEqual(0, num);
        }

        static void Fun1(ref int num)
        {
            num = num * num * num;
        }

    }
}

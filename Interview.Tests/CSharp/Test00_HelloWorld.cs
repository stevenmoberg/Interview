using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Test00 : BaseTest
    {
        [TestMethod]
        public void Should_Create_Hello()
        {
            // Create and define the AAA steps for simiple "Hello World" unit test

            // 1) A = Arrange - setup test values
            // {code} - setup test variable

            // 2) A = ?
            // {code} - invoke test method

            // 3) A = ?
            // {code} - write simple assertion of expected value "Hello!"

            throw new Exception("used to fail initial test - remove this");
        }

        [TestMethod]
        public void Should_Create_HelloWorld()
        {
            // Create and define the AAA steps for simiple "Hello World" unit test

            // 1) A = Arrange - setup test values
            // {code} - setup test variable

            // 2) A = ?
            // {code} - invoke test method

            // 3) A = ?
            // {code} - write simple assertion of expected value "Hello World!"

            throw new Exception("used to fail initial test - remove this");
        }


        #region Test Helper

        private class HelloWold
        {
            public string Name { get; set; }

            public string GetMessage()
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return "Hello!";
                else
                    return $"Hello {Name}!";
            }
        }

        #endregion
    }
}

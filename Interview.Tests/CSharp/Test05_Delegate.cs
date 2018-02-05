using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests.CSharp
{
    [TestClass]
    public class Test05 : BaseTest
    {
        delegate void Iterator();

        [TestMethod]
        public void Should_Know_Delegate_Behavior()
        {
            // Arrange
            var values = new List<int>();
            var iterators = new List<Iterator>();

            // Act
            for (int i = 0; i < 15; i++)
                iterators.Add(delegate { values.Add(i); });

            foreach (var iterator in iterators)
                iterator();

            // Assert
            // {code} - populated expected results
            var expected = new int[] { }; 
            var actual = values.ToArray();
            
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

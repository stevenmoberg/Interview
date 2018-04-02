using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_SimpleAdding
    {
        [Easy]
        [TestMethod]
        public void Sould_Do_SimpleAdding()
        {
            // AAA
            Assert.AreEqual(78, SimpleAdding(12));
            Assert.AreEqual(9870, SimpleAdding(140));
        }


        /// <summary>
        /// Add up all numbers from 1 to n
        /// input 4 = 1 + 2 + 3 + 4 = 10
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int SimpleAdding(int num)
        {
            return 0;
        }
    }
}

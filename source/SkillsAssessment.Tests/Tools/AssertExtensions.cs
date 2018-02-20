using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests
{
    public static class AssertEx
    {
        /// <summary>
        /// Deserialize and compare JSON
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void AreEqual(object expected, object actual)
        {
            var exp = JsonHelper.ToJson(expected, true);
            var act = JsonHelper.ToJson(actual, true);

            Assert.AreEqual(exp, act);
        }
    }
}

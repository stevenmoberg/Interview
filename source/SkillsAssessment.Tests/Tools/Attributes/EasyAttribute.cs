using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests
{
    public class EasyAttribute : TestCategoryBaseAttribute
    {
        public override IList<string> TestCategories => new List<string>(1) { "101 Easy" };
    }
}

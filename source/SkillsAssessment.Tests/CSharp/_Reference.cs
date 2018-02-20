using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class _Reference
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Debug.WriteLine("AssemblyInit " + context.TestName);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("AssemblyCleanup");
        }

        [ClassInitialize]
        public void TestFixtureSetup() { }

        [ClassCleanup]
        public void TestFixtureTearDown() { }

        [TestInitialize]
        public void Setup() { }

        [TestCleanup]
        public void Treardown() { }

        [TestMethod]
        [Description("Pust a description here")]
        public void Should_Do_Something() { }

        [TestMethod]
        // [DataSource("sql connection string", "table")]
        // [DeploymentItem(@"\\testdata")]
        public void Test_With_Pameters(int input1, int input2) { }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        public void Test_With_Other_Parameters(int value) { }

        [Ignore] // don't run this test
        [TestCategory("CategoryA")] // what does this do
        [Priority(2)] // what does this do
        [TestMethod]
        [TestCategory("trait")]
        [TestProperty("name", "value")]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void Test_With_Priority()
        {
            // https://msdn.microsoft.com/en-us/library/ms243147.aspx
            // https://msdn.microsoft.com/en-us/library/hh270865.aspx

            Assert.AreEqual(1, 2, "These do not equal");
            // CollectionAssert.
            // StringAssert
            // AssertFailedException
            // AssertInconclusiveException
            // UnitTestAssertException

            // TestContext.DataRow
            // TestContext.DataConnection


            // OwnerAttribute
            // DeploymentItemAttribute
            // DescriptionAttribute
            // HostTypeAttribute
            // IgnoreAttribute
            // PriorityAttribute
            // TestPropertyAttribute
            // WorkItemAttribute

            // TestConfiguration
            // TestConfigurationSection

            // CssIterationAttribute
            // CssProjectStructureAttribute

            // PrivateObject
            // PrivateType
        }

    }
}

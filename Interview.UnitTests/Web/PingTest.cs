using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Interview.UnitTests.Web
{
    [TestClass]
    public class PingTests : BaseWebTest
    {
        [TestMethod]
        public void Should_Return_Ping()
        {
            var response = sut.Client.GetAsync("/ping").Result;

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [TestMethod]
        public void Should_Return_Values()
        {
            var json = sut.Client.GetStringAsync("/values").Result;
            var items = JsonConvert.DeserializeObject<List<string>>(json);

            items.Should().HaveCount(2);
            items.Should().BeEquivalentTo("item1", "item2");
        }

        // ignore - view load exceptions
        // [TestMethod]
        public void Should_Return_View()
        {
            var html = sut.Client.GetStringAsync("/").Result;
            // var items = JsonConvert.DeserializeObject<List<string>>(json);

            // items.Should().HaveCount(2);
            // items.Should().BeEquivalentTo("item1", "item2");

            Assert.Fail("test");
        }
    }
}

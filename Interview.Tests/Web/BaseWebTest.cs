using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Interview.Tests.Web
{
    public abstract class BaseWebTest : BaseTest
    {
        private TestServer _server;
        private HttpClient _client;


        [ClassInitialize]
        public void FixtureInit()
        {
            // web is in core 2.0
            // unit test is in 4.6.1

            //var builder = new WebHostBuilder()
            //    .UseContentRoot("....")
            //    .UseEnvironment("Development")
            //    .UseStartup<WebApp.Startup>()

            // _server = TestServer.Create<Startup>();
            // _client = _server.CreateClient();
        }

        [ClassCleanup]
        public void FixtureDispose()
        {
            _server.Dispose();
        }
    }
}

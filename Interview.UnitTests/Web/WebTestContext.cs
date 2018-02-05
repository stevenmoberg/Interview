using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Interview.UnitTests.Web
{
    public class WebTestContext : IDisposable
    {
        private TestServer _server;
        public HttpClient Client { get; private set; }

        public WebTestContext()
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(@"C:\Projects\Interview\Interview.WebApp\wwwroot")
                .UseEnvironment("Test")
                .UseStartup<Interview.WebApp.Startup>();

            _server = new TestServer(builder);
            Client = _server.CreateClient();
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Client?.Dispose();
                Client = null;

                _server?.Dispose();
                _server = null;
            }
        }

        #endregion
    }
}

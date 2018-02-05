using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Interview.UnitTests.Web
{
    [TestClass]
    public class BaseWebTest : IDisposable
    {
        // ClassInitialize & ClassCleanup need to be static
        // which does not run with inheritance
        // class setup and teardown moved to constructor and dispose

        /// <summary>
        /// Constructor / Class Initializer
        /// </summary>
        public BaseWebTest()
        {
            sut = new WebTestContext();
        }

        /// <summary>
        /// Test logging
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        protected void Log(string format, params object[] args)
        {
            Console.WriteLine(string.Format(format, args));
        }

        /// <summary>
        /// System Under Test
        /// </summary>
        protected WebTestContext sut;


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
                sut?.Dispose();
                sut = null;
            }
        }

        #endregion
    }
}

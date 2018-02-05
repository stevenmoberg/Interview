using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tests
{
    public abstract class BaseTest
    {
        /// <summary>
        /// Log output to test console
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        protected void Log(string format, params object[] args)
        {
            var message = args?.Length > 0
                ? string.Format(format, args)
                : format;

            Console.WriteLine(message);
        }
    }
}

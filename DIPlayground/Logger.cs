using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DIPlayground
{
    interface ILogger
    {
        void Log(string text);
    }

    class Logger : ILogger
    {
        public void Log(string text) => Debug.WriteLine("Log: " + text);
    }

    class DammyLogger : ILogger
    {
        public void Log(string text)
        {
            // nop
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    public class LogManager
    {
        public static LogManager logManager;

        public static LogManager Default => logManager ??= new LogManager();

        public event EventHandler<string> OnLogAdded;

        public void Log(string message)
        {
            OnLogAdded?.Invoke(this, message);
        }
    }
}

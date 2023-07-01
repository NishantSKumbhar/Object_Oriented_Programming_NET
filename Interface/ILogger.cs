using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    internal interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}

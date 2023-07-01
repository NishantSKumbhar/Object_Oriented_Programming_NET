using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    internal class ConsoleLogger: ILogger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void LogError(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

    }
}

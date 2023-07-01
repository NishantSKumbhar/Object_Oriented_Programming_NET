using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    internal class FileLogger: ILogger
    {
        private readonly string _path;
        public FileLogger(string path) 
        {
            _path = path;
        }

        public void LogInfo(string message)
        {
            
            WriteInFile(message, "Info");
        }

        public void LogError(string message)
        {
            
            WriteInFile(message, "Error");
        }

        public void WriteInFile(string message, string messageType)
        {
            using(StreamWriter streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine(messageType + " : " + message + " : " + DateTime.Now);
                // streamwriter.Dispose();
            }
            
        }
    }
}

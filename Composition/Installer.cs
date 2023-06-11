using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Composition
{
    internal class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            Console.WriteLine("Installation Done !");
        }
    }
}

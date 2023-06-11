using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;
using Console_OOP.Composition;

namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Logger logger1 = new Logger();

            Installer vsCode = new Installer(logger1);

            vsCode.Install();

            DbMigrator database = new DbMigrator(new Logger());

            database.Migrate();
        }
    }
}

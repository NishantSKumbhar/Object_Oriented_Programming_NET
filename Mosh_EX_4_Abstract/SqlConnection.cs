using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_4_Abstract
{
    internal class SqlConnection: DbConnection
    {
        public SqlConnection(string NewConnectionString) : base(NewConnectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection opened.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection closed.");
        }
    }
}

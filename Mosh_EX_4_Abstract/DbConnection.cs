using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_4_Abstract
{
    internal abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string NewConnectionString)
        {
            if(NewConnectionString == null || NewConnectionString == "")
            {
                throw new ArgumentNullException("Database Connection string can not be empty !");
            }
            ConnectionString = NewConnectionString;
            
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}

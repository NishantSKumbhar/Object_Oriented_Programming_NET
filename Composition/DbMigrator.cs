using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Composition
{
    internal class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            this._logger.Log("Migraton Done !");
        }
    }
}

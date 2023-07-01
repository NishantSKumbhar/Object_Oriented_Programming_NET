using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    internal class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // print start and finish
            _logger.LogInfo("Migrating Started at "+ DateTime.Now);

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }
}

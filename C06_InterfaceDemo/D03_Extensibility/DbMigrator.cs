using System;

namespace D03_Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            //Console.WriteLine("Migration started at {0}", DateTime.Now);
            //// Details of migrating the database
            //Console.WriteLine("Migration finished at {0}", DateTime.Now);

            _logger.LogInfo("Migration started at " + DateTime.Now);
            //// Details of migrating the database
            _logger.LogInfo("Migration finished at " + DateTime.Now);

        }
    }
}

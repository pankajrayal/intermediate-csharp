namespace D03_Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\data\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}

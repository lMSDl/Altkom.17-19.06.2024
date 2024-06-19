namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Insert(DbLog log)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + log.Message);
        }
    }
}
namespace SharedComponents
{
    public class SqlDriver : IPersistenceDriver
    {
        private string connectionString;

        public SqlDriver(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
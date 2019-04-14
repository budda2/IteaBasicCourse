using System;

namespace ExampleWithFakeDb.DbConnections
{
    public abstract class DbConnectionBase : IDbConnection
    {
        protected string ConnectionString { get; private set; }

        public DbConnectionBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Close()
        {
            Console.WriteLine($"{GetConnectionType()} connection closed.");
        }

        public void Open()
        {
            Console.WriteLine($"{GetConnectionType()} connection opened.");
        }

        public abstract string ExecuteQuerry(string query);

        protected abstract string GetConnectionType();
    }
}

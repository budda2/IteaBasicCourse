using System;

namespace ExampleWithFakeDb.DbConnections
{
    public class LocalDbConnection : DbConnectionBase
    {
        public LocalDbConnection(string connectionString) 
            : base(connectionString)
        {
        }

        public override string ExecuteQuerry(string query)
        {
            Console.WriteLine($"Executing {query};");
            return "Querry executed on local db with no issues.";
        }

        protected override string GetConnectionType()
        {
            return "Local";
        }
    }
}

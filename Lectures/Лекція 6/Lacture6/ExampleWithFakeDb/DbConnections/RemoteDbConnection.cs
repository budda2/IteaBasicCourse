using System;

namespace ExampleWithFakeDb.DbConnections
{
    public class RemoteDbConnection : DbConnectionBase
    {
        public RemoteDbConnection(string connectionString) 
            : base(connectionString)
        {
        }

        public override string ExecuteQuerry(string query)
        {
            throw new InvalidOperationException("No internet access");
        }

        protected override string GetConnectionType()
        {
            return "Remote";
        }
    }
}

using ExampleWithFakeDb.Azure;
using System;

namespace ExampleWithFakeDb.DbConnections
{
    public class AzureDbconnection : DbConnectionBase
    {
        private IAzureService AzureService { get; }

        public AzureDbconnection(string connectionString, IAzureService azureService)
            : base(connectionString)
        {
            AzureService = azureService;
        }

        public override string ExecuteQuerry(string query)
        {
            Console.WriteLine($"Sending request to Azure to be executed by provided service");
            return AzureService.Execute(query);
        }

        protected override string GetConnectionType()
        {
            throw new NotImplementedException();
        }
    }
}

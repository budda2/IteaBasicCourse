using ExampleWithFakeDb.DbConnections;

namespace ExampleWithFakeDb.Buisness
{
    public class AuditSystem
    {
        private IDbConnection DbConnection { get; }
        public AuditSystem()
        {

        }

        public void StorePurchaseForFutureAudits(IPurchase purchase)
        {
            StorePurchaseToLocalStore(purchase);
            StorePurchaseToDb(purchase);
        }

        private void StorePurchaseToLocalStore(IPurchase purchase)
        {
            //I amd not sure how to store it locally, but let's assume it is somehow done.
        }

        private void StorePurchaseToDb(IPurchase purchase)
        {
            var purchaseJson = Newtonsoft.Json.JsonConvert.SerializeObject(purchase);
            var querry = $"Insert into dbo.Purchase {purchaseJson}";

        }
    }
}

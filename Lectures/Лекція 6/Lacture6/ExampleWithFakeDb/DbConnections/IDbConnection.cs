namespace ExampleWithFakeDb.DbConnections
{
    public interface IDbConnection
    {
        void Open();
        void Close();
        string ExecuteQuerry(string query);
    }
}

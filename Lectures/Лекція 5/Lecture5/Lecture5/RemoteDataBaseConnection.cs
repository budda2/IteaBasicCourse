namespace Lecture5
{
    public class RemoteDataBaseConnection : DataBaseConnection
    {
        public RemoteDataBaseConnection(string databaseName, string sqlServerName)
            : base(databaseName, sqlServerName)
        {
        }

        protected override string GetDataBaseType()
        {
            return "Remote database;";
        }
    }
}

namespace Lecture5
{
    public class LocalDataBaseConnection : DataBaseConnection
    {
        public LocalDataBaseConnection(string databaseName, string sqlServerName) 
            : base(databaseName, sqlServerName)
        {
        }

        protected override string GetDataBaseType()
        {
            return "Local database;";
        }
    }
}

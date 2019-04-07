using System;

namespace Lecture5
{
    public class DataBaseConnection
    {
        private bool _connectionOpened;
        public DataBaseConnection(string databaseName, string sqlServerName)
        {

        }

        public void Open()
        {
            _connectionOpened = true;
            Console.WriteLine("Database connection opened.");
        }

        public void Close()
        {
            _connectionOpened = false;
            Console.WriteLine("Database connection closed.");
        }

        public void ExecuteSqlCommand(string sql)
        {
            Console.WriteLine($"Executing {sql} on database: {GetDataBaseType()}");
        }

        protected virtual string GetDataBaseType()
        {
            return "dtabase type unknown;";
        }
    }
}

using Lecture5;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorph();
        }

        private static void Polymorph()
        {
            var localConnection = new LocalDataBaseConnection("name", "name");
            var remoteConnection = new RemoteDataBaseConnection("name", "name");

            localConnection.Open();
            remoteConnection.Open();

            localConnection.ExecuteSqlCommand("Some sql command.");
            remoteConnection.ExecuteSqlCommand("Some sql command.");

            localConnection.Close();
            remoteConnection.Close();

            Console.ReadLine();
        }

        private static void Cast()
        {
            //UpCast
            var localDbConnection = new LocalDataBaseConnection("name", "name");

            DataBaseConnection dbConnection = localDbConnection; //success with no issues as DataBaseConnection is parent class.
            object obj = localDbConnection;//success with no issues as object is parent class of all the other classes.

            //Downcast/Direct cast
            DataBaseConnection dbConnection1 = (DataBaseConnection)obj; // cast is successfull as we have stored in obj variable reference on local db connection.
            LocalDataBaseConnection localDataBaseConnection1 = (LocalDataBaseConnection)dbConnection1; // cast is successfull as we have stored in dbconnection1 variable reference on local db connection.

            object obj1 = "Hello, i am not database connection";
            DataBaseConnection dbConnection2 = (DataBaseConnection)obj1; //compiles, but will fail on runtime.

            if (obj1 is DataBaseConnection connection)
            {
                connection.Open();
            }
            else
            {
                // handle not expected onject type.
            }

            //Other direct casts;
            int a = 12;
            short b = (short)a;
            double d = a;
            a = (int)d;
        }
    }
}

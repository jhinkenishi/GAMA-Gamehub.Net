using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace GAMA_Gamehub.database
{
    public class Database
    {
        public const string SERVER = "localhost";
        public const string USERNAME = "root";
        public const string DATABASE_NAME = "gama_gamehub";
        public const string PORT = "3306";
        public const string PASSWORD = "";

        private MySqlConnection? connection;
        private MySqlCommand? command;
        private MySqlDataReader? reader;
        private static Database instance;
        private Database() { }

        public void Connect()
        {
            string connStr = String.Format("server={0};user={1};database={2};port={3};password={4};", SERVER, USERNAME, DATABASE_NAME, PORT, PASSWORD);
            connection = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Loading...Database");
                connection.Open();

            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public bool Query(string sql)
        {
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            return reader.Read();
        }

        public void Close()
        {
            connection?.Close();
        }

        public static Database GetInstance()
        {
            if(instance is null)
            {
               instance = new Database();
            }

            return instance;
        }

    }
}

using System.Configuration;
using MySql.Data.MySqlClient;

namespace HotelReservation.Data
{
    public static class DatabaseHelper
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public static string ConnectionString => _connectionString;
    }
}

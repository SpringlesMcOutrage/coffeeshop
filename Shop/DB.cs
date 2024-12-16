using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shop
{
    public class DB

    {
        private MySqlConnection connection;

        public DB()
        {
            connection = new MySqlConnection("server=127.0.0.1; user=root; database=coffeeshop; password=");
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command.ExecuteScalar(); 
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Praktika2.Helper
{
    public static class DBconnection
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;



        public static void MakeConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "admin";
                builder.Database = "duombaze";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("nepavyko prisijungti");
            }

        }

        public static MySqlCommand RunQuery(string query, string username)
        {

            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch(Exception ex)
            {
                connection.Close();

            }
            return cmd;

        }

        public static MySqlCommand Query(string query) {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }

            }
            catch(Exception ex) {
            
                 connection.Close();
            
            }
            return cmd;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika2.Users;
using MySql.Data.MySqlClient;
using Praktika2.Helper;
using System.Data;

namespace Praktika2.DB
{
   public static class DBuser
   {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static User RetriveUser(string username)
        {
            string query = "SELECT * FROM duombaze.vartotojas where vart_vardas = (@username) limit 1";
            cmd = DBconnection.RunQuery(query, username);
            User aUser = null;
            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    string uName = dr["vart_vardas"].ToString();
                    string password = dr["slaptazodis"].ToString();
                    string type = dr["tipas"].ToString();
                    aUser = new User(uName, password, type);
                                
                }

            }
            return aUser;

        }

   }

}

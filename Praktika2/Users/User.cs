using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika2.Helper;

namespace Praktika2.Users
{ 
    public class User
    {
        private string username;
        private string password;
        private string type;

        public User() { }
        public User(string username, string password, string type)
        {
            UserName = username;
            Password = password;
            Type = type;
        }

        public String UserName
        {

            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        
        public virtual void user_create(string uname, string pword, string type)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`vartotojas` (`vart_vardas`, `slaptazodis`, `tipas`) VALUES ('" + uname + "', '" + pword + "', '"+type+"');";

            cmd = DBconnection.Query(query);


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Praktika2.Helper;

namespace Praktika2.Users
{
    public class Group : Teacher
    {
        private string name;
        private string faculty;

        public Group(string name, string faculty)
        {

            Name = name;
            Faculty = faculty;

        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public override void create(string g_name, string faculty, string extra)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`grupe` (`pavadinimas`, `fakultetas`) VALUES ('" + g_name + "', '" + faculty + "');";

            cmd = DBconnection.Query(query);

        }


    }
}

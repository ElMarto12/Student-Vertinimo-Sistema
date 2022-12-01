using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using Praktika2.Helper;

namespace Praktika2.Users
{
    public class Teacher : User
    {
        private string name;
        private string lname;

        public Teacher(){}

        public Teacher(string name, string lname)
        {
            Name = name;
            Lname = lname;

        }
 

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        //polymorphic method
        public virtual void create(string teach_name, string teach_lname, string extra)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`destytojas` (`id_vartotojas`,`vardas`, `pavarde`) VALUES((SELECT id_vartotojas FROM vartotojas WHERE vart_vardas = '"+teach_name+"'), '"+teach_name+"', '"+teach_lname+"');";

            cmd = DBconnection.Query(query);
        }

        //method from User class -- creates teacher user in DataBase
        public override void user_create(string name, string lname, string type)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`vartotojas` (`vart_vardas`, `slaptazodis`, `tipas`) VALUES ('"+name+"', '"+lname+"', '"+type+"');";

            cmd = DBconnection.Query(query);


        }
    }

}

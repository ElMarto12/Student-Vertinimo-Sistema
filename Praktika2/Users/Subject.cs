using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Praktika2.Helper;

namespace Praktika2.Users
{
    public class Subject : Teacher
    {
        private string sub_name;

        public Subject(string sub_name) {
        
            Sub_Name= sub_name;
        
        }

        public String Sub_Name
        {
            get { return sub_name; }
            set { sub_name = value; }

        }

        public override void create(string name, string teach_id, string non2)
        {
            MySqlCommand cmd = null;
           
            string query = "INSERT INTO `duombaze`.`dalykas` (`pavadinimas`,`id_destytojas`) VALUES ('"+name+"',(SELECT id_destytojas FROM destytojas WHERE vardas='"+teach_id+"'));";

            cmd = DBconnection.Query(query);

        }

    }
}

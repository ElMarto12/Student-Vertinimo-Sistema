using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika2.Helper;

namespace Praktika2.Users
{
    public class Student : Teacher
    {
        private string st_name;
        private string st_lname;

        public Student(string st_name, string st_lname)
        {
            St_Name= st_name;
            St_Lname= st_lname;
        }

        public String St_Name
        {
            get { return st_name; }
            set { st_name = value; }
        }

        public String St_Lname
        {
            get { return st_lname; }
            set { st_lname = value; }
        }

        public override void user_create(string name, string lname, string type)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`vartotojas` (`vart_vardas`, `slaptazodis`, `tipas`) VALUES ('" + name + "', '" + lname + "', '"+type+"');";

            cmd = DBconnection.Query(query);
        }

        public override void create(string st_name, string st_lname, string select)
        {

            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`studentas` (`id_vartotojas`,`vardas`, `pavarde`, `id_grupe`) VALUES ((SELECT id_vartotojas FROM vartotojas WHERE vart_vardas='"+st_name+"'), '"+st_name+"', '"+st_lname+"',(SELECT id_grupe FROM grupe WHERE pavadinimas='"+select+"'));";
  
            cmd = DBconnection.Query(query);

        }
    }
}

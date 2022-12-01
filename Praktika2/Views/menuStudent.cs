using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Praktika2.Helper;

namespace Praktika2.Views
{
    public partial class menuStudent : Form
    {
        public string stud_name;

        public menuStudent()
        {
            InitializeComponent();
        }

        public string identify_student
        {

            set { stud_name = value; }

        }

        private void menuStudent_Load(object sender, EventArgs e)
        {

            fill_grade();

        }

        public void fill_grade()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT studentas.vardas, dalykas.pavadinimas, pazymys.pazymys FROM pazymys JOIN studento_pazymys USING (id_pazymys) JOIN dalykas USING (id_dalykas) JOIN studentas USING (id_studentas) where id_studentas=(select id_studentas from studentas where vardas ='"+stud_name+"');";

            cmd = DBconnection.Query(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            view_grade.DataSource = dt;

        }
    }
}

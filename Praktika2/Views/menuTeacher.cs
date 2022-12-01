using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika2.Helper;
using System.Xml.Linq;

namespace Praktika2.Views
{
    public partial class menuTeacher : Form
    {

        public string use_name;
        public string sub_name;

        public string identify_user
        {

            set { use_name = value; }

        }

        public menuTeacher()
        {
            InitializeComponent();
            

        }

       
        
        private void menuTeacher_Load(object sender, EventArgs e)
        {
            get_subName();
           

            Dest_vardas.Text = use_name;
            dest_dalyk.Text = sub_name;

            fill_student();

        }

        private void student_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void fill_student()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT vardas FROM duombaze.studentas where id_studentas in (SELECT id_studentas from studento_dalykas where id_dalykas=(SELECT id_dalykas FROM dalykas where pavadinimas = '"+sub_name+"'));";
            cmd = DBconnection.Query(query);

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string name = dr["vardas"].ToString();
                    student_list.Items.Add(name);

                }
            }



        }

        public void get_subName()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT pavadinimas from dalykas where id_destytojas=(SELECT id_destytojas from destytojas where vardas ='"+use_name+"')";
            cmd = DBconnection.Query(query);

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string g_name = dr["pavadinimas"].ToString();
                    sub_name = g_name;

                }
            }



        }

        public void create_mark()
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `duombaze`.`pazymys` (`id_dalykas`, `id_destytojas`, `pazymys`) VALUES ((SELECT id_dalykas from dalykas where pavadinimas='" + sub_name + "'), (SELECT id_destytojas From destytojas where vardas='" + use_name + "'), '"+text_pazymys.Text+"');";

            cmd = DBconnection.Query(query);

        }

        public void insert_mark_student()
        {
            MySqlCommand cmd = null;

            int index = student_list.SelectedIndex;

            string student = student_list.Items[index].ToString();

            string query = "INSERT INTO `duombaze`.`studento_pazymys` (`id_studentas`, `id_pazymys`) VALUES ((SELECT id_studentas from studentas where vardas='"+student+"'), (SELECT id_pazymys from pazymys where pazymys ='"+text_pazymys.Text+"'));";

            cmd = DBconnection.Query(query);

        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patvirtint_Click(object sender, EventArgs e)
        {
            create_mark();
            insert_mark_student();

            MessageBox.Show("Pavyko");
        }
    }
}

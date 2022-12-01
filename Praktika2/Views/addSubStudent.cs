using MySql.Data.MySqlClient;
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
using Org.BouncyCastle.Utilities.Collections;

namespace Praktika2.Views
{
    public partial class addSubStudent : Form
    {
        public addSubStudent()
        {
            InitializeComponent();
            data_fill();
            subject_fill();
        }

     

        public void data_fill()
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            select_student.Items.Clear();

            string query = "SELECT * FROM duombaze.studentas";
            cmd = DBconnection.Query(query);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string name = dr["vardas"].ToString();
                    select_student.Items.Add(name);

                }
            }

        }

        public void subject_fill()
        {

            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            select_subject.Items.Clear();

            string query = "SELECT * FROM duombaze.dalykas";
            cmd = DBconnection.Query(query);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string s_name = dr["pavadinimas"].ToString();
                    select_subject.Items.Add(s_name);

                }
            }



        }

        public void student_subject()
        {
            MySqlCommand cmd = null;

            int index = select_student.SelectedIndex;
            string student = select_student.Items[index].ToString();

            int sub_index = select_subject.SelectedIndex;
            string subject = select_subject.Items[sub_index].ToString();

            string query = "INSERT INTO `duombaze`.`studento_dalykas` (`id_studentas`,`id_dalykas`) VALUES((SELECT id_studentas FROM studentas WHERE vardas='"+student+"'), (SELECT id_dalykas FROM dalykas WHERE pavadinimas = '"+subject+"'));";
                
            cmd = DBconnection.Query(query);

        }

        private void select_student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patvirtint_Click(object sender, EventArgs e)
        {
            student_subject();

            MessageBox.Show("Pridėti pavyko");

        }
    }
}

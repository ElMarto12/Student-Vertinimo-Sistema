using Praktika2.DB;
using Praktika2.Users;
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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Icao;

namespace Praktika2.Views
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
            DBconnection.MakeConnection();
        }

        private void addStudent_Load(object sender, EventArgs e)
        {

            insert_listbox();

        }


        public void insert_listbox()
        {
           MySqlCommand cmd = null;
           DataTable dt;
           MySqlDataAdapter sda;

           select_grupe.Items.Clear();

           string query = "SELECT * FROM duombaze.grupe";
           cmd = DBconnection.Query(query);
           if (cmd != null)
           {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string g_name = dr["pavadinimas"].ToString();
                    select_grupe.Items.Add(g_name);

                }
           } 

        }
        private void patvirtint_Click(object sender, EventArgs e)
        {

            int index = select_grupe.SelectedIndex;

            string select = select_grupe.Items[index].ToString();
            string type = "Studentas";

            Student st = new Student(text_vardas.Text, text_pavarde.Text);

            st.user_create(st.St_Name, st.St_Lname, type);
            st.create(st.St_Name, st.St_Lname, select);

            MessageBox.Show("Sėkmingai Pridėtas Studentas Į Sistemą");
         
           
        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

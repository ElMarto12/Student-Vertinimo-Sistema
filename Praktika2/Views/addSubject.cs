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
using Praktika2.Users;

namespace Praktika2.Views
{
    public partial class addSubject : Form
    {
        public addSubject()
        {
            InitializeComponent();
            fill_list();
        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fill_list()
        {

            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            select_destytojas.Items.Clear();

            string query = "SELECT * FROM duombaze.destytojas";
            cmd = DBconnection.Query(query);

            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string name = dr["vardas"].ToString();
                    select_destytojas.Items.Add(name);


                }
            }


        }

        private void patvirtint_Click(object sender, EventArgs e)
        {

            int index = select_destytojas.SelectedIndex;

            string select = select_destytojas.Items[index].ToString();

            MessageBox.Show(select);

            Subject sub = new Subject(text_pavadinimas.Text);

            sub.create(sub.Sub_Name, select, null);

            MessageBox.Show("Dalykas Pridėtas");

        }


    }
}

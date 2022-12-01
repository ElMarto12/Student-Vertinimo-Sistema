using Praktika2.DB;
using Praktika2.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika2.Views;
using Praktika2.Users;

namespace Praktika2
{
    public partial class singin : Form
    {
        public singin()
        {
            InitializeComponent();
            DBconnection.MakeConnection();
        }

        public string ivestis_dest
        {
            get { return IvestVardas.Text; }
        }

        public string ivestis_stud
        {
            get { return IvestVardas.Text; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Iseiti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prisijungti_Click(object sender, EventArgs e)
        {
            string username = IvestVardas.Text;
            string password = slaptazodis.Text;

            User aUser = DBuser.RetriveUser(username);
            if (aUser.Password.Equals(password))
            {
                if (aUser.Type.Equals("Admin"))
                {
                    MessageBox.Show("Sekmingai prisijungta");
                    Views.menuAdmin men = new Views.menuAdmin();

                    men.Show();


                }
                else if (aUser.Type.Equals("Studentas"))
                {
                    MessageBox.Show("Sekmingai prisijungta");
                    Views.menuStudent stud = new Views.menuStudent();
                    stud.identify_student = ivestis_dest;
                    
                    stud.Show(); 

                }
                else if (aUser.Type.Equals("Destytojas"))
                {
                    MessageBox.Show("destytojas esat");
                    Views.menuTeacher tea = new Views.menuTeacher();
                    tea.identify_user = ivestis_dest;
                    tea.Show();

                }
            }
            else
            {

                MessageBox.Show("Nepavyko");
                IvestVardas.Text = "";
                slaptazodis.Text = "";
            }
        }

        private void IvestVardas_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void slaptazodis_TextChanged(object sender, EventArgs e)
        {
         
        }



    }
}

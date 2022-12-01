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

namespace Praktika2.Views
{
    public partial class addTeacher : Form
    {
        public addTeacher()
        {
            InitializeComponent();
        }
        private void patvirtint_Click(object sender, EventArgs e)
        {
            Teacher tea = new Teacher(text_vardas.Text, text_pavarde.Text);
            string tea_type = "Destytojas";

            tea.user_create(tea.Name, tea.Lname, tea_type);
            tea.create(tea.Name, tea.Lname, null);

            MessageBox.Show("Dėstytojas Pridėtas Į Sistemą");
        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}

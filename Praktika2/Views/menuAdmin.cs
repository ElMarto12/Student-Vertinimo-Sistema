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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_studentas_pridet_Click(object sender, EventArgs e)
        {

            Views.addStudent add = new Views.addStudent();

            add.Show();

        }

        private void btn_destytojas_pridet_Click(object sender, EventArgs e)
        {
            Views.addTeacher add = new Views.addTeacher();

            add.Show();
        }

        private void bnt_pridet_dalyka_Click(object sender, EventArgs e)
        {
            Views.addSubject add = new Views.addSubject();

            add.Show();
        }

        private void btn_pridet_grupe_Click(object sender, EventArgs e)
        {
            Views.addGroup add = new Views.addGroup();

            add.Show();
        }

        private void btn_priskirt_dalyka_Click(object sender, EventArgs e)
        {
            Views.addSubStudent add = new Views.addSubStudent();
            add.Show();
        }
    }
}

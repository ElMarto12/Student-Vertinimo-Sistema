using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika2.Users;

namespace Praktika2.Views
{
    public partial class addGroup : Form
    {
        public addGroup()
        {
            InitializeComponent();
        }

        private void atsaukt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patvirtint_Click(object sender, EventArgs e)
        {
            Group gr = new Group(text_pavadinimas.Text, text_fakultetas.Text);

            gr.create(gr.Name, gr.Faculty, null);

            MessageBox.Show("Grupė sėkmingai pridėta");

        }

        private void addGroup_Load(object sender, EventArgs e)
        {

        }
    }
}

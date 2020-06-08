using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TehniciAvansateDeProgramare
{
    public partial class Examen_3_1 : Form
    {
        public Examen_3_1()
        {
            InitializeComponent();
        }

        private void Examen_3_Load(object sender, EventArgs e)
        {
            this.imprumuturiTableAdapter.Fill(this.tAP_examen_3DataSet.Imprumuturi);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examen_3_2 form2 = new Examen_3_2();
            form2.Show();
        }

        private void Examen_3_1_Activated(object sender, EventArgs e)
        {
            tAP_examen_3DataSet.Clear();
            this.imprumuturiTableAdapter.Fill(this.tAP_examen_3DataSet.Imprumuturi);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
            Refresh();
        }
    }
}

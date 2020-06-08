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
    public partial class Examen_3_2 : Form
    {
        public Examen_3_2()
        {
            InitializeComponent();
        }

        private void Examen_3_2_Load(object sender, EventArgs e)
        {
            this.cartiTableAdapter.Fill(this.tAP_examen_3DataSet.Carti);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
            this.imprumuturiCartiStudentiTableAdapter.Fill(this.tAP_examen_3DataSet.ImprumuturiCartiStudenti);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdCarte = int.Parse(cartiTableAdapter.SelectIdCarte(comboCarte.Text).ToString());
            TAP_examen_3DataSetTableAdapters.StudentiTableAdapter studenti = new TAP_examen_3DataSetTableAdapters.StudentiTableAdapter();
            int IdStudent = int.Parse(studenti.SelectIdStudent(comboStudent.Text).ToString());
            DateTime data = DateTime.Parse(dateTimePicker1.Text);
            

            TAP_examen_3DataSetTableAdapters.ImprumuturiTableAdapter imprumuturi = new TAP_examen_3DataSetTableAdapters.ImprumuturiTableAdapter();
            imprumuturi.InsertImprumut(IdStudent, data, IdCarte);

            tAP_examen_3DataSet.Clear();
            this.cartiTableAdapter.Fill(this.tAP_examen_3DataSet.Carti);
            this.studentiTableAdapter.Fill(this.tAP_examen_3DataSet.Studenti);
            this.imprumuturiCartiStudentiTableAdapter.Fill(this.tAP_examen_3DataSet.ImprumuturiCartiStudenti);
            Refresh();
            
        }
    }
}

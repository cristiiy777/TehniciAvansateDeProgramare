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
    public partial class Examen_2_1 : Form
    {
        public Examen_2_1()
        {
            InitializeComponent();
        }

        private void Examen_2_Load(object sender, EventArgs e)
        {
            
            this.noteSiNumeElevTableAdapter.Fill(this.tAP_examen_2DataSet.NoteSiNumeElev);
            this.noteTableAdapter.Fill(this.tAP_examen_2DataSet.Note);
            this.eleviTableAdapter.Fill(this.tAP_examen_2DataSet.Elevi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Examen_2_2 form2 = new Examen_2_2();
            form2.Show();
            
        }

        public void refreshGrid()
        {
            //refresh
            tAP_examen_2DataSet.Clear();
            this.noteSiNumeElevTableAdapter.Fill(this.tAP_examen_2DataSet.NoteSiNumeElev);
            this.noteTableAdapter.Fill(this.tAP_examen_2DataSet.Note);
            this.eleviTableAdapter.Fill(this.tAP_examen_2DataSet.Elevi);
            noteTableAdapter.Update(tAP_examen_2DataSet.Note);
            Refresh();
        }

        private void Examen_2_1_Activated(object sender, EventArgs e)
        {
            refreshGrid();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TehniciAvansateDeProgramare
{
    public partial class Examen_2_2 : Form
    {

        public Examen_2_2()
        {
            InitializeComponent();
        }

        private void Examen_2_2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tAP_examen_2DataSet.Note' table. You can move, or remove it, as needed.
            this.noteTableAdapter.Fill(this.tAP_examen_2DataSet.Note);
            // TODO: This line of code loads data into the 'tAP_examen_2DataSet.Materii' table. You can move, or remove it, as needed.
            this.materiiTableAdapter.Fill(this.tAP_examen_2DataSet.Materii);
            // TODO: This line of code loads data into the 'tAP_examen_2DataSet.Elevi' table. You can move, or remove it, as needed.
            this.eleviTableAdapter.Fill(this.tAP_examen_2DataSet.Elevi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            int idElev = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());//iau coloana 0 (idElev)
            DateTime data = DateTime.Parse(dateTimePicker1.Text);
            int idMaterie = int.Parse(materiiTableAdapter.SelectIdMaterie(comboBox1.Text).ToString()); //iau id-u materiei cu numele materiei prin table adapter...
            int nota = 0;

            bool isNumeric = false;
            int n;
            isNumeric = int.TryParse(textBox1.Text, out n);
            if (isNumeric)
            {
                nota = int.Parse(textBox1.Text);
            }
            else 
            {
                MessageBox.Show("INTRODU DOAR NUMERE");
                return;
            }

            //verificare nota daca e numar si intre 1 si 10
            if (isNumeric == true & (nota % 1) == 0 & nota > 0 & nota <= 10)
            {
                noteTableAdapter.InsertNota(idElev, data, idMaterie, nota); //prin table adapter fac insertu
            }
            else
            {
                MessageBox.Show("Acceptam doar note intre 1 si 10.");
            }



            this.Close();
        }

    }
}

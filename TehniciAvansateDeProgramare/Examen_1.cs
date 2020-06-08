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
    public partial class Examen_1 : Form
    {
        public Examen_1()
        {
            InitializeComponent();
        }

        private void Examen_1_Load(object sender, EventArgs e)
        {
            this.consumTableAdapter.Fill(this.tAP_examen_1DataSet.Consum);
            this.materialTableAdapter.Fill(this.tAP_examen_1DataSet.Material);
            this.lucrariTableAdapter.Fill(this.tAP_examen_1DataSet.Lucrari);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lucrare = comboLucrare.Text;
            DateTime data = DateTime.Parse(dateTimePicker1.Text); 
            string material = comboMaterial.Text;
            int cantitate = int.Parse(textCantitate.Text);

            int idLucrare = lucrariTableAdapter.SelectIdLucrare(lucrare).Value;
            int IdMaterial = materialTableAdapter.SelectIdMaterial(material).Value;

            int pret = int.Parse(materialTableAdapter.SelectPretMaterial(material).ToString());
            int cost = pret * cantitate;

            consumTableAdapter.InsertQuery(idLucrare, data, IdMaterial, cantitate, cost);
            //

            //refresh
            tAP_examen_1DataSet.Clear();
            this.consumTableAdapter.Fill(this.tAP_examen_1DataSet.Consum);
            this.materialTableAdapter.Fill(this.tAP_examen_1DataSet.Material);
            this.lucrariTableAdapter.Fill(this.tAP_examen_1DataSet.Lucrari);

        }
    }
}

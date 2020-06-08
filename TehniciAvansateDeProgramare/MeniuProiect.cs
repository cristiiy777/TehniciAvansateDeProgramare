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
    public partial class MeniuProiect : Form
    {
        public MeniuProiect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examen_1 ex1 = new Examen_1();
            ex1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Examen_2_1 ex2 = new Examen_2_1();
            ex2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Examen_3_1 ex3 = new Examen_3_1();
            ex3.Show();
        }
    }
}

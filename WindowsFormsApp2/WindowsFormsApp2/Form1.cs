using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            if (Mol.Text != "0") do { Mol.Text = "0"; };
            if (Temp.Text != "0") do { Temp.Text = "0"; };
            if (Volume.Text != "0") do { Volume.Text = "0"; };
            if (Uitkomst.Text != "0") do { Uitkomst.Text = "0"; };
        }
            private void CalculateJoule()
        {
            if (Mol.Text == "") { Mol.Text = "0"; };
            if (Temp.Text == "") { Temp.Text = "0"; };
            if (Volume.Text == "") { Volume.Text = "0"; };
            if (Uitkomst.Text == "") { Uitkomst.Text = "0"; };

            double mol = Convert.ToDouble(Mol.Text);
            double temp = Convert.ToDouble(Temp.Text);
            double volume = Convert.ToDouble(Volume.Text);
            double gasconstante = Convert.ToDouble(Gasconstante.Text);
            double PascalB = Convert.ToDouble(Uitkomst.Text);
           

            int ingevuld = 0;
            if (mol > 0) { ingevuld += 1; };
            if (temp > 0) { ingevuld += 2; };
            if (volume > 0) { ingevuld += 4; };
            if (gasconstante > 0) { ingevuld += 8; };

            switch (ingevuld)
            {
                case 7:
                    gasconstante = (PascalB * volume) / (mol * temp);
                    Gasconstante.Text = gasconstante.ToString();
                    break;

                case 11:
                    volume = (mol * gasconstante * temp) / PascalB;
                    Volume.Text = volume.ToString();
                    break;

                case 13:
                    temp = (PascalB * volume) / (mol * gasconstante);
                    Temp.Text = temp.ToString();
                    break;

                case 14:
                    mol = (PascalB * volume) / (gasconstante * temp);
                    Mol.Text = mol.ToString();
                    break;

                case 15:
                    PascalB = (mol * gasconstante * temp) / volume;
                    Uitkomst.Text = PascalB.ToString();
                    break;
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        private void Temp_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void Mol_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void Volume_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void Gasconstante_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Uitkomst_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

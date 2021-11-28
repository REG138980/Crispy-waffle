using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public string[,] stof = new string[1000, 2];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "WindowsFormsApp1.Stoffen.csv";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result;
                int counter = 0;
                while ((result = reader.ReadLine()) != null)
                {
                    string[] splitter = result.Split(';');
                    stof[counter, 0] = splitter[0];
                    stof[counter,1]= splitter[1];
                    Stofnaam.Items.Add(stof[counter, 0]);
                    counter++;
                }
                
            }
        }

        private void CalculateJoule()
        {
            int gekozen = Stofnaam.SelectedIndex;
            if (gekozen == -1) { gekozen = 0; };
            SW_waarde.Text = stof[gekozen, 1];
            if (Massa.Text == "") { Massa.Text = "0"; };
            double gewicht = Convert.ToDouble(Massa.Text);
            if (Temp.Text == "") { Temp.Text = "0"; };
            double temp = Convert.ToDouble(Temp.Text);
            double sg = Convert.ToDouble(SW_waarde.Text);
            double joule = gewicht * temp * sg;
            Uitkomst.Text = joule.ToString();
        }

        private void Stofnaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void Massa_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }

        private void Temp_TextChanged(object sender, EventArgs e)
        {
            CalculateJoule();
        }
    }
}

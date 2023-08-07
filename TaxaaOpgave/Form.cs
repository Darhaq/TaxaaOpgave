using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxaaOpgave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startPris;
            double distancePris;
            double destinationPris;
            double prisPerMinut = 5.75;
            double passagertillæg = 5.75; // tillæg per passagere

            // Fastsæt priser baseret på taxitype og tidspunkt på dagen.
            if (storeVogne.Checked)
            {
                startPris = NatteTime.Checked ? 87.0 : 77.0;
                distancePris = NatteTime.Checked ? 19.0 : 17.0;
            }
            else
            {
                startPris = NatteTime.Checked ? 47.0 : 37.0;
                distancePris = NatteTime.Checked ? 16.0 : 12.75;
            }

            // Anvend tillægget pr. passager på startprisen
            // Test
            int AntalafPassagere = (int)numericUpDownPassagere.Value;
            startPris += (AntalafPassagere - 1) * passagertillæg;

            // Få afstanden i km og varigheden i minutter fra tekstfelterne
            var succes = double.TryParse(textBox4.Text, out double duration);
            var succesDistance = double.TryParse(textBox3.Text, out double distance);
            string destination = textBox2.Text;

            if (succesDistance && succes && !string.IsNullOrEmpty(destination))
            {
                double totalDistancePris = distance * distancePris;
                double totalTimePris = duration * prisPerMinut;
                double destinationPrisPerEnhed = 10.0;
                double totalDestinationPris = destination.Length * destinationPrisPerEnhed;


                // Beregn det samlede passagertillæg
                double totalPassageretillæg = (AntalafPassagere - 1) * passagertillæg;

                // Beregn den samlede pris ved at lægge alle komponenter sammen
                double totalPris = startPris + totalDistancePris + totalTimePris + totalDestinationPris + totalPassageretillæg; 

                // Opdater pris label
                ForventetPris.Text = "Forventet Pris: " + totalPris.ToString("C"); // Vis pris i lokal valuta
            }
            else
            {
                MessageBox.Show("Indtast venligst gyldig distance og varighed.", "Ugyldigt input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startPoint = textBox1.Text.Replace(" ", "+");
            string destination = textBox2.Text.Replace(" ", "+");

            string googleMapsUrl = $"https://www.google.com/maps/dir/{startPoint}/{destination}";
            System.Diagnostics.Process.Start(googleMapsUrl);
        }
    }
}

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
            double prisPerMinut = 1.0;
            double passagertillæg = 2.0; // tillæg per passagere

            // Fastsæt priser baseret på taxitype og tidspunkt på dagen.
            if (storeVogne.Checked)
            {
                startPris = NatteTime.Checked ? 9.0 : 8.0;
                distancePris = 3.0;
            }
            else
            {
                startPris = NatteTime.Checked ? 7.0 : 5.0;
                distancePris = NatteTime.Checked ? 2.0 : 1.0;
            }

            // Anvend tillægget pr. passager på startprisen
            int numberOfPassengers = (int)numericUpDownPassagere.Value;
            startPris += (numberOfPassengers - 1) * passagertillæg;

            // Få afstanden i km og varigheden i minutter fra tekstfelterne
            if (double.TryParse(Distance.Text, out double distance) && double.TryParse(Duration.Text, out double duration))
            {
                double totalDistancePrice = distance * distancePris;
                double totalTimePrice = duration * prisPerMinut;

                double totalPrice = startPris + totalDistancePrice + totalTimePrice;

                // Opdater pris lable
                ForventetPris.Text = "Expected Price: " + totalPrice.ToString("C"); // Vis pris i lokal valuta
            }
            else
            {
                MessageBox.Show("Please enter valid distance and duration.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string startPoint = StartPoint.Text.Replace(" ", "+");
            string destination = Destination.Text.Replace(" ", "+");

            string googleMapsUrl = $"https://www.google.com/maps/dir/{startPoint}/{destination}";
            System.Diagnostics.Process.Start(googleMapsUrl);
        }
    }
}

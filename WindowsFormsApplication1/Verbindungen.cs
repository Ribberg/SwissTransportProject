using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransport
{
    public partial class Verbindungen : UserControl
    {
        public ITransport transport = new Transport();
        public Verbindungen()
        {
            InitializeComponent();
        }

        private void Combosearch(ComboBox cb)
        {
            string cbtext = cb.Text;

            if (cbtext.Length >= 3)
           {
                Stations stations = new Stations();
                stations = transport.GetStations(cbtext + ",");
                cb.Items.Clear();
                foreach(Station s in stations.StationList)
                {
                    cb.Items.Add(s.Name);
                }
           }
      }

        public void Connection()
        {
            char separators = ':';
            var connections = transport.GetConnections(comboBox1.Text, comboBox2.Text);
            foreach (Connection c in connections.ConnectionList)
            {
                listBox1.Items.Add(" " + c.From.Station.Name + " X " + c.To.Station.Name + c.From.Departure);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            Combosearch(comboBox1);
        }

        private void comboBox2_TextUpdate_1(object sender, EventArgs e)
        {
            Combosearch(comboBox2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For support please contact 0763204535");
        }
    }
}
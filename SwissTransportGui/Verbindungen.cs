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
        Formatter formatter = new Formatter();
        public ITransport transport = new Transport();
        public Verbindungen()
        {
            InitializeComponent();
        }
        public string[] Splitter(string value, char[] sep)
        {
            string[] word = value.Split(sep);
            return word;
        }

        public void Connection()
        {
            string date = "&date=" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            string time = "&time=" + dateTimePicker1.Value.Hour + ":" + dateTimePicker1.Value.Minute;
            listBox1.Items.Clear();
            listBox1.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t" + "Abfahrt" + "\t" + "Ankunft" + "\t" + "Dauer");
            var connections = transport.GetConnections(DepartureBox.Text, ArrivalBox.Text,  date, time);
            foreach (Connection c in connections.ConnectionList)
        {

            string departure = formatter.Dateformatter(c.From.Departure);
            string arrival = formatter.Dateformatter(c.To.Arrival);
            char[] sepdur = { ':' };
            string[] duration = formatter.Splitter(c.Duration, sepdur);

            listBox1.Items.Add(" " + c.From.Station.Name + "\t\t" + c.To.Station.Name + "\t" + departure + "\t" + arrival + "\t" + duration[1] + " Min");
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void DepartureBox_TextUpdate_1(object sender, EventArgs e)
        {
            formatter.Combosearch(DepartureBox);
        }

        private void ArrivalBox_TextUpdate(object sender, EventArgs e)
        {
            formatter.Combosearch(ArrivalBox);
        }
    }
}
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
    public partial class Fahrplan : UserControl
    {
        StationBoardRoot station = new StationBoardRoot();
        Formatter formatter = new Formatter();
        public ITransport transport = new Transport();
        public Fahrplan()
        {
            InitializeComponent();
        }
        

        private void stationboard()
        {
            listBoxPlan1.Items.Clear();
            station = transport.GetStationBoard(comboBoxStation.Text, comboBoxStation.Text);

            foreach (StationBoard s in station.Entries)
            {
                char[] sep = { ' ' };
                string[] departure = formatter.Splitter(Convert.ToString(s.Stop.Departure.Date), sep);
                listBoxPlan1.Items.Add(" " + s.Name + "\t" + s.To + "\t" + s.Stop.Departure.ToShortTimeString());
            }
            
        }

        private void Fahrplan_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            stationboard();
        }
        public Button GetAcceptButton()
        {
            return btnsearch1;


        }

        private void comboBoxStation_TextUpdate_1(object sender, EventArgs e)
        {
            formatter.Combosearch(comboBoxStation);
        }
    }
}


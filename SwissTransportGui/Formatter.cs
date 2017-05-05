using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace SwissTransport
        {
        class Formatter
        {
        public ITransport transport = new Transport();
        public string[] Splitter(string value, char[] sep)
        {
            string[] word = value.Split(sep);
            return word;
        }
        public string Dateformatter(string date)
        {
            DateTime dtFrom = Convert.ToDateTime(date);
            string enddate = dtFrom.ToShortTimeString();
            return enddate;
        }
        public void Combosearch(ComboBox cb)
        {
            string cbtext = cb.Text;
            if (cbtext.Length >= 3)
        {
            Stations stations = new Stations();
            stations = transport.GetStations(cbtext + ",");
            cb.Items.Clear();
            cb.DroppedDown = true;
            cb.SelectionStart = cb.Text.Length;
            foreach (Station s in stations.StationList)
        {
            cb.Items.Add(s.Name);
        }
        }
        }
   }
}


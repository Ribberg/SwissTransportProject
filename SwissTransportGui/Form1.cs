using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SwissTransport
{
    public partial class Form1 : Form
    {
        Verbindungen verb = new Verbindungen();
        Fahrplan fahrplan = new Fahrplan();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxStation_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnverbindungen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(verb);
        }

        private void btnfahrplan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(fahrplan);
        }
    }
    }


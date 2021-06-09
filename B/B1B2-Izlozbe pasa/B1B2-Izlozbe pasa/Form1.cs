using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1B2_Izlozbe_pasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prijavaPasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrijavaPasa pp = new PrijavaPasa();
            pp.ShowDialog();
        }

        private void spisakPasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpisakPasa sp = new SpisakPasa();
            sp.ShowDialog();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosIzlozbe ui = new UnosIzlozbe();
            ui.ShowDialog();
        }

        private void spisakPasaPoRasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpisakPasaPoRasi sppr = new SpisakPasaPoRasi();
            sppr.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

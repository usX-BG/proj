using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B11_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervacije a = new Rezervacije();
            a.Show();
        }

        private void IzlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoTrupamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoTrupama a = new PoTrupama();
            a.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glumci g = new Glumci();
            g.ShowDialog();
        }

        private void producentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poZanrovimaIGlumcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zanrovi_i_glumci zig = new Zanrovi_i_glumci();
            zig.ShowDialog();
        }

        private void izlazAltIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

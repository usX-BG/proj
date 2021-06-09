using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЕИТ_Б3
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
            g.Show();
        }

        private void izlazAltIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void poZanrovimaIGlumcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zanr z = new Zanr();
            z.Show();
        }
    }
}

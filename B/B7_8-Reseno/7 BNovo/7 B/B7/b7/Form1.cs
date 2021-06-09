using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void destinacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destinacije de = new Destinacije();
            de.ShowDialog();
        }

        private void poAranzmanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aranzman de = new Aranzman();
            de.ShowDialog();
        }

        private void izlazAltIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

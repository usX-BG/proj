using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЕИТ_Б24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pacijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacijenti p = new Pacijenti();
            p.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statistikaPoliklinikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistika_Poliklinike s = new Statistika_Poliklinike();
            s.Show();
        }
    }
}

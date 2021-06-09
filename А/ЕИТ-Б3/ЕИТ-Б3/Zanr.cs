using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ЕИТ_Б3
{
    public partial class Zanr : Form
    {
        string cString = @"Data Source=DESKTOP-2LNDO9G;Initial Catalog=B3_4;Integrated Security=True";
        public Zanr()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection(cString);
            try
            {
                if (String.IsNullOrEmpty(tbPrezime.Text) || String.IsNullOrEmpty(tbIme.Text))
                {
                    throw new Exception("Niste popunili sva polja");
                }
                SqlCommand sel = new SqlCommand("select Naziv, ImeLika, Tip_Uloge.Tip from Film join Uloga on Film.FilmID = Uloga.FilmID join Tip_Uloge on Uloga.TipUlogeID = Tip_Uloge.TipUlogeID join Glumac on Uloga.GlumacID = Glumac.GlumacID join Zanr on Film.ZanrID = Zanr.ZanrID where Zanr.NazivZanra = @nazivzanra and Ime = @ime and Prezime = @prezime order by Trajanje DESC", con);
                sel.Parameters.AddWithValue("@nazivzanra", cbZanrovi.Items[cbZanrovi.SelectedIndex]);
                sel.Parameters.AddWithValue("@ime", tbIme.Text);
                sel.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                con.Open();
                SqlDataReader rd = sel.ExecuteReader();
                while (rd.Read())
                {
                    listBox1.Items.Add(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Zanr_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            SqlCommand sel = new SqlCommand("SELECT DISTINCT NazivZanra FROM Zanr Order by NazivZanra Asc;", con);
            con.Open();
            SqlDataReader rd = sel.ExecuteReader();
            while (rd.Read())
            {
                cbZanrovi.Items.Add(rd[0].ToString());
            }
            con.Close();
            cbZanrovi.SelectedIndex = 0;
        }
    }
}

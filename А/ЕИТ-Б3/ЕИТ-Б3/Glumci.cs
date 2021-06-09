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
    public partial class Glumci : Form
    {
        string cString = @"Data Source=DESKTOP-2LNDO9G;Initial Catalog=B3_4;Integrated Security=True";
        List<glumac> glumci = new List<glumac>();
        public Glumci()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Glumci_Load(object sender, EventArgs e)
        {
            GlumciInit();
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            int inx,test;
            if (!Int32.TryParse(tbSifra.Text, out test) && tbSifra.Text != "")
            {
                MessageBox.Show("Podaci nisu u ispravnoj formi(Sifra).");
            }
            else if (String.IsNullOrEmpty(tbSifra.Text) || String.IsNullOrWhiteSpace(tbSifra.Text)) {
                tbSifra.Clear();
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
            }
            else if ((inx = glumac.GetIndexId(glumci, Convert.ToInt32(tbSifra.Text))) != -1)
            {
                tbSifra.Text = glumci[inx].id.ToString();
                tbIme.Text = glumci[inx].Ime;
                tbPrezime.Text = glumci[inx].Prezime;
                tbDatum.Text = glumci[inx].datum;
                tbMesto.Text = glumci[inx].mesto;
            }
            else
            {
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
            }
        }

        private void lbGlumci_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inx = lbGlumci.SelectedIndex;
            tbSifra.Text = glumci[inx].id.ToString();
            tbIme.Text = glumci[inx].Ime;
            tbPrezime.Text = glumci[inx].Prezime;
            tbDatum.Text = glumci[inx].datum;
            tbMesto.Text = glumci[inx].mesto;
        }

        private void GlumciInit()
        {
            glumci.Clear();
            SqlConnection con = new SqlConnection(cString);
            SqlCommand sel = new SqlCommand("SELECT * FROM Glumac ORDER BY GlumacID ASC;", con);
            con.Open();
            SqlDataReader rd = sel.ExecuteReader();
            while (rd.Read())
            {
                lbGlumci.Items.Add(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\t" + Convert.ToDateTime(rd[3]).ToShortDateString() + "\t" + rd[4].ToString());
                glumci.Add(new glumac(Convert.ToInt32(rd[0].ToString()), rd[1].ToString(), rd[2].ToString(), Convert.ToDateTime(rd[3]).ToShortDateString(), rd[4].ToString()));
            }
            con.Close();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            try
            {
                int test;
                if (!Int32.TryParse(tbSifra.Text, out test))
                {
                    throw new Exception("Podaci nisu u ispravnoj formi(Sifra).");
                }
                if (String.IsNullOrEmpty(tbSifra.Text) || String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPrezime.Text) || String.IsNullOrEmpty(tbMesto.Text) || String.IsNullOrEmpty(tbDatum.Text))
                {
                    throw new Exception("Niste popunili sva polja.");
                }
                SqlCommand ins = new SqlCommand("INSERT INTO Glumac (GlumacID,Ime,Prezime,DatumRodjenja,MestoRodjenja) VALUES (@id,@ime,@prezime,@datum,@mesto);", con);
                string[] tmp = tbDatum.Text.Split('.');
                string insTmp = tmp[1] + "/" + tmp[0] + "/" + tmp[2];
                ins.Parameters.AddWithValue("@id", Convert.ToInt32(tbSifra.Text));
                ins.Parameters.AddWithValue("@ime", tbIme.Text);
                ins.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                ins.Parameters.AddWithValue("@datum", insTmp);
                ins.Parameters.AddWithValue("@mesto", tbMesto.Text);
                con.Open();
                ins.ExecuteNonQuery();
                lbGlumci.Items.Clear();
                GlumciInit();
                MessageBox.Show("Uspesno ste uneli glumca.");
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            try
            {
                int test,
                    idGlumca;
                if (!Int32.TryParse(tbSifra.Text, out test))
                {
                    throw new Exception("Podaci nisu u ispravnoj formi(Sifra).");
                }
                if (String.IsNullOrEmpty(tbSifra.Text))
                {
                    throw new Exception("Niste uneli sifru za brisanje.");
                }
                if ((idGlumca = glumac.GetIndexId(glumci, Convert.ToInt32(tbSifra.Text))) == -1)
                {
                    throw new Exception("Glumac ne postoji.");
                }
                SqlCommand del = new SqlCommand("DELETE FROM Glumac WHERE GlumacID=@id;", con);
                del.Parameters.AddWithValue("@id", glumci[idGlumca].id);
                con.Open();
                del.ExecuteNonQuery();
                lbGlumci.Items.Clear();
                GlumciInit();
                tbSifra.Clear();
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
                MessageBox.Show("Uspesno ste obrisali glumca.");
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

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            try
            {
                int test,
                    idGlumca;
                if (!Int32.TryParse(tbSifra.Text, out test))
                {
                    throw new Exception("Podaci nisu u ispravnoj formi(Sifra).");
                }
                if (String.IsNullOrEmpty(tbSifra.Text))
                {
                    throw new Exception("Niste uneli sifru za izmenu.");
                }
                if (String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPrezime.Text) || String.IsNullOrEmpty(tbMesto.Text) || String.IsNullOrEmpty(tbDatum.Text))
                {
                    throw new Exception("Niste uneli sve podatke.");
                }
                if ((idGlumca = glumac.GetIndexId(glumci, Convert.ToInt32(tbSifra.Text))) == -1)
                {
                    throw new Exception("Glumac ne postoji.");
                }
                SqlCommand upd = new SqlCommand("UPDATE Glumac SET Ime=@ime,Prezime=@prezime,DatumRodjenja=@datum,MestoRodjenja=@mesto WHERE GlumacID=@id;", con);
                string[] tmp = tbDatum.Text.Split('.');
                string insTmp = tmp[1] + "/" + tmp[0] + "/" + tmp[2];
                upd.Parameters.AddWithValue("@id",glumci[idGlumca].id);
                upd.Parameters.AddWithValue("@ime", tbIme.Text);
                upd.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                upd.Parameters.AddWithValue("@datum", insTmp);
                upd.Parameters.AddWithValue("@mesto", tbMesto.Text);
                con.Open();
                upd.ExecuteNonQuery();
                tbSifra.Clear();
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
                lbGlumci.Items.Clear();
                GlumciInit();
                MessageBox.Show("Uspesno ste izmenili glumca.");
                
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
    }
}

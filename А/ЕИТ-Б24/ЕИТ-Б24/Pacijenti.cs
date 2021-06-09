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

namespace ЕИТ_Б24
{
    public partial class Pacijenti : Form
    {
        List<Pacijent> pacijenti = new List<Pacijent>();
        string cString = @"Data Source=DESKTOP-2LNDO9G;Initial Catalog=B23_24nova;Integrated Security=True";
        public Pacijenti()
        {
            InitializeComponent();
        }

        private void Pacijenti_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            SqlCommand sel = new SqlCommand("SELECT DISTINCT Grad FROM Grad ORDER BY Grad ASC;", con);
            con.Open();
            SqlDataReader rd = sel.ExecuteReader();
            while (rd.Read())
            {
                cbGrad.Items.Add(rd[0].ToString());
            }
            con.Close();
            cbGrad.SelectedIndex = 0;
            PacijentiInit();
        }

        private void PacijentiInit()
        {
            pacijenti.Clear();
            SqlConnection con = new SqlConnection(cString);
            SqlCommand sel = new SqlCommand("SELECT Pacijent.PacijentID,Pacijent.Ime,Pacijent.Prezime,Pacijent.Adresa,Grad.Grad,Pacijent.BrojTelefona FROM Pacijent join Grad on Pacijent.GradID=Grad.GradID;", con);
            con.Open();
            SqlDataReader rd = sel.ExecuteReader();
            while (rd.Read())
            {
                pacijenti.Add(new Pacijent(Convert.ToInt32(rd[0].ToString()), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString()));
            }
            con.Close();
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!Int32.TryParse(tbSifra.Text, out id) && tbSifra.Text != "")
                {
                    throw new Exception("Samo brojevi za sifru.");
                }
                else
                {
                    int inx;
                    if ((inx = Pacijent.ret_InxFromId(pacijenti, id)) != -1)
                    {
                        tbIme.Text = pacijenti[inx].ime;
                        tbPrezime.Text = pacijenti[inx].prezime;
                        tbAdresa.Text = pacijenti[inx].adresa;
                        tbTelefon.Text = pacijenti[inx].telefon;
                        cbGrad.SelectedIndex = pacijenti[inx].ret_grad_inx(cbGrad);
                    }
                    else
                    {
                        formInit(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formInit(bool sifra = true)
        {
            if (sifra)
            {
                tbSifra.Clear();
            }
            tbIme.Clear();
            tbPrezime.Clear();
            tbAdresa.Clear();
            tbTelefon.Clear();
            cbGrad.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            try
            {
                int id;
                if (!Int32.TryParse(tbSifra.Text, out id) && tbSifra.Text != "")
                {
                    throw new Exception("Samo brojevi za sifru.");
                }
                else if (tbSifra.Text == "" || tbIme.Text == "" || tbPrezime.Text == "" || tbAdresa.Text == "" || cbGrad.SelectedIndex == -1 || tbTelefon.Text == "")
                {
                    throw new Exception("Niste popunili sva polja");
                }
                else
                {
                    if (Pacijent.ret_InxFromId(pacijenti, id) == -1)
                    {
                        SqlCommand ins = new SqlCommand("INSERT INTO Pacijent(PacijentID,Ime,Prezime,Adresa,GradID,BrojTelefona) VALUES(@sifra,@ime,@prezime,@adresa,@gradid,@tel);", con);
                        ins.Parameters.AddWithValue("@sifra", Convert.ToInt32(tbSifra.Text));
                        ins.Parameters.AddWithValue("@ime", tbIme.Text);
                        ins.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                        ins.Parameters.AddWithValue("@adresa", tbAdresa.Text);
                        ins.Parameters.AddWithValue("@gradid", Pacijent.ret_gradId(cbGrad.Items[cbGrad.SelectedIndex].ToString()));
                        ins.Parameters.AddWithValue("@tel", tbTelefon.Text);
                        con.Open();
                        ins.ExecuteNonQuery();
                        formInit();
                        PacijentiInit();
                        MessageBox.Show("Uspesno ste uneli pacijenta.");
                    }
                    else
                    {
                        throw new Exception("Pacijent vec postoji.");
                    }
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cString);
            try
            {
                int id;
                if (!Int32.TryParse(tbSifra.Text, out id) && tbSifra.Text != "")
                {
                    throw new Exception("Samo brojevi za sifru.");
                }
                else
                {
                    if (Pacijent.ret_InxFromId(pacijenti, id) != -1)
                    {
                        SqlCommand del = new SqlCommand("DELETE FROM Pacijent WHERE PacijentID=@id;", con);
                        del.Parameters.AddWithValue("@id", id);
                        con.Open();
                        del.ExecuteNonQuery();
                        formInit();
                        PacijentiInit();
                        MessageBox.Show("Uspesno ste izbrisali pacijenta.");
                    }
                    else
                    {
                        throw new Exception("Pacijent ne postoji.");
                    }
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

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(cString);
             try
             {
                 int id;
                 if (!Int32.TryParse(tbSifra.Text, out id) && tbSifra.Text != "")
                 {
                     throw new Exception("Samo brojevi za sifru.");
                 }
                 else if (tbSifra.Text == "" || tbIme.Text == "" || tbPrezime.Text == "" || tbAdresa.Text == "" || cbGrad.SelectedIndex == -1 || tbTelefon.Text == "")
                 {
                     throw new Exception("Niste popunili sva polja");
                 }
                 else
                 {
                     if (Pacijent.ret_InxFromId(pacijenti, id) != -1)
                     {

                     }
                     else
                     {
                         throw new Exception("Pacijent ne postoji.");
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {

             }
        }
    }
}

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

namespace B3
{
    public partial class Glumci : Form
    {
        SqlConnection conn = new SqlConnection();
        

        public Glumci()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=DESKTOP-6IPBQBM;Initial Catalog=B3_4;Integrated Security=True";
            Ucitavanje();                
        }
        //UCITAVANJE U LISTBOX----------------------------------------------------------------------------------
        void Ucitavanje()
        {           
            try
            {
                SqlDataReader rd;
                SqlCommand select = new SqlCommand("select * from Glumac order by GlumacID ASC ", conn);
                conn.Open();
                lbGlumci.Items.Clear();
                rd = select.ExecuteReader();
                
                while (rd.Read())
                {
                    
                    lbGlumci.Items.Add(rd[0].ToString() + "\t" + rd[1].ToString() + "\t" + rd[2].ToString() + "\t" + Convert.ToDateTime(rd[3]).ToShortDateString() + "\t" + rd[4]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Desila se greska:"+e.Message);
            }
            finally
            {
                conn.Close();     
            }
        }

        //UNOSENJE U DATABASE--------------------------------------------------------------------------------------

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand insert = new SqlCommand("insert into Glumac values(@sifra,@ime,@prezime,@datum,@mesto)", conn);
                conn.Open();

                string[] datum = tbDatum.Text.Split('/');
                string tmp = datum[1] + "/" + datum[0] + "/" + datum[2];

                insert.Parameters.AddWithValue("@sifra", Convert.ToInt32(tbSifra.Text));
                insert.Parameters.AddWithValue("@ime", tbIme.Text);
                insert.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                insert.Parameters.AddWithValue("@datum", tmp);
                insert.Parameters.AddWithValue("@mesto", tbMesto.Text);

                insert.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste uneli podatke!!!");
                conn.Close();
                Ucitavanje();     
              }              
                catch (SqlException e3)
                {
                    if (e3.Message.Contains("Violation of PRIMARY KEY"))
                    {
                        MessageBox.Show("Glumac sa takvom sifrom vec postoji!!!");
                    }
                }
                catch(FormatException e5)
                {
                    MessageBox.Show("Uneli ste pogresan format!!!");
                }
                finally
                {
                    conn.Close();
                    tbSifra.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbDatum.Clear();
                    tbMesto.Clear();               
                }
        }

        //BRISANJE IZ DATABASE------------------------------------------------------------------------------------------

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand delete = new SqlCommand("delete from Glumac where GlumacID=@sifra",conn);
                delete.Parameters.AddWithValue("@sifra",Convert.ToInt32(tbSifra.Text));

                conn.Open();
                if(delete.ExecuteNonQuery()!=0)
                {
                delete.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste obrisali glumca!"); 
                }
                else
                    MessageBox.Show("Takva sifra ne postoji"); 
            }
            catch(Exception e2)
            {
                MessageBox.Show("Desila se greska:\n"+e2.Message);
            }
            finally
            {
                conn.Close();
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
                Ucitavanje();
            }
        }

        //IZMENA PARAMETARA---------------------------------------------------------------------

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datum = tbDatum.Text.Split('/');
                string tmp = datum[1] + "/" + datum[0] + "/" + datum[2];

                SqlCommand update = new SqlCommand("update Glumac set Ime=@ime, Prezime=@prezime, DatumRodjenja=@datum, MestoRodjenja=@mesto where GlumacID=@sifra", conn);
                update.Parameters.AddWithValue("@sifra", Convert.ToInt32(tbSifra.Text));
                update.Parameters.AddWithValue("@ime", tbIme.Text);
                update.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                update.Parameters.AddWithValue("@datum", tmp);
                update.Parameters.AddWithValue("@mesto", tbMesto.Text);   
           
                conn.Open();
                update.ExecuteNonQuery();
                if (update.ExecuteNonQuery() != 0)

                    MessageBox.Show("Uspesno ste izmenili glumca!!");
                else 
                    MessageBox.Show("Ta sifra ne postoji!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Uneli ste pogresan format!!!");
            }
            catch (Exception e3)
            {
                MessageBox.Show("Desila se greska:\n " + e3.Message);
            }
            finally
            {
                conn.Close();
                tbIme.Clear();
                tbPrezime.Clear();
                tbDatum.Clear();
                tbMesto.Clear();
                Ucitavanje();
            }
        }
        
        //UCITAVANJE UKOLIKO JE ISTA SIFRA---------------------------------------------------------------

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbSifra.Text))
                {
                    tbSifra.Clear();
                    tbIme.Clear();
                    tbPrezime.Clear();
                    tbDatum.Clear();
                    tbMesto.Clear();
                }
                else
                {
                    SqlCommand select = new SqlCommand("select * from Glumac where GlumacID=@p1", conn);
                    select.Parameters.AddWithValue("@p1", Convert.ToInt32(tbSifra.Text));
                    SqlDataReader rd;
                    conn.Open();
                    rd = select.ExecuteReader();
                    bool b = false;
                    while (rd.Read())
                    { 
                        tbSifra.Text = rd[0].ToString();
                        tbIme.Text = rd[1].ToString();
                        tbPrezime.Text = rd[2].ToString();
                        tbDatum.Text = Convert.ToDateTime(rd[3]).ToShortDateString();
                        tbMesto.Text = rd[4].ToString();
                        b = true;
                    }
                    if(!b)
                    { 
                            tbIme.Clear();
                            tbPrezime.Clear();
                            tbDatum.Clear();
                            tbMesto.Clear();
                    }
                }
            }
            catch (Exception e4)
            {
                MessageBox.Show("Desila se greska:\n " + e4.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //IZLAZAK IZ PROGRAMA---------------------------------------------------------------

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //NEKE GLUPOSTI---------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void tbSifra_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void tbDatum_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}

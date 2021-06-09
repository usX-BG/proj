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
using System.IO;

namespace b7
{
    public partial class Destinacije : Form
    {
        SqlConnection con = new SqlConnection();
        

        public Destinacije()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSifra.Text = "";
            tbNaziv.Text = "";
            tbDrzava.Text = "";
            tbCVize.Text = "";
            tbSifra.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSifra.Text == "" || tbNaziv.Text == "" || tbDrzava.Text == "" || tbCVize.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja!!!");

                }
                else
                {
                    con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
                    SqlCommand naredba = new SqlCommand("Insert into Turisticka_destinacija values (@p1,@p2,@p3,@p4)", con);
                    naredba.Parameters.AddWithValue("@p1", Convert.ToInt32(tbSifra.Text));
                    naredba.Parameters.AddWithValue("@p2", tbNaziv.Text);
                    naredba.Parameters.AddWithValue("@p3", tbDrzava.Text);
                    naredba.Parameters.AddWithValue("@p4", Convert.ToDecimal(tbCVize.Text));
                    con.Open();
                    naredba.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste uneli destinaciju!!!");
                    con.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaci nisu u odgovarajucem formatu");
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Destinacija pod ovom sifrom vec postoji");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                tbSifra.Text = "";
                tbNaziv.Text = "";
                tbDrzava.Text = "";
                tbCVize.Text = "";
                tbSifra.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              if (tbSifra.Text == "")
            {
                con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
                con.Open();
                SqlCommand naredba = new SqlCommand("Select DestinacijaID, NazivMesta, Drzava, CenaVize from Turisticka_destinacija where DestinacijaID = (Select MIN(DestinacijaID) from Turisticka_destinacija)", con);
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    tbSifra.Text = rd.GetValue(0).ToString();
                    tbNaziv.Text = rd.GetValue(1).ToString();
                    tbDrzava.Text = rd.GetValue(2).ToString();
                    tbCVize.Text = rd.GetValue(3).ToString();
                }
                con.Close();
            }
            else if (tbSifra.Text != "")
            {
                con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
                con.Open();
                SqlCommand naredba = new SqlCommand("Select DestinacijaID, NazivMesta, Drzava, CenaVize from Turisticka_destinacija where DestinacijaID=@p1", con);
                naredba.Parameters.AddWithValue("@p1", Convert.ToInt32(tbSifra.Text) - 1);
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    tbSifra.Text = rd.GetValue(0).ToString();
                    tbNaziv.Text = rd.GetValue(1).ToString();
                    tbDrzava.Text = rd.GetValue(2).ToString();
                    tbCVize.Text = rd.GetValue(3).ToString();
                }
                con.Close();  
               
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbSifra.Text != "")
            {
                con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
                con.Open();
                SqlCommand naredba = new SqlCommand("Select DestinacijaID, NazivMesta, Drzava, CenaVize from Turisticka_destinacija where DestinacijaID=@p1", con);
                naredba.Parameters.AddWithValue("@p1", Convert.ToInt32(tbSifra.Text) + 1);
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    tbSifra.Text = rd.GetValue(0).ToString();
                    tbNaziv.Text = rd.GetValue(1).ToString();
                    tbDrzava.Text = rd.GetValue(2).ToString();
                    tbCVize.Text = rd.GetValue(3).ToString();
                }
                con.Close();
            }
            if (tbSifra.Text == "")
            {
                con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
                con.Open();
                SqlCommand naredba = new SqlCommand("Select DestinacijaID, NazivMesta, Drzava, CenaVize from Turisticka_destinacija where DestinacijaID = (Select MAX(DestinacijaID) from Turisticka_destinacija)", con);
                
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    tbSifra.Text = rd.GetValue(0).ToString();
                    tbNaziv.Text = rd.GetValue(1).ToString();
                    tbDrzava.Text = rd.GetValue(2).ToString();
                    tbCVize.Text = rd.GetValue(3).ToString();
                }
                con.Close();
            }
        }

        private void Destinacije_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
            con.Open();
            SqlCommand naredba = new SqlCommand("Select DestinacijaID, NazivMesta, Drzava, CenaVize from Turisticka_destinacija where DestinacijaID = (Select MIN(DestinacijaID) from Turisticka_destinacija)", con);
            SqlDataReader rd = naredba.ExecuteReader();
            while (rd.Read())
            {
                tbSifra.Text = rd.GetValue(0).ToString();
                tbNaziv.Text = rd.GetValue(1).ToString();
                tbDrzava.Text = rd.GetValue(2).ToString();
                tbCVize.Text = rd.GetValue(3).ToString();
            }
            con.Close();
        }
    }
}

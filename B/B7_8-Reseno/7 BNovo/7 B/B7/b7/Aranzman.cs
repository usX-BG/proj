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
    public partial class Aranzman : Form
    {
        SqlConnection con = new SqlConnection();

        public Aranzman()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-2IBRKPH;Initial Catalog=B7_8;Integrated Security=True";
            Drzava();
            Kategorija();
        }

        public void Drzava()
        {
            try
            {

                SqlCommand naredba = new SqlCommand("Select distinct Drzava from Turisticka_destinacija ORDER BY Drzava ASC", con);
                con.Open();
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    cbDrzava.Items.Add(rd[0].ToString());
                }
                con.Close();

                cbDrzava.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        public void Kategorija()
        {
            try
            {
                SqlCommand naredba = new SqlCommand("Select distinct Kategorija from Hotel", con);
                con.Open();
                SqlDataReader rd = naredba.ExecuteReader();
                while (rd.Read())
                {
                    cbKategorija.Items.Add(rd[0].ToString());
                }
                con.Close();
                cbKategorija.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Aranzman_Load(object sender, EventArgs e)
        {

        }

        private void bttIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttPretrazi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand naredba = new SqlCommand(@"select distinct Hotel.Naziv, count(Turisticki_Aranzman.AranzmanID) as Broj_aranzmana from Hotel inner join Turisticki_Aranzman on Hotel.HotelID=Turisticki_Aranzman.HotelID 
                                                    where DatumPolaska=@p3 and DatumPovratka=@p4 and Kategorija=@p1 
                                                    and Drzava=@p2 group by Hotel.Naziv, Hotel.Drzava, Turisticki_Aranzman.AranzmanID", con);
                naredba.Parameters.AddWithValue("@p1", cbKategorija.Text);
                naredba.Parameters.AddWithValue("@p2", cbDrzava.Text);
                naredba.Parameters.AddWithValue("@p3", monthCalendar1.SelectionStart);
                naredba.Parameters.AddWithValue("@p4", monthCalendar2.SelectionStart);
                DataSet ds = new DataSet();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(naredba);

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }
    }
}

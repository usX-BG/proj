using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ЕИТ_Б24
{
    class Pacijent
    {
        public int sifra;
        public string ime, prezime, adresa, grad, telefon;
        public Pacijent(int s, string i, string p, string a, string g, string t)
        {
            sifra = s;
            ime = i;
            prezime = p;
            adresa = a;
            grad = g;
            telefon = t;
        }

        public static int ret_InxFromId(List<Pacijent> pacijenti, int sifra)
        {
            for (int i = 0; i < pacijenti.Count; i++)
            {
                if (pacijenti[i].sifra == sifra)
                {
                    return i;
                }
            }
            return -1;
        }

        public int ret_grad_inx(ComboBox gradovi)
        {
            for (int i = 0; i < gradovi.Items.Count; i++)
            {
                if (gradovi.Items[i].ToString() == grad)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int ret_gradId(string grad)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LNDO9G;Initial Catalog=B23_24nova;Integrated Security=True");
            SqlCommand sel = new SqlCommand("SELECT GradID FROM Grad WHERE Grad=@g;", con);
            sel.Parameters.AddWithValue("@g", grad);
            con.Open();
            SqlDataReader rd = sel.ExecuteReader();
            rd.Read();
            return Convert.ToInt32(rd[0].ToString());
        }
    }
}

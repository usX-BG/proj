using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ЕИТ_А8
{
    public partial class Veb_Prodavnica : System.Web.UI.Page
    {

        List<Artikal> artikli = new List<Artikal>();

        protected void Page_Load(object sender, EventArgs e)
        {
            tabela.InnerHtml = "";
            string[] f_red = File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А8\ЕИТ-А8\vebprodavnica.txt");
            for (int i = 0; i < f_red.Length; i++)
            {
                string sifra, naziv, proizvodjac, ram, procesor, kamera, ekran, putanja, tmpCena;
                sifra = addValue(f_red[i], 0, 6);
                naziv = addValue(f_red[i], 6, 31);
                proizvodjac = addValue(f_red[i], 31, 51);
                ram = addValue(f_red[i], 51, 56);
                procesor = addValue(f_red[i], 56, 71);
                kamera = addValue(f_red[i], 71, 81);
                ekran = addValue(f_red[i], 81, 86);
                putanja = addValue(f_red[i],91, 121);
                tmpCena = addValue(f_red[i], 121, 131);
                if(!isAdded(ddlProizvodjac,proizvodjac)){
                    ddlProizvodjac.Items.Add(proizvodjac);
                }
                if (!isAdded(ddlRAM, ram)){
                    ddlRAM.Items.Add(ram);
                }
                if (!isAdded(ddlProcesor, procesor)){
                    ddlProcesor.Items.Add(procesor);
                }
                if (!isAdded(ddlKamera, kamera)){
                    ddlKamera.Items.Add(kamera);
                }
                if (!isAdded(ddlEkran, ekran)){
                    ddlEkran.Items.Add(ekran);
                }
                artikli.Add(new Artikal(sifra, naziv, proizvodjac, ram, procesor, kamera, ekran, putanja, Convert.ToInt32(tmpCena)));
            }
        }

        private string addValue(string s,int start,int end)
        {
            string tmp = "";
            for (int i = start; i < end; i++)
            {
                tmp += s[i].ToString();
            }
            tmp = tmp.TrimStart(' ');
            tmp = tmp.TrimEnd(' ');
            return tmp;
        }

        private bool isAdded(DropDownList ddl, string s)
        {
            bool p = false;
            for (int i = 0; i < ddl.Items.Count; i++)
            {
                if (ddl.Items[i].ToString() == s)
                {
                    p = true;
                    break;
                }
            }
            return p;
        }

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            tabela.InnerHtml = "<table><tr><td>Sifra</td><td>Naziv</td><td>Proizvodjac</td><td>RAM memorija</td><td>Procesor</td><td>Kamera</td><td>Ekran</td><td>Cena</td><td>Slika</td></tr>";
            for (int i = 0; i < artikli.Count; i++)
            {
                if (ddlProizvodjac.Items[ddlProizvodjac.SelectedIndex].ToString() == artikli[i].proizvodjac &&
                    ddlRAM.Items[ddlRAM.SelectedIndex].ToString() == artikli[i].ram &&
                    ddlProcesor.Items[ddlProcesor.SelectedIndex].ToString() == artikli[i].procesor &&
                    ddlKamera.Items[ddlKamera.SelectedIndex].ToString() == artikli[i].kamera && 
                    ddlEkran.Items[ddlEkran.SelectedIndex].ToString() == artikli[i].ekran)
                {
                    tabela.InnerHtml += "<tr><td>" + artikli[i].sifra + "</td><td>" + artikli[i].naziv + "</td><td>" + artikli[i].proizvodjac + "</td><td>" + artikli[i].ram + "</td><td>" + artikli[i].procesor + "</td><td>" + artikli[i].kamera + "</td><td>" + artikli[i].ekran + "</td><td>" + artikli[i].cena.ToString() + "</td><td><img src="+artikli[i].putanja+"/></td></tr>";
                }
            }
            tabela.InnerHtml += "</table>";
        }

    }
}
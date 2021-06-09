using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;

namespace ЕИТ_А14
{
    public partial class Program : System.Web.UI.Page
    {
        private string[] program_files = Directory.GetFiles(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А14\ЕИТ-А14\program_lista\");
        private List<string> lista_datuma = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < program_files.Length; i++)
                {
                    string tmp = Path.GetFileName(program_files[i]).ToString();
                    tmp = tmp.Remove(11);
                    lista_datuma.Add(tmp);
                    ddlDatum.Items.Add(lista_datuma[i].ToString());
                }
                List<string> tipovi = Ucitaj_tipove(0);
                for (int i = 0; i < tipovi.Count; i++)
                {
                    ddlTip.Items.Add(tipovi[i].ToString());
                }
            }
        }

        private List<string> Ucitaj_tipove(int indDatum)
        {
            List<string> tipovi = new List<string>();
            string[] red = File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А14\ЕИТ-А14\program_lista\" + lista_datuma[indDatum] + "txt");
            for (int i = 0; i < red.Length; i++)
            {
                string[] tmp = red[i].Split('|');
                if (i == 0) { tipovi.Add(tmp[2]); }
                bool flag = false;
                for (int j = 0; j < tipovi.Count; j++)
                {
                    if (tipovi[j] == tmp[2])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag != true) { tipovi.Add(tmp[2]); }
            }
            return tipovi;
        }

        protected void ddlDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
                ddlTip.Items.Clear();
            for (int i = 0; i < program_files.Length; i++)
            {
                string tmp = Path.GetFileName(program_files[i]).ToString();
                tmp = tmp.Remove(11);
                lista_datuma.Add(tmp);
            }
            List<string> tipovi = Ucitaj_tipove(ddlDatum.SelectedIndex);
            for (int i = 0; i < tipovi.Count; i++)
            {
                ddlTip.Items.Add(tipovi[i]);
            }
        }

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlDatum.SelectedIndex < 0 || ddlTip.SelectedIndex < 0)
                {
                    throw new Exception("Niste oznacili dobra polja.");
                }
                for (int i = 0; i < program_files.Length; i++)
                {
                    string tmp = Path.GetFileName(program_files[i]).ToString();
                    tmp = tmp.Remove(11);
                    lista_datuma.Add(tmp);
                }
                string[] red = File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А14\ЕИТ-А14\program_lista\" + lista_datuma[ddlDatum.SelectedIndex] + "txt");
                container.InnerHtml = "<table><tr><th>Vreme</th><th>Naziv programa</th><th>Tip programa</th></tr>";
                for (int i = 0; i < red.Length; i++)
                {
                    string[] tmp = red[i].Split('|');
                    if (ddlTip.SelectedValue.ToString() == tmp[2])
                    {
                        string src = "";
                        switch (ddlTip.SelectedValue.ToString())
                        {
                            case "Филм":
                                src = "film.jpg";
                                break;
                            case "Информативни програм":
                                src = "informativni.jpg";
                                break;
                            case "Серија":
                                src = "serija.jpg";
                                break;
                        }
                        container.InnerHtml += "<tr><th>" + tmp[0] + "</th><th>" + tmp[1] + "</th><th>" + tmp[2] + "<img src=\"img/" + src +"\"></th></tr>";
                    }
                }
                container.InnerHtml += "</table>";

            }
            catch (Exception ex)
            {
                container.InnerHtml = "<p class=\"greska\">" + ex.Message + "</p>";
            }
        }
    }
}
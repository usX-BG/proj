using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace XML_Web_Servis
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double ProcitajKursNaDan(DateTime datum, string valuta)
        {
            string[] red = File.ReadAllLines(Kurs.putanja);
            List<Kurs> lista = new List<Kurs>();
            for (int i = 0; i < red.Length; i++)
            {
                string[] tmp = red[i].Split('|');
                tmp[0] = tmp[0].Remove(10);
                tmp[1] = tmp[1].Remove(0,1);
                tmp[1] = tmp[1].Remove(tmp[1].Length - 1);
                lista.Add(new Kurs(tmp[0], tmp[1], Convert.ToDouble(tmp[2])));
            }
            for (int i = 0; i < lista.Count; i++)
            {
                string s = datum.ToString("MM/dd/yyyy");
                if ((lista[i].Datum == s) && (lista[i].Oznaka == valuta))
                {
                    return lista[i].Sr_kurs;
                }
            }
            return 0.0;
        }
        [WebMethod]
        public bool UpisiKursNaDan(DateTime datum, string valuta, double kurs)
        {
            string dat = datum.ToString("MM.dd.yyyy");
            File.AppendAllText(Kurs.putanja, dat + " | " + valuta + " | " + kurs.ToString() + Environment.NewLine);
            return true;
        }
        [WebMethod]
        public List<string> ProcitajSveValute()
        {
            string[] red = File.ReadAllLines(Kurs.putanja);
            List<string> valute = new List<string>();
            for (int i = 0; i < red.Length; i++)
            {
                string[] temp = red[i].Split('|');
                string val = temp[1];
                val = val.Remove(0,1);
                val = val.Remove(val.Length-1);
                bool f = false;
                for (int j = 0; j < valute.Count; j++)
                {
                    if (val == valute[j])
                    {
                        f = true;
                        break;
                    }
                }
                if (!f)
                {
                    valute.Add(val);
                }
            }
            return valute;
        }
    }
}
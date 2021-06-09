using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

namespace ЕИТ_25
{
    public partial class Pregled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<Biblioteka> knjige = new List<Biblioteka>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-25\ЕИТ-25\biblioteka.xml");
                XmlNodeList list = doc.GetElementsByTagName("knjiga");
                for (int i = 0; i < list.Count; i++)
                {
                    string isbn = list[i].Attributes["ISBN"].Value;
                    string naslov = list[i].Attributes["naslov"].Value;
                    int stanje = Convert.ToInt32(list[i].Attributes["stanje"].Value);
                    int citano = Convert.ToInt32(list[i].Attributes["citano"].Value);
                    knjige.Add(new Biblioteka(isbn, naslov, stanje, citano));
                }
                knjige = Biblioteka.sort(knjige);
                tabela.InnerHtml = "<table><tr><th>ISBN</th><th>Naslov</th><th>Stanje</th><th>Citano</th></tr>";
                for (int i = 0; i < knjige.Count; i++)
                {
                    tabela.InnerHtml += "<tr><td>" + knjige[i].Isbn +"</td><td>" + knjige[i].Naslov + "</td><td>" + knjige[i].Stanje.ToString() + "</td><td>" + knjige[i].Citano.ToString() +"</td></tr>";
                }
                tabela.InnerHtml += "</table>";
            }
        }
    }
}
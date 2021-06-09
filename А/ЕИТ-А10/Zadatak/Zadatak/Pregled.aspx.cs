using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zadatak.localhost;

[assembly: WebResource("SlimeeLibrary.Images.DatePicker.gif", "image/gif")]
[assembly: WebResource("SlimeeLibrary.Javascript.DatePicker.js", "text/javascript")]
[assembly: WebResource("SlimeeLibrary.Javascript.DateTime.js", "text/javascript")]

namespace Zadatak
{
    public partial class Pregled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Service1 s = new Service1();
                string[] valute = s.ProcitajSveValute();
                for (int i = 0; i < valute.Length; i++)
                {
                    DropDownList1.Items.Add(valute[i].ToString());
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            if (s.ProcitajKursNaDan(Calendar1.SelectedDate, DropDownList1.SelectedItem.Value.ToString()) != 0)
            {
                container.InnerText = s.ProcitajKursNaDan(Calendar1.SelectedDate, DropDownList1.SelectedItem.Value.ToString()).ToString();
            }
            else
            {
                container.InnerText = "Nije unet kurs za oznaceni dan";
            }
        }
    }
}
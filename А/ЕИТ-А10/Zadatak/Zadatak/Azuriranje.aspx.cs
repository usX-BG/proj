using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zadatak.localhost;

namespace Zadatak
{
    public partial class Azuriranje : System.Web.UI.Page
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
            if (s.UpisiKursNaDan(Calendar1.SelectedDate, DropDownList1.SelectedItem.Value.ToString(), Convert.ToDouble(TextBox1.Text)))
            {
                container.InnerText = "Uspesno uneta valuta za " + Calendar1.SelectedDate.ToString("MM/dd/yyyy");

            }
        }
    }
}
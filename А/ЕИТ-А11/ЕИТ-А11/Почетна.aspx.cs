using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ЕИТ_А11
{
    public partial class Почетна : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            List<string> ErrorList = new List<string>();
            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                error = true;
                ErrorList.Add("прво име");
            }
            if (String.IsNullOrEmpty(TextBox2.Text))
            {
                error = true;
                ErrorList.Add("друго име");
            }
            if (!this.CheckDate(TextBox3.Text) || TextBox3.Text.IndexOf('/') >= 0)
            {
                error = true;
                ErrorList.Add("први датум");
            }
            if (!this.CheckDate(TextBox4.Text) || TextBox4.Text.IndexOf('/') >= 0)
            {
                error = true;
                ErrorList.Add("други датум");
            }
            if (error)
            {
                Label3.Visible = true;
                Label3.Text = "Нисте правилно унели: ";
                int i = 0;
                while (i < ErrorList.Count)
                {
                    Label3.Text += ErrorList[i];
                    if (i++ + 1 != ErrorList.Count)
                    {
                        Label3.Text += ", ";
                    }
                }
            }
            else
            {
                Label3.Visible = false;
                int zbir1 = 0;
                int zbir2 = 0;
                string[] niz_dat1 = TextBox3.Text.Split('.');
                string[] niz_dat2 = TextBox4.Text.Split('.');
                for (int i = 0; i < 3; i++)
                {
                    int j = 0;
                    while (j < niz_dat1[i].Length)
                    {
                        zbir1 += niz_dat1[i][j++] - '0';
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    int j = 0;
                    while (j < niz_dat2[i].Length)
                    {
                        zbir2 += niz_dat2[i][j++] - '0';
                    }
                }
                if (zbir1 > 9)
                {
                    string tmp = zbir1.ToString();
                    zbir1 = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        zbir1 += tmp[i] - '0';
                    }
                }
                if (zbir2 > 9)
                {
                    string tmp = zbir2.ToString();
                    zbir2 = 0;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        zbir2 += tmp[i] - '0';
                    }
                }
                if (zbir1 > zbir2)
                {
                    procenat.InnerText = (((float)zbir2 / (float)zbir1) * 100.0).ToString() + "%";
                }
                else
                {
                    procenat.InnerText = (((float)zbir1 / (float)zbir2) * 100.0).ToString() + "%";
                }
            }
        }
    }
}
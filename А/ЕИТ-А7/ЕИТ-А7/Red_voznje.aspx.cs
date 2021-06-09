using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ЕИТ_А7
{
    public partial class Red_voznje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] linijeF = Directory.GetFiles(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А7\ЕИТ-А7\linija\");
                for (int i = 0; i < linijeF.Length; i++)
                {
                    string tmp = Path.GetFileName(linijeF[i]).ToString();
                    tmp = tmp.Remove(tmp.Length - 4, 4);
                    DropDownList1.Items.Add(tmp);
                }
                string[] red = File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А7\ЕИТ-А7\linija\" + Path.GetFileName(linijeF[0]));
                for (int i = 0; i < red.Length; i++)
                {
                    if (red[i].IndexOf("SMER:") != -1)
                    {
                        DropDownList2.Items.Add(red[i].Remove(0, 5));
                    }
                }
            }

        }

        protected void indexChng(object sender, EventArgs e)
        {
            string[] red = File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А7\ЕИТ-А7\linija\" + DropDownList1.SelectedValue.ToString() + ".txt");
            DropDownList2.Items.Clear();
            for (int i = 0; i < red.Length; i++)
            {
                if (red[i].IndexOf("SMER:") != -1)
                {
                    DropDownList2.Items.Add(red[i].Remove(0, 5));
                }
            }
        }
    }
}
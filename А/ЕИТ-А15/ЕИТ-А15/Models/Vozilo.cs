using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ЕИТ_А15.Models
{
    public class Vozilo
    {
        public string registracija;
        public string marka;
        public string god_p;
        public string boja;
        public List<Put> putevi = new List<Put>();

        public Vozilo(string r, string m, string g, string b)
        {
            registracija = r;
            marka = m;
            god_p = g;
            boja = b;
        }

        public int UkupanPut()
        {
            int sum = 0;
            for (int i = 0; i < putevi.Count; i++)
            {
                sum += putevi[i].km;
            }
            return sum;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ЕИТ_А7
{
    public class Linija
    {
        private string linija;
        private string smer1;
        private string smer2;
        List<string> vremeSmer1;
        List<string> vremeSmer2;

        public Linija(string l, string s1, string s2, List<string> vs1, List<string> vs2)
        {
            linija = l;
            smer1 = s1;
            smer2 = s2;
            vremeSmer1 = vs1;
            vremeSmer2 = vs2;
        }
    }
}
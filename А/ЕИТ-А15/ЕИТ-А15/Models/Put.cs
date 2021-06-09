using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ЕИТ_А15.Models
{
    public class Put
    {
        public string datum;
        public string od_m;
        public string do_m;
        public int km;

        public Put(string d, string o, string dd, int k)
        {
            datum = d;
            od_m = o;
            do_m = dd;
            km = k;
        }
    }
}
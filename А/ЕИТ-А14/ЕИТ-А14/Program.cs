using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prog
{
    public class Program
    {
        private DateTime datum;
        private string vreme;
        private string emisija;
        private string tip;
        private string putanja;

        public Program(DateTime datum, string vreme, string emisija, string tip, string putanja)
        {
            this.datum = datum;
            this.vreme = vreme;
            this.emisija = emisija;
            this.tip = tip;
            this.putanja = putanja;
        }
    }
}
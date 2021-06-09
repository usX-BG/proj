using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ЕИТ_А8
{
    public class Artikal
    {
        public string sifra;
        public string naziv;
        public string proizvodjac;
        public string ram;
        public string procesor;
        public string kamera;
        public string ekran;
        public string putanja;
        public int cena;

        public Artikal(string s, string n, string p, string r, string proc, string k, string e, string put, int c)
        {
            sifra = s;
            naziv = n;
            proizvodjac = p;
            ram = r;
            procesor = proc;
            kamera = k;
            ekran = e;
            putanja = put;
            cena = c;
        }

        public static bool isMatch(List<Artikal> artikli, string s, string param)
        {
            List<string> par = new List<string>();
            bool p = false;
            for (int i = 0; i < artikli.Count; i++)
            {
                switch (param)
                {
                    case "proizvodjac":
                        par.Add(artikli[i].proizvodjac);
                        break;
                    case "ram":
                        par.Add(artikli[i].ram);
                        break;
                    case "procesor":
                        par.Add(artikli[i].procesor);
                        break;
                    case "kamera":
                        par.Add(artikli[i].kamera);
                        break;
                    case "ekran":
                        par.Add(artikli[i].ekran);
                        break;
                }
            }
            for (int i = 0; i < par.Count; i++)
            {
                if (par[i] == s)
                {
                    p = true;
                    break;
                }
            }
            return p;
        }
    }
}
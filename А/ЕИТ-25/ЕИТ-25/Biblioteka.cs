using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ЕИТ_25
{
    public class Biblioteka
    {
        string isbn;
        string naslov;
        int stanje;
        int citano;

        public Biblioteka(string isbn, string naslov, int stanje, int citano)
        {
            this.isbn = isbn;
            this.naslov = naslov;
            this.stanje = stanje;
            this.citano = citano;
        }

        public int  Citano{
            get
            {
                return citano;
            }
            set {
                this.citano = value;
            }
    }
        public string Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                this.isbn = value;
            }
        }
        public string Naslov
        {
            get
            {
                return naslov;
            }
            set
            {
                this.naslov = value;
            }
        }
        public int Stanje
        {
            get
            {
                return stanje;
            }
            set
            {
                this.stanje = value;
            }
        }

        public static List<Biblioteka> sort(List<Biblioteka> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
                for (int j = i - 1; j >= 0 && lista[j].Citano < lista[j+1].Citano; j--)
                {
                    Biblioteka temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
            return lista;
        }
    }
}
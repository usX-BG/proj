using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XML_Web_Servis;

namespace XML_Web_Servis
{
    public class Kurs
    {
        string datum;
        string oznaka;
        double sr_kurs;
        public static string putanja = @"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А10\XML_Web_Servis\XML_Web_Servis\kurs.txt";

        public Kurs(string datum, string oznaka, double kurs)
        {
            this.datum = datum;
            this.oznaka = oznaka;
            this.sr_kurs = kurs;
        }

        public string Datum
        {
            get
            {
                return datum;
            }
        }

        public string Oznaka
        {
            get
            {
                return oznaka;
            }
        }

        public double Sr_kurs
        {
            get
            {
                return sr_kurs;
            }
        }

        public static string ZameniDatum(DateTime datum)
        {
            string datTmp = datum.ToString("dd/MM/yyyy");
            string[] rDat = datTmp.Split('.');
            return rDat[1] + "/" + rDat[0] + "/" + rDat[2];
        }
        public static string ZameniDatumUpis(DateTime datum)
        {
        string datTmp = datum.ToString("dd/MM/yyyy");
        string[] rDat = datTmp.Split('.');
        return rDat[0] + "/" + rDat[1] + "/" + rDat[2];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ЕИТ_А15.Models;
using System.IO;

namespace ЕИТ_А15.Controllers
{
    public class VozilaController : Controller
    {
        //
        // GET: /Voz/

        public ActionResult Index()
        {
            ViewBag.check = "";
            string reg = Request.Form["reg"];
            string dat = Request.Form["datum"];
            string poc = Request.Form["krenuo"];
            string isa = Request.Form["isao_do"];
            string km = Request.Form["km"];
            if (reg != "" && dat != "" && poc != "" && isa != "" && km != "")
            {
                System.IO.File.AppendAllText(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А15\ЕИТ-А15\baza\" + reg + ".txt", Environment.NewLine + dat + "|" + poc + "|" + isa + "|" + km);
                ViewBag.check = "Uspesno ste uneli podatak.";
            }
            else
            {
                ViewBag.check = "Niste popunili sva polja";
            }
            return View();
        }

        public ActionResult Prikaz()
        {
            List<Vozilo> vozila = new List<Vozilo>();
            string[] red = System.IO.File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А15\ЕИТ-А15\baza\vozila.txt");
            for (int i = 0; i < red.Length; i++)
            {
                string registracija, marka, god_p, boja;
                string[] tmp = red[i].Split('|');
                for (int j = 0; j < tmp.Length; j++)
                {
                    tmp[j] = tmp[j].TrimStart(' ');
                    tmp[j] = tmp[j].TrimEnd(' ');
                }
                registracija = tmp[0];
                marka = tmp[1];
                god_p = tmp[2];
                boja = tmp[3];
                vozila.Add(new Vozilo(registracija, marka, god_p, boja));
                string[] tmpRed = System.IO.File.ReadAllLines(@"D:\ШКОЛА\4_РАЗРЕД\Веб_Програмирање\_ПРИПРЕМА_ЗА_МАТУРУ\ЕИТ-А15\ЕИТ-А15\baza\" + registracija + ".txt");
                List<Put> puteviTmp = new List<Put>();
                for (int j = 0; j < tmpRed.Length; j++)
                {
                    string[] spl = tmpRed[j].Split('|');
                    spl[0] = spl[0].TrimStart(' ');
                    spl[0] = spl[0].TrimEnd(' ');
                    spl[1] = spl[1].TrimStart(' ');
                    spl[1] = spl[1].TrimEnd(' ');
                    spl[2] = spl[2].TrimStart(' ');
                    spl[2] = spl[2].TrimEnd(' ');
                    spl[3] = spl[3].TrimStart(' ');
                    spl[3] = spl[3].TrimEnd(' ');
                    puteviTmp.Add(new Put(spl[0], spl[1], spl[2], Convert.ToInt32(spl[3])));
                }
                vozila[i].putevi = puteviTmp;
            }
            return View(vozila);
        }

    }
}

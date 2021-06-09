using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕИТ_Б3
{
    class glumac
    {
        public int id;
        public string Ime;
        public string Prezime;
        public string datum;
        public string mesto;

        public glumac(int id, string i, string p, string d, string m)
        {
            this.id = id;
            Ime = i;
            Prezime = p;
            datum = d;
            mesto = m;
        }

        public static int GetIndexId(List<glumac> glumci, int idParam)
        {
            int tmpId;
            for (int i = 0; i < glumci.Count; i++)
            {
                if (glumci[i].id == idParam)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

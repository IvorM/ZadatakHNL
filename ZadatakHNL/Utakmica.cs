using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakHNL
{
    class Utakmica
    {
        public Klub gost, domacin;
        public int[] rezultat;
        public List<Strijelac> strijelci;

        public Utakmica()
        {
            rezultat = new int[2];
            strijelci = new List<Strijelac>();
        }

        public string GetInfoBasic()
        {
            string povratniString = "";
            povratniString = $"{domacin.naziv}-{gost.naziv} Rezultat:{rezultat[0]}-{rezultat[1]} \n Strijelci: \n";
            foreach (var strijelac in strijelci)
            {
                povratniString += $"{strijelac.Ime} {strijelac.Prezime}({strijelac.MinutaPogodtka})\n";
            }

            return povratniString;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakHNL
{
    class Strijelac
    {
        public string Ime, Prezime;
        public Klub Klub;
        public int MinutaPogodtka;

        public Strijelac(string ime,string prezime,Klub klub,int minuta)
        {
            Ime = ime;
            Prezime = prezime;
            Klub = klub;
            MinutaPogodtka = minuta;
        }
    }
}

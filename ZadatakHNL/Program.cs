using System;

namespace ZadatakHNL
{
    class Program
    {
        static void Main(string[] args)
        {
            HNL hnl = new HNL();


            Utakmica novaUtakmica = new Utakmica();
            novaUtakmica.rezultat[0] = 1;
            novaUtakmica.rezultat[1] = 1;

            Klub klubDomacin = new Klub("Dinamo", "Zagreb");
            Klub klubGost = new Klub("Hajduk", "Split");
            novaUtakmica.domacin = klubDomacin;
            novaUtakmica.gost = klubGost;

            Strijelac domaciStrijelac = new Strijelac("Ante", "Antic", klubDomacin, 43);
            Strijelac gostStrijelac = new Strijelac("Pero", "Peric", klubGost, 77);
            novaUtakmica.strijelci.Add(domaciStrijelac);
            novaUtakmica.strijelci.Add(gostStrijelac);

            Utakmica novaUtakmica2 = new Utakmica();
            novaUtakmica2.rezultat[0] = 0;
            novaUtakmica2.rezultat[1] = 1;

            Klub klubDomacin2 = new Klub("Varteks", "Varaždin");
            Klub klubGost2 = new Klub("Gorica", "VG");
            novaUtakmica2.domacin = klubDomacin2;
            novaUtakmica2.gost = klubGost2;

            Strijelac gostStrijelac2 = new Strijelac("Ivo", "Ivic", klubGost2, 1);
            novaUtakmica2.strijelci.Add(gostStrijelac2);

            hnl.NovaUtakmica(novaUtakmica);
            hnl.NovaUtakmica(novaUtakmica2);

            foreach (var utakmica in hnl.GetUtakmice())
            {
                Console.WriteLine(utakmica.GetInfoBasic());
            }
            
        }
    }
}

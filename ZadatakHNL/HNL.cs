using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakHNL
{
    class HNL
    {
        List<Utakmica> Utakmice;

        public HNL()
        {
            Utakmice = new List<Utakmica>();
        }

        public void NovaUtakmica(Utakmica novaUtakmica)
        {
            Utakmice.Add(novaUtakmica);
        }

        public List<Utakmica> GetUtakmice()
        {
            return Utakmice;
        }
    }
}

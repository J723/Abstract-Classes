using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Insetto : Animale, Pattern_Peloso
    {
        public Insetto(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Insetto")
        {
            SetManto();
        }

        public void SetManto()
        {
            manto = "Pelosetto";
        }
    }
}

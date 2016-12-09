using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Uccello : Animale, Pattern_Piumoso
    {
        public Uccello(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Uccello")
        {
            SetManto();
        }

        public void SetManto()
        {
            manto = "Piumoso";
        }
    }
}

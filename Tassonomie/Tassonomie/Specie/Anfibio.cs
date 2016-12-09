using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Anfibio : Animale, Pattern_Viscido
    {
        public Anfibio(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Anfibio")
        {
            SetManto();
        }

        public void SetManto()
        {
            manto = "Viscido";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Pinguino : Uomo, Pattern_Viscido
    {
        public Pinguino()
        {
            nomeAnimale = "il Pinguino";
            habitat = "Fogne";
            specie = "Super cattivo, nemico di batman";
            SetManto();
        }

        public override string SiMuove()
        {
            return "Il pinguino rotola o striscia, in alternativa usa il suo ombrello come rampino";
        }

        public void SetManto()
        {
            manto = "Viscido";
        }
    }
}

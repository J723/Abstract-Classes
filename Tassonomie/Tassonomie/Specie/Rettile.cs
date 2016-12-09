using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Rettile : Animale, Pattern_Squamoso
    {
        public Rettile(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Rettile")
        {
            SetManto();
        }

        public void SetManto()
        {
            manto = "Squamoso";
        }
    }
}

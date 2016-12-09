using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Pesce : Animale, Pattern_Squamoso
    {
        public Pesce(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Insetto")
        {
            SetManto();
        }

        public void SetManto()
        {
            manto = "Squamoso";
        }
    }
}

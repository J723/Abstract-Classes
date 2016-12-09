using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Mammifero : Animale
    {
        public Mammifero(string nomeAnimale, string habitat) : base(nomeAnimale, habitat, "Rettile")
        {
        }
    }
}

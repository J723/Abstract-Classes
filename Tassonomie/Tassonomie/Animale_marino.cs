using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_marino : Animale_Acquatico
    {
        public Animale_marino(string nome, string tipo) : base(nome, tipo, "Oceano", 0)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Quadrupede : Animale_Terrestre
    {
        public Quadrupede(string nome, string tipo, string habitat) : base(nome, tipo, 4, habitat)
        { }

        public override string SiMuove()
        {
            return "|_|_ -> /_|_/_|_ -> |_|_";
        }
    }
}

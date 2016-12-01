using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Bipede : Animale_Terrestre
    {
        public Bipede(string nome, string tipo, string habitat) : base(nome, tipo, 2, habitat)
        { }

        public override string SiMuove()
        {
            return "|_ -> /_|_ -> |_";
        }
    }
}

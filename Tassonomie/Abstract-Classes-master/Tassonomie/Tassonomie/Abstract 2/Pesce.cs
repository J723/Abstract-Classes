using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Pesce : Animale_Acquatico
    {
        public Pesce(string nome, string habitatAcquatico) :base(nome, "pesce", habitatAcquatico, 0)
        { }

        public override string SiMuove()
        {
            return "==  ==  >0-  ==  ==  >0-";
        }
    }
}

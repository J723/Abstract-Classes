using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Acquatico : Animale
    {
        public Animale_Acquatico(string nome, string tipo, string habitatAcquatico, int numeroZampe) : base(nome, tipo, habitatAcquatico, numeroZampe)
        { }
    }
}

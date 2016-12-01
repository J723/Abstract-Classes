using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Terrestre : Animale
    {
        public Animale_Terrestre(string nome, string tipo, int numeroZampe, string habitat) : base(nome, tipo, habitat, numeroZampe)
        { }
    }
}

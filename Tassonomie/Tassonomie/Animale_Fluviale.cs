using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale_Fluviale : Animale_Acquatico //oppure terrestre
    {
        public Animale_Fluviale(string nome, string tipo, int numeroZampe) : base(nome, tipo, "Fluviale", numeroZampe)
        { }
    }
}

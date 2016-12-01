using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Uomo : Bipede
    {
        public Uomo(string nome, string habitat):base(nome, "Umano", habitat)
        { }
    }
}

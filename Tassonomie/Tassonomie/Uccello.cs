using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Uccello : Bipede
    {
        public Uccello(string nome, string habitat):base(nome, "Uccello", habitat)
        { }

        public override string SiMuove()
        {
            return "System.NullReferenceException()";
        }
    }
}

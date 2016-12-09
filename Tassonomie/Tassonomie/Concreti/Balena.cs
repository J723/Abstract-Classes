using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Balena : Mammifero, Pattern_Squamoso, Ambiente_Marino, Zampe
    {
        public Balena():base("Balena", "Oceani/mari freddi")
        {
            SetAmbiente();
            SetManto();
        }

        public override string SiMuove()
        {
            return "Nuota...flush flush...";
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "marino";
        }

        public void SetManto()
        {
            manto = "Squamosetto";
        }

        public void SetNumZampe()
        {
            numeroZampe = 0;
        }
    }
}

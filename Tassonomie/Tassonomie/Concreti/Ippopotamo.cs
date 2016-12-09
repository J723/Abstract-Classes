using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Ippopotamo : Mammifero, Ambiente_Terrestre, Pattern_Peloso, Zampe_Quadrupede
    {
        public Ippopotamo() : base("Ippopotamo", "savana")
        {
            SetAmbiente();
            SetManto();
            SetNumZampe();
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "terrestre";
        }

        public void SetManto()
        {
            manto = "pelle, ottimo per fare borse";
        }

        public void SetNumZampe()
        {
            numeroZampe = 4;
        }

        public override string SiMuove()
        {
            return "zoppica";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Cavallo : Mammifero, Ambiente_Terrestre, Pattern_Peloso, Zampe_Quadrupede
    {
        public Cavallo() : base("Cavallo", "praterie")
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
            manto = "Peloso";
        }

        public void SetNumZampe()
        {
            numeroZampe = 4;
        }

        public override string SiMuove()
        {
            return "Galoppa...trot trot...";
        }
    }
}

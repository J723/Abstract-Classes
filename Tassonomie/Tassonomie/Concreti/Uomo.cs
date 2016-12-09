using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Uomo : Mammifero, Ambiente_Terrestre, Zampe_Bipede, Pattern_Peloso
    {
        public Uomo():base("Uoma o donno", "cittadino/montanaro/contadino inniorante (nel senso che ignora)")
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
            manto = "pelle e peli";
        }

        public void SetNumZampe()
        {
            numeroZampe = 2;
        }

        public override string SiMuove()
        {
            return "cammina, al massimo rotola...|_.../_|_...|_";
        }
    }
}

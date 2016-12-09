using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Becco : Mammifero, Ambiente_Terrestre, Zampe_Quadrupede, Pattern_Peloso
    {
        public Becco() : base("Bécco", "montagna, preferibilmente Bérgamo")
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
            manto = "Petaloso...dovevo usarlo prima o poi";
        }

        public void SetNumZampe()
        {
            numeroZampe = 4;
        }

        public override string SiMuove()
        {
            return "Galoppa e vince concorsi alla fiera dei Becchi\nPerchè la capra, è il miglior amico dell'uomo, dopo, la donna\n-cit.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Stivale : Anfibio, Zampe, Ambiente_Terrestre
    {
        public Stivale() : base("Stivale", "Piedi di un pescatore")
        {
            SetAmbiente();
            SetNumZampe();
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "terrestre";
        }

        public void SetNumZampe()
        {
            numeroZampe = 1;
        }

        public override string SiMuove()
        {
            return "Vive di vita propria, a volte lo si usa come passaporta";
        }
    }
}

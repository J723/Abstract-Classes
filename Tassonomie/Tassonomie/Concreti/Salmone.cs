using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Salmone : Pesce, Ambiente_Fluviale, Zampe
    {
        public Salmone() : base("Salmone", "mari del nord o acqua dolce")
        {
            SetAmbiente();
            SetNumZampe();
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "Mare o fiume";
        }

        public void SetNumZampe()
        {
            numeroZampe = 0;
        }

        public override string SiMuove()
        {
            return "nuota... flush flush splash!";
        }
    }
}

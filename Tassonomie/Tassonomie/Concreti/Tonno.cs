using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    class Tonno : Pesce, Ambiente_Marino, Zampe
    {
        public Tonno() : base("tonno", "mari freddi")
        {
            SetAmbiente();
            SetNumZampe();
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "marino";
        }

        public void SetNumZampe()
        {
            numeroZampe = 0;
        }

        public override string SiMuove()
        {
            return "nuota...flush splash! flush";
        }
    }
}

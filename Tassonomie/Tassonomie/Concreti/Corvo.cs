using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie 
{
    class Corvo : Uccello, Ambiente_Terrestre, Zampe_Bipede
    {
        public Corvo():base("corvo", "Cimiteri oppure film in cui i protagonisti muoiono davvero")
        {
            SetAmbiente();
            SetNumZampe();
        }

        public void SetAmbiente()
        {
            tipoAmbiente = "Terrestre";
        }

        public void SetNumZampe()
        {
            numeroZampe = 2;
        }

        public override string SiMuove()
        {
            return "Vola...flush flush....";
        }
    }
}

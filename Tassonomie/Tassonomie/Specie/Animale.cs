using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale
    {
        protected string nomeAnimale;   //cavallo, toro...
        protected string tipoAmbiente;  //terrestre, acquatico
        protected string specie;        //mammifero, volatile
        protected string habitat;       //foreste, fiumi, laghi
        protected int numeroZampe;
        protected string manto; 

        public abstract string SiMuove();

        public Animale(string nomeAnimale, string habitat, string specie)
        {
            this.nomeAnimale = nomeAnimale;
            this.habitat = habitat;
            this.specie = specie;
        }
        
        public void Riepilogo()
        {
            string[] d = new string[] {
                "Nome: " + nomeAnimale,
                "Tipo: " + tipoAmbiente,
                "Habitat: " + habitat,
                "Specie: " + specie,
                "Manto: " + manto,
                "Numero di zampe: " + numeroZampe,
                "Movimento: " + SiMuove() + "\n"
            };
            foreach (string s in d)
                Console.WriteLine(s);
        }
    }
}

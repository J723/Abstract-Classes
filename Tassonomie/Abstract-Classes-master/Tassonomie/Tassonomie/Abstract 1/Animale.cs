using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomie
{
    abstract class Animale
    {
        protected string nome;
        protected string tipo;
        protected string habitat;
        protected int numeroZampe;

        public abstract string SiMuove();

        public Animale(string nome, string tipo, string habitat, int numeroZampe)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.habitat = habitat;
            this.numeroZampe = numeroZampe;
        }
        
        public void Riepilogo()
        {
            Console.WriteLine(new string[] {
                "Nome: " + nome,
                "Tipo: " + tipo,
                "Habitat: " + habitat,
                "Numero di zampe: " + numeroZampe,
                "\n" + SiMuove()
            });
        }
    }
}

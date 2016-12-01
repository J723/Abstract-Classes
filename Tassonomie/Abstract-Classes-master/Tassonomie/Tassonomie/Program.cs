using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;
namespace Tassonomie
{
    class Program
    {
        List<Animale> zoo = new List<Animale>();

        static void Main(string[] args, List<Animale> Zoo)
        {
            string[] m1 = new string[]
            {
                "Dai un' occhiata agli esperimenti di laboratorio non riusciti di dio!",
                "Imita dio, ma peggio!",
            };     
            string[] m2 = new string[]
            {
                "Pinguino",
                "Cavallo",
                "corvo",
                "Salmone",
                "Toro",
                "uomo",
            };
            
            switch (new MenuSelezione(m1, ConsoleColor.DarkGray, ConsoleColor.Red, true, ">", "<").Run())
            {
                case 0:
                    foreach (Animale m in Zoo)
                        Console.WriteLine(m.SiMuove());
                    break;

                case 1:
                    NewAnimals(m2, Zoo);
                    break;
            }
        }

        static void NewAnimals(string[] menu, List<Animale> zoo)
        {
            string[] data;
            string[] m;
            switch (new MenuSelezione(menu, ConsoleColor.DarkGray, ConsoleColor.Red, true, ">", "<").Run())
            {
                case 0:
                    zoo.Add(new Pinguino());
                    break;
                case 1:
                    m = new string[]{"nome: ", "habitat: "};
                    data = new MenuInserimento(m).Run(true);
                    zoo.Add(new Cavallo(data[0], data[1]));
                    break;
                case 2:
                    m = new string[]{"nome: "};
                    data = new MenuInserimento(m).Run(true);
                    zoo.Add(new Corvo(data[0]));
                    break;
            }
        }
    }
}

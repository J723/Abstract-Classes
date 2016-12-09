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
        static List<Animale> zoo = new List<Animale>();
        static string[] menuContent = new string[]
            {
                "Aggiungi una béla béshtia",
                "Dai un'occhiata al porcile",
                "Eschi dallo prorgammo",
            };
        static string[] bestie = new string[]
        {
            "Uomo",
            "Tonno",
            "Stivale",
            "Salmone",
            "Pinguino",
            "Ippopotamo",
            "Corvo",
            "Cavallo",
            "Balena",
            "Bécco"
        };

        static void Main(string[] args)
        {
            do
            {
                switch (ConsoleMenu.Selection(menuContent, ConsoleColor.Black, ConsoleColor.Red, null, "<<"))
                {
                    case 0:
                        Console.Clear();
                        NewBeshtia(ConsoleMenu.Selection(bestie, ConsoleColor.Black, ConsoleColor.Blue, "", "<<"));
                        Console.Clear();
                        Console.WriteLine("Fatto!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        foreach (Animale b in zoo)
                            b.Riepilogo();

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
                        Console.ReadLine();
                        return;
                }
            } while (true);
        }

        public static void NewBeshtia(int index)
        {
            switch(index)
            {
                case 0:
                    zoo.Add(new Uomo());
                    break;

                case 1:
                    zoo.Add(new Tonno());
                    break;

                case 2:
                    zoo.Add(new Stivale());
                    break;

                case 3:
                    zoo.Add(new Salmone());
                    break;

                case 4:
                    zoo.Add(new Pinguino());
                    break;

                case 5:
                    zoo.Add(new Ippopotamo());
                    break;

                case 6:
                    zoo.Add(new Corvo());
                    break;

                case 7:
                    zoo.Add(new Cavallo());
                    break;

                case 8:
                    zoo.Add(new Balena());
                    break;

                case 9:
                    zoo.Add(new Becco());
                    break;
            }
        }
    }
}


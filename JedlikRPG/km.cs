using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void km()
        {

        }
        static void Eurobolt(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<string> Inventory)
        {
            while (gameover != true)
            {
                while (choice < 1 || choice > 3)
                {
                    choice = Input("Választás: ");
                    if (choice == 1)
                    {
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                        Console.WriteLine("\nElmentél vizelni egy jót");
                        hugyholyag = 0;
                        Console.WriteLine("");
                        Console.WriteLine("2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)");
                        choice = 0;
                    }
                    if (choice == 2)
                    {
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                        Console.WriteLine("\nMég életedben nem ettél finomat. Bár a házi koszt nem csillapítja az elégedetlenséged, melyet iskolád okoz");
                        ehseg -= 25;
                        Console.WriteLine("");
                        Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elmész a buszmegállóba (3 perc)");
                        choice = 0;
                    }
                    if (choice == 3)
                    {
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                    }
                    if (choice == 4)
                    {
                        foreach (string item in Inventory)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}

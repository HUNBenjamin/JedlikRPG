using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void reggel()
        {


        }

        static int reggel(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, bool buszjegy, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out bool x9)
        {
            while (choice < 1 || choice > 4)
            {
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    hugyholyag = 0;
                    busz -= 2;
                    vizeles(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                    choice = 0;
                }
                else if (choice == 2)
                {
                    ehseg -= 25;
                    busz -= 15;
                    reggelizes(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                    choice = 0;
                }
                else if (choice == 3)
                {
                    busz -= 3;
                    buszSeta(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                    choice = 0;
                    while (choice < 1 || choice > 2)
                    {
                        Console.WriteLine($"1 - Vásárolj jegyet (2 perc)\n2 - Várd meg a buszt ({busz} perc)");
                        choice = Input("Választás: ");
                        if (choice == 1)
                        {
                            busz -= 2;
                            buszjegy = true;
                            jegyvetel(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                            choice = 0;
                        }
                        else
                        {
                            while (busz > 0)
                            {
                                busz--;
                            }
                            buszraszallas(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                            break;
                        }
                    }

                    if (busz < 0)
                    {
                        Console.WriteLine("\nSajnos lekésted a buszt.");
                        Console.WriteLine("Nem sikerült beérned az iskolába, így túl sok hiányzás miatt kirúgtak.");
                        gameover = true;
                        Console.WriteLine("\nA játéknak vége\n");
                        break;
                    }
                }
                if (choice == 4)
                {
                    foreach (string item in Inventory)
                    {
                        Console.WriteLine(item);
                    }
                    choice = 0;
                }
                if (busz < 0)
                {
                    Console.WriteLine("\nSajnos lekésted a buszt.");
                    Console.WriteLine("Nem sikerült beérned az iskolába, így túl sok hiányzás miatt kirúgtak.");
                    gameover = true;
                    Console.WriteLine("\nA játéknak vége\n");
                    x1 = choice;
                    x2 = busz;
                    x3 = elegemvan;
                    x4 = ehseg;
                    x5 = hugyholyag;
                    x6 = ero;
                    x7 = Inventory;
                    x8 = gameover;
                    x9 = buszjegy;
                    return 1;
                }

            }
            x1 = choice;
            x2 = busz;
            x3 = elegemvan;
            x4 = ehseg;
            x5 = hugyholyag;
            x6 = ero;
            x7 = Inventory;
            x8 = gameover;
            x9 = buszjegy;
            return 0;
        }
    }
}
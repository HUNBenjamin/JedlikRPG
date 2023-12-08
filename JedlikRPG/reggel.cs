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

        static int megallo(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, bool buszjegy, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out bool x9)
        {
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
                    while (busz >= 0)
                    {
                        busz--;
                    }
                    buszraszallas(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                }
            }
            if (busz < 0)
            {
                Console.WriteLine("\nSajnos lekésted a buszt.");
                Console.WriteLine("Nem sikerült beérned az iskolába, így túl sok hiányzás miatt kirúgtak.");
                gameover = true;
                Console.WriteLine("\nA játéknak vége\n");
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

        static int szentistvanut(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, bool buszjegy, int becsengo, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out bool x9, out int x10)
        {
            choice = 0;
            while (choice < 1 || choice > 4)
            {
                Console.Clear();

                Console.WriteLine($"Helyszín: Szent István út");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("\nMegérkeztél a városba. ");
                Console.WriteLine($"Menj a Jedlikbe, {becsengo} perc múlva becsengetnek.");
                Console.WriteLine("");


                Console.WriteLine("\n1 - Lelépsz az úttestre a közeledő kamion elé\n2 - Bemész az euróboltba (5 perc)\n3 - Elsétálsz a Jedlikbe\n4 - Táska megtekintése");
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Helyszín: Szent István út");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");
                    Console.WriteLine("");
                    Console.WriteLine("Nem úszod meg ilyen könnyen");
                    Console.WriteLine("\n1 - Lelépsz az úttestre a közeledő kamion elé\n2 - Bemész az euróboltba (5 perc)\n3 - Elsétálsz a Jedlikbe (5 perc)\n4 - Táska megtekintése");
                    choice = 0;
                }
                if (choice == 2)
                {
                    Eurobolt(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory);
                    Console.Clear();
                    Console.WriteLine($"Helyszín: Szent István út");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");
                    Console.WriteLine("");
                    Console.WriteLine("Mennyi minden volt itt");
                    Console.WriteLine("\n1 - Lelépsz az úttestre a közeledő kamion elé\n2 - Bemész az euróboltba (5 perc)\n3 - Elsétálsz a Jedlikbe (5 perc)\n4 - Táska megtekintése");
                    choice = 0;
                    becsengo -= 5;
                }
                if (choice == 3)
                {
                    Console.WriteLine("Megérkeztél iskoládba. Íme, ezt nevezik pokolnak.");
                    becsengo -= 5;
                    break;
                }
                if (becsengo < 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Helyszín: Jedlik");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");
                    Console.WriteLine("");
                    Console.WriteLine("\nSajnos túl sokáid vánszorogtál.");
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
                    x10 = becsengo;
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
            x10 = becsengo;
            return 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void JedlikA()
        {


        }

        static int JedlikA(int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, int osztondij, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out int x9)
        {
            Console.WriteLine("Számos lehetőség van a továbbhaladásra. Annyi éve ide jársz, mégis egyfolytában eltévedsz. Merre tovább?\n");
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine($"Úgy tűnik az első órád matek. Menj órára mielőtt becsengetnek ({becsengo} perc)");
                Console.WriteLine("\n1 - Első kapu (1 perc)\n2 - Hátsó kapu(2 perc)\n3 - Ebédbő (1 perc)\n4 - Gépészlépcső (1 perc)\n5 - Folyosó");
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    if (elsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, out becsengo) == 0)
                    {
                        Console.WriteLine("Továbbmész a hátsó kapu fele, vagy merre vezet utad?");
                        choice = 0;
                    }
                }
                if (choice == 2)
                {
                    if (hatsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, out becsengo) == 0)
                    {
                        choice = 0;
                    }
                }
                if (choice == 3)
                {
                    ebedlo(osztondij, choice, becsengo, elegemvan, ehseg, hugyholyag, ero, out osztondij, out choice, out becsengo);
                }
                if (choice == 4)
                {
                    //gepeszLepcso();
                }
                if (choice == 5)
                {
                    //folyoso();
                }

            }

            x1 = choice;
            x2 = becsengo;
            x3 = elegemvan;
            x4 = ehseg;
            x5 = hugyholyag;
            x6 = ero;
            x7 = Inventory;
            x8 = gameover;
            x9 = osztondij;
            return 0;
        }

        static int elsoKapu(int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, out int x1)
        {
            Random pityu = new Random();

            Console.Clear();

            becsengo -= 1;

            Console.WriteLine($"Helyszín: Első kapu ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");
            Console.WriteLine("\nAz első kapu felé haladva utadat állja a biztonsági személyzet és valamiért a 196-os szám jut eszedbe.\nAzt mondja neked:");

            int chance = pityu.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("*rekedt hangon* Mi az, hogy első kapu, nincs olyan, hogy első kapu.");
            }
            else
            {
                Console.WriteLine("Hátsó kapu fele kell menni, de ugye nem cigarettázni??");
            }
            x1 = becsengo;
            return 0;
        }

        static int hatsoKapu(int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, out int x1)
        {
            Console.Clear();
            Console.WriteLine($"Helyszín: Első kapu ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");
            Console.WriteLine("\nA hátsó kapu nyitva van, úgy tűnik.\nHova tovább?");

            becsengo -= 2;

            x1 = becsengo;
            return 0;
        }

        static int ebedlo(int osztondij, int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, out int x1, out int x2, out int x3)
        {
            becsengo -= 1;
            Console.Clear();
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine($"Helyszín: Első kapu ");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("\nAz ebédlő számos lehetőséget nyújt");
                Console.WriteLine("\n1 - Vegyél valami finomat (2 perc)\n2 - Lopd el valaki uzsipénzét (2 perc)\n3 - Vissza a folyosóra (1 perc)\n4 - Gépészlépcső\n5 - Folyosó");
            }

            if (choice == 1)
            {
                Console.Clear();
                //TODO automata
                osztondij -= 500;
                becsengo -= 2;
                Console.WriteLine("Vettél valami szépet");
                choice = 0;
            }

            if (choice == 2)
            {
                Console.Clear();
                //TODO nehézség
                osztondij += 1000;
                becsengo -= 2;
                Console.WriteLine("A rablás nem is áll olyan rosszul neked");
                choice = 0;
            }

            else
            {
                becsengo -= 1;
                //folyoso();
            }

            x1 = osztondij;
            x2 = choice;
            x3 = becsengo;
            return 0;
        }
    }
}
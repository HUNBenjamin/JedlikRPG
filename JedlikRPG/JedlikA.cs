using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2021.MipLabelMetaData;
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
        static int JedlikA(int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<List<dynamic>> Inventory, bool gameover, int osztondij, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<List<dynamic>> x7, out bool x8, out int x9)
        {
            if (becsengo < 0)
            {
                gameover = true;
            }

            bool matek = false;
            bool angol = false;
            bool tortenelem = false;
            bool fizika = false;
            bool irodalom = false;
            bool tesi = false;

            string ora = "matek";
            if (matek == true)
            {
                ora = "angol";
            }
            if (angol == true)
            {
                ora = "történelem";
            }
            if (tortenelem == true)
            {
                ora = "fizika";
            }
            if (fizika == true)
            {
                ora = "irodalom";
            }
            if (irodalom == true)
            {
                ora = "tesi";
            }


        static int JedlikA(int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, int osztondij, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out int x9)
        {
            if (becsengo < 0)
            {
                gameover = true;
            }

            bool matek = false;
            bool angol = false;
            bool tortenelem = false;
            bool fizika = false;
            bool irodalom = false;
            bool tesi = false;

            string ora = "matek";
            if (matek == true)
            {
                ora = "angol";
            }
            if (angol == true)
            {
                ora = "történelem";
            }
            if (tortenelem == true)
            {
                ora = "fizika";
            }
            if (fizika == true)
            {
                ora = "irodalom";
            }
            if (irodalom == true)
            {
                ora = "tesi";
            }

            Console.WriteLine("Számos lehetőség van a továbbhaladásra. Annyi éve ide jársz, mégis egyfolytában eltévedsz. Merre tovább?\n");
            choice = 0;
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine($"\nA következő órád {ora}. Menj órára mielőtt becsengetnek ({becsengo} perc)\n");
                Console.WriteLine("\n1 - Első kapu (1 perc)\n2 - Hátsó kapu (2 perc)\n3 - Folyosó (1 perc)");
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
                    if (folyoso(becsengo, out becsengo) == 11)
                    {
                        if (ebedlo(osztondij, choice, becsengo, elegemvan, ehseg, hugyholyag, ero, gameover, out osztondij, out choice, out becsengo, out gameover) == 1)
                        {
                            gameover = true;
                            break;
                        }
                        else
                        {
                            choice = 0;
                        }
                    }

                }
                if (choice == 4)
                {
                    int altChoice = -1;
                    while (altChoice == -1)
                    {
                        PrintInventory(Inventory);
                        Console.WriteLine("0. Kilépés");
                        altChoice = Input("Választás: ");
                    }
                    if (altChoice == 0) break;
                    else
                    {
                        UseItem(Inventory, Inventory[altChoice - 1][0], ehseg, elegemvan, hugyholyag, ero, out ehseg, out elegemvan, out hugyholyag, out ero, out Inventory);
                    }
                }
            }

            if (becsengo < 0)
            {
                Console.WriteLine("Nem értél be időben órára, sajnos kirúgtak.");
                gameover = true;
                x1 = choice;
                x2 = becsengo;
                x3 = elegemvan;
                x4 = ehseg;
                x5 = hugyholyag;
                x6 = ero;
                x7 = Inventory;
                x8 = gameover;
                x9 = osztondij;
                return 1;
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

            Console.WriteLine($"Helyszín: Első kapu");
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
            Console.WriteLine($"Helyszín: Hátsó kapu");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");
            Console.WriteLine("\nA hátsó kapu nyitva van, úgy tűnik.\nHova tovább?");

            becsengo -= 2;

            x1 = becsengo;
            return 0;
        }

        static int ebedlo(int osztondij, int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, out int x1, out int x2, out int x3, out bool x4)
        {
            becsengo -= 1;
            Console.Clear();
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine($"Helyszín: Ebédlő");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("\nAz ebédlő számos lehetőséget nyújt");
                Console.WriteLine("\n1 - Vegyél valami finomat (2 perc)\n2 - Lopd el valaki uzsipénzét (2 perc)\n");
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
                Random veres = new Random();
                int vereschance = veres.Next(0, 10);

                if (vereschance == 5)
                {
                    Console.Clear();
                    //TODO nehézség
                    becsengo -= 2;
                    Console.WriteLine("A másvilágra vertek lopási kísérlet miatt\nVége a játéknak");
                    gameover = true;
                    x1 = osztondij;
                    x2 = choice;
                    x3 = becsengo;
                    x4 = gameover;
                    return 1;
                }
                else
                {
                    Console.Clear();
                    //TODO nehézség
                    osztondij += 1000;
                    becsengo -= 2;
                    Console.WriteLine("A rablás nem is áll olyan rosszul neked");
                    choice = 0;
                }
            }

            else
            {
                becsengo -= 1;
            }

            x1 = osztondij;
            x2 = choice;
            x3 = becsengo;
            x4 = gameover;
            return 0;
        }

        static int folyoso( int becsengo, out int x2)
        {
            int choice = 0;
            while (choice < 1 || choice > 11) 
            {
                Console.WriteLine("\n1 - Gépészlépcső (1 perc)\n2 - Orvosi szoba (1 perc)\n3 - Büfé (1 perc)\n4 - Mellékhelyiség (1 perc)\n5 - Matek óra terme (1 perc)\n6 - Angol óra terme (1 perc)\n7 - Történelem óra terme (1 perc)\n8 - Fizika óra terme (1 perc)\n9 - Irodalom óra terme (1 perc)\n10 - Gépterem (1 perc)\n11 - Ebédlő (1 perc)\n");
                choice = Input("Választás: ");
            }

            if (choice == 1)
            {
                x2 = becsengo;
                return 1;
            }
            if (choice == 2)
            {
                x2 = becsengo;
                return 2;
            }
            if (choice == 3)
            {
                x2 = becsengo;
                return 3;
            }
            if (choice == 4)
            {
                x2 = becsengo;
                return 4;
            }
            if (choice == 5)
            {
                x2 = becsengo;
                return 5;
            }
            if (choice == 6)
            {
                x2 = becsengo;
                return 6;
            }
            if (choice == 7)
            {
                x2 = becsengo;
                return 7;
            }
            if (choice == 8)
            {
                x2 = becsengo;
                return 8;
            }
            if (choice == 9)
            {
                x2 = becsengo;
                return 9;
            }
            if (choice == 10)
            {
                x2 = becsengo;
                return 10;
            }
            if (choice == 11)
            {
                x2 = becsengo;
                return 11;
            }
            x2 = becsengo;
            return 0;
        }
    }
}
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
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
        static int JedlikA(int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<List<dynamic>> Inventory, bool gameover, int osztondij, Difficulty difficulty, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<List<dynamic>> x7, out bool x8, out int x9)
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
            }
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
                    if (hatsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, osztondij, gameover, difficulty, Inventory, out becsengo) == 0)
                    {
                        choice = 0;
                    }

                    else if (hatsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, osztondij, gameover, difficulty, Inventory, out becsengo) == 1)
                    {
                        JedlikBepulet(becsengo, elegemvan, ehseg, hugyholyag, ero, Inventory, gameover, osztondij, difficulty, choice, out becsengo, out elegemvan, out ehseg, out hugyholyag, out ero, out Inventory, out gameover, out osztondij, out difficulty, out choice);
                    }
                }
                if (choice == 3)
                {
                    if (folyoso(ora, becsengo, difficulty, out becsengo) == 1)
                    {

                        if (gepeszlepcso(osztondij, becsengo, elegemvan, ehseg, hugyholyag, ero, gameover, difficulty, out elegemvan, out becsengo) == 1)
                        {
                            if (OrvosiSzoba(elegemvan, becsengo, out elegemvan, out becsengo) == 1)
                            {
                                Console.WriteLine("Mi a baj? Csak nem fáj valami?");
                            }
                        }
                        else if (gepeszlepcso(osztondij, becsengo, elegemvan, ehseg, hugyholyag, ero, gameover, difficulty, out elegemvan, out becsengo) == 2)
                        {
                            if (ora == "angol")
                            {
                                Angol(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag);
                            }
                            else
                            {
                                Console.WriteLine($"Nem most lesz {ora}, te nagyon okos");
                                choice = 0;
                            }
                        }
                        else if (gepeszlepcso(osztondij, becsengo, elegemvan, ehseg, hugyholyag, ero, gameover, difficulty, out elegemvan, out becsengo) == 3)
                        {
                            folyoso(ora, becsengo, difficulty, out becsengo);
                        }
                        choice = 0;
                    }
                    if (folyoso(ora, becsengo, difficulty, out becsengo) == 2)
                    {
                        if (OrvosiSzoba(elegemvan, becsengo, out elegemvan, out becsengo) == 1)
                        {
                            Console.WriteLine("Mi a baj? Csak nem fáj valami?");
                        }
                    }

                    if (folyoso(ora, becsengo, difficulty, out becsengo) == 3)
                    {
                        bufe(choice, elegemvan, ehseg, hugyholyag, osztondij, ero, gameover, Inventory, out Inventory, out osztondij);
                    }

                if (folyoso(ora, becsengo, difficulty, out becsengo) == 4)
                {
                    if (Mellekhelyiseg(elegemvan, becsengo, hugyholyag, out elegemvan, out becsengo, out hugyholyag) == 1)
                    {
                        choice = 0;
                    }
                }

                if (folyoso(ora, becsengo, difficulty, out becsengo) == 5)
                {
                    if (ora == "matek")
                    {
                        if (Matek(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag) == 1)
                        {
                            matek = true;
                            choice = 0;
                            becsengo = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nem most lesz matek, te nagyon okos");
                        choice = 0;
                    }
                    
                }
                if (folyoso(ora, becsengo, difficulty, out becsengo) == 6)
                {
                    if (ora == "angol")
                    {
                        if (Angol(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag) == 1)
                        {
                            angol = true;
                            choice = 0;
                            becsengo = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nem most lesz angol, te nagyon okos");
                        choice = 0;
                    }

                }
                if (folyoso(ora, becsengo, difficulty, out becsengo) == 7)
                {
                    if (ora == "történelem")
                    {
                        if (Tortenelem(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag) == 1)
                        {
                            tortenelem = true;
                            choice = 0;
                            becsengo = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nem most lesz történelem, te nagyon okos");
                        choice = 0;
                    }

                }
                if (folyoso(ora, becsengo, difficulty, out becsengo) == 8)
                {
                    if (ora == "fizika")
                    {
                        if (Fizika(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag) == 1)
                        {
                            fizika = true;
                            choice = 0;
                            becsengo = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nem most lesz fizika, te nagyon okos");
                        choice = 0;
                    }

                }
                if (folyoso(ora, becsengo, difficulty, out becsengo) == 9)
                {
                    if (ora == "irodalom")
                    {
                        if (Irodalom(elegemvan, becsengo, ehseg, hugyholyag, gameover, out elegemvan, out becsengo, out ehseg, out hugyholyag) == 1)
                        {
                            irodalom = true;
                            choice = 0;
                            becsengo = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nem most lesz {ora}, te nagyon okos");
                        choice = 0;
                    }

                }

                if (folyoso(ora, becsengo, difficulty, out becsengo) == 11)
                    {
                        if (ebedlo(osztondij, choice, becsengo, elegemvan, ehseg, hugyholyag, ero, gameover, difficulty, Inventory, out osztondij, out choice, out becsengo, out gameover) == 1)
                        {
                            gameover = true;
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
                    if (altChoice == 0) Console.WriteLine("");
                    else
                    {
                        UseItem(Inventory, Inventory[altChoice - 1][0], ehseg, elegemvan, hugyholyag, ero, out ehseg, out elegemvan, out hugyholyag, out ero, out Inventory);
                    }
                }

                if (becsengo < 0 && ora == "matek")
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

            if (becsengo < 0 && ora == "matek")
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

        static int hatsoKapu(int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, int osztondij, bool gameover, Difficulty difficulty, List<List<dynamic>> Inventory, out int x1)
        {
            int choice = 0;
            while (choice < 1 || choice > 2)
            {
                Console.WriteLine("\n1 - Tovább a B épület felé (1 perc)\n2 - Vissza a folyosóra\n");
                Console.WriteLine("Elindultál, az A és a B épület között tengődsz");
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Helyszín: Utca");
                    statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, osztondij);

                    becsengo -= 1;

                    x1 = becsengo;
                    return 1;
                }

                else
                {
                    JedlikA(choice, becsengo, elegemvan, ehseg, hugyholyag, ero, Inventory, gameover, osztondij, difficulty, out choice, out becsengo, out elegemvan, out ehseg, out hugyholyag, out ero, out Inventory, out gameover, out osztondij);
                    becsengo -= 2;

                    x1 = becsengo;
                    return 0;
                }
            }
            x1 = becsengo;
            return 2;
        }

        static void automata(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, List<List<dynamic>> Inventory, bool gameover, int osztondij, Difficulty difficulty, out int x1, out int x2, out int x3, out int x4, out bool x5, out List<List<dynamic>> x6, out int x7)
        {
            int péz = osztondij;
            Console.WriteLine($"Egy turhás masina elé állsz, sok színes gomb...ezeket rejtik a bizonyos gombok:");
            Console.WriteLine("Az itt vett tárgyak rögtön felhasználásra kerülnek.");
            Console.WriteLine("1 - XXL-Túrórudi (+5 erő, -7 éhség)                      700f" +
                              "\n2 - Kávé (+10 erő -5 elegemvan)                        800f" +
                              "\n3 - Eldobható pelenka (egyszer behugyozhatsz)        3.500f" +
                              "\n4 - Táska megtekintése" +
                              "\n5 - Ellépsz az automatától");
            while (!gameover)
            {
                while (choice >= 0 || choice <= 5)
                {
                    if (choice == 0)
                    {
                        Console.WriteLine($"Egy turhás masina elé állsz, sok színes gomb...ezeket rejtik a bizonyos gombok:");
                        Console.WriteLine("Az itt vett tárgyak rögtön felhasználásra kerülnek.");
                        Console.WriteLine("1 - XXL-Túrórudi (+5 erő, -7 éhség)                      700f" +
                                          "\n2 - Kávé (+10 erő -5 elegemvan)                        800f" +
                                          "\n3 - Eldobható pelenka (egyszer behugyozhatsz)        3.500f" +
                                          "\n4 - Táska megtekintése" +
                                          "\n5 - Ellépsz az automatától");
                    }
                    choice = Input("Választás: ");
                    if (choice == 1)
                    {
                        if (péz >= 700)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nHungarikum, miért is ne...");
                            péz -= 700;
                            ero += 10;
                            hugyholyag += 10;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 700f");
                        }
                        choice = 0;
                    }
                    if (choice == 2)
                    {
                        if (péz >= 800)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nA produktivitásod nem függ össze a bevitt kávé mennyiségével.");
                            péz -= 800;
                            ero += 5;
                            ehseg -= 7;
                            elegemvan -= 5;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 800f");
                        }
                        choice = 0;
                    }
                    if (choice == 3)
                    {
                        if (péz > 3500)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nMindenkivel megesik, ne légy áldozat. Hordj Pelenkát!.");
                            péz -= 3500;
                            ItemSzam(Inventory, "Eldobható pelenka", out Inventory);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 3500f");
                        }
                        choice = 0;
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
                    if (choice == 5)
                    {
                        x1 = elegemvan;
                        x2 = ehseg;
                        x3 = hugyholyag;
                        x4 = ero;
                        x5 = gameover;
                        x6 = Inventory;
                        x7 = péz;
                        return;
                    }
                }
            }
                    x1 = elegemvan;
                    x2 = ehseg;
                    x3 = hugyholyag;
                    x4 = ero;
                    x5 = gameover;
                    x6 = Inventory;
                    x7 = péz;
        }


        static int ebedlo(int osztondij, int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, Difficulty difficulty,List<List<dynamic>> Inventory, out int x1, out int x2, out int x3, out bool x4)
        {
            becsengo -= 1;
            Console.Clear();
            choice = 0;
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine($"Helyszín: Ebédlő");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("\nAz ebédlő számos lehetőséget nyújt");
                Console.WriteLine("\n1 - Vegyél valami finomat (2 perc)\n2 - Lopd el valaki uzsipénzét (2 perc)\n");
                choice = Input("Választás: ");
            }
            if (choice == 1)
            {
                automata(choice, elegemvan, ehseg, hugyholyag, ero, Inventory, gameover, osztondij, difficulty, out elegemvan, out ehseg, out hugyholyag, out ero, out gameover, out Inventory, out osztondij);
            }
            if (choice == 2)
            {
                Random veres = new Random();
                int vereschance = veres.Next(0, 10/*difficulty.MegvernekEsely*/);

                if (vereschance == 5)
                {
                    Console.Clear();
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
                    osztondij += (int)(1000 * difficulty.Bonusz);
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

        static int bufe(int choice, int elegemvan, int ehseg, int hugyholyag, int osztondij, int ero, bool gameover, List<List<dynamic>> Inventory, out List<List<dynamic>> x6, out int x7)
        {
            int péz = osztondij;
            Console.WriteLine($"Magabiztosan odaállsz a büfé elé és a következő csodákat találod:");
            Console.WriteLine("Hatékonyan csökkentheted az éhséged és növelheted a vérhas esélyét.");
            Console.WriteLine("1 - Melegszendvics (-30 éhség)        4.500f" +
                              "\n2 - Energiaital (+10 erő)           3.000f" +
                              "\n3 - Nyalóka (-10 elegem van)        1.500f" +
                              "\n4 - Táska megtekintése" +
                              "\n5 - Kilépés az büféből");

                while (choice >= 0 || choice <= 5)
                {
                    if (choice == 0)
                    {
                        Console.WriteLine($"Magabiztosan odaállsz a büfé elé és a következő csodákat találod:");
                        Console.WriteLine("Hatékonyan csökkentheted az éhséged és növelheted a vérhas esélyét.");
                        Console.WriteLine("1 - Melegszendvics" +
                                          "\n2 - Energiaital" +
                                          "\n3 - Nyalóka" +
                                          "\n4 - Táska megtekintése" +
                                          "\n5 - Kilépés az büféből");
                    }
                    choice = Input("Választás: ");

                    if (choice == 1)
                    {
                        if (péz >= 4500)
                        {
                            Console.Clear();

                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);

                            Console.WriteLine("\nVettél egy magad sem tudod milyen feltéttel rendelkező szendvicset.");
                            péz -= 4500;
                            ItemSzam(Inventory, "Melegszendvics", out Inventory);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 4500f");
                        }
                        choice = 0;
                    }

                    if (choice == 2)
                    {

                        if (péz >= 3000)
                        {
                            Console.Clear();

                            Console.WriteLine($"Idő: ");
                            Console.WriteLine($"Elegem van: {elegemvan}");
                            Console.WriteLine($"Éhség: {ehseg}");
                            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                            Console.WriteLine($"Egyenleged: {péz}");
                            Console.WriteLine($"Erő: {ero}\n\n");
                            péz -= 3000;
                            Console.WriteLine("\n50 gramm cukorral nőtt a táskád tápértéke.");
                            ItemSzam(Inventory, "Energiaital", out Inventory);

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 3000f");
                        }
                        choice = 0;
                    }

                    if (choice == 3)
                    {

                        if (péz > 1500)
                        {
                            Console.Clear();

                            Console.WriteLine($"Idő: ");
                            Console.WriteLine($"Elegem van: {elegemvan}");
                            Console.WriteLine($"Éhség: {ehseg}");
                            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                            Console.WriteLine($"Egyenleged: {péz}");
                            Console.WriteLine($"Erő: {ero}\n\n");
                            péz -= 1500;
                            Console.WriteLine("\nVettél egy savanyú nyalókát.");
                            ItemSzam(Inventory, "Nyalóka", out Inventory);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 1500f");
                        }
                        choice = 0;

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
                    if (choice == 5)
                    {
                        x6 = Inventory;
                        x7 = péz;
                    return 1;
                    }
                }
            x6 = Inventory;
            x7 = péz;
            return 1;
        }

        static int folyoso(string ora, int becsengo, Difficulty difficulty, out int x2)
        {
            int choice = 0;
            while (choice < 1 || choice > 11)
            {
                Console.WriteLine($"\nA következő órád {ora}. Menj órára mielőtt becsengetnek ({becsengo} perc)\n");
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

        static int gepeszlepcso(int osztondij, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, Difficulty difficulty, out int x1, out int x2)
        {
            Random rand = new Random();

            becsengo -= 1;
            Console.Clear();

            double ajulas = rand.NextDouble();
            int choice = 0;
            if (ajulas <= difficulty.Esely)
            {
                    Console.WriteLine("A 41-es terem mellől áradó szagtól elájultál, ezért az orvosi szobába kerültél");
                    Console.WriteLine($"Helyszín: Orvosi szoba");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");
                    Console.WriteLine("\nAdtak rá jeget");
                    elegemvan += 30;
                    becsengo -= 5;
                    x1 = elegemvan;
                    x2 = becsengo;
                    return 1;
            }

            while (choice < 1 || choice > 2)
            {
                Console.WriteLine($"Helyszín: Gépészlépcső");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("\nNagyon büdös van, ennél még a likőrgyár mellett lakni is elviselhetőbb.");
                Console.WriteLine("\n1 - Angol óra terme (1 perc)\n2 - Vissza a folyosóra (1 perc)");

                choice = Input("Választás: ");
            }

            if (choice == 1)
            {
                x1 = elegemvan;
                x2 = becsengo;
                return 2;
            }

            if (choice == 2)
            {
                x1 = elegemvan;
                x2 = becsengo;
                return 3;
            }

            x1 = elegemvan;
            x2 = becsengo;
            return 0;

        }
        static int OrvosiSzoba(int elegemvan, int becsengo, out int x1, out int x2)
        {
            becsengo += 5;
            x1 = elegemvan;
            x2 = becsengo;
            return 1;
        }
        static int Mellekhelyiseg(int elegemvan, int becsengo, int hugyholyag, out int x1, out int x2, out int x3)
        {
            Console.WriteLine("Nem véletlen jöttél mosdóba.\nMit szeretnél tenni?");
            Console.WriteLine("1 - Hugyozni\n2 - Dohányozni");
            Console.Write("Választás: ");
            int choice = 0;
            while (choice < 1 || choice > 2)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Kiürítetted a kislányméretű hugyhólyagodat.");
                    elegemvan -= 5;
                    hugyholyag = 0;
                    choice = 0;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Hagytál magad után a fülkében egy kis cigiszagot, de nem baj, nem te cigizel iskolavécében egyedül.");
                    elegemvan -= 15;
                    choice = 0;

                }
            }
            x1 = elegemvan;
            x2 = becsengo;
            x3 = hugyholyag;
            return 1;
        }
        static int Matek(int elegemvan, int becsengo, int ehseg, int hugyholyag, bool gameover, out int x1, out int x2, out int x3, out int x4)
        {
            Console.WriteLine("Fazakas Miklós tanár úr 4 percet késett csak.\nÍrtál házit? Nem baj ha nem, úgyis csak dísznek adja fel.");
            Console.WriteLine("Jaj ne, elkövette a táblán a mai negyedik hibáját!\nMit teszel?");
            Console.WriteLine("1 - Szólsz Fazakasnak, hogy baj van\n2 - Kacagsz egy jót, miközben keresi, hol a hiba");
            Console.Write("Választás: ");
            int choice = 0;
            while (choice < 1 || choice > 2)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Ahelyett, hogy megnézte volna azt a hibát, amit mondtál, inkább kiosztott, mert megzavartad a gondolatmenetében.");
                    elegemvan += 10;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Megvolt az óra fénypontja, ennél jobb nem lesz.");
                    elegemvan -= 5;
                }
            }
            Console.WriteLine("Csongort megint Csengének hívta.");
            Console.WriteLine("Vége az órának.");
            elegemvan += 5;
            x1 = elegemvan;
            x2 = becsengo;
            x3 = ehseg;
            x4 = hugyholyag;
            return 1;
        }
        static int Angol(int elegemvan, int becsengo, int ehseg, int hugyholyag, bool gameover, out int x1, out int x2, out int x3, out int x4)
        {
            Random random = new Random();
            Console.WriteLine("NTF csak beesett 5 perc késéssel.\nNyugi, házi nem volt.");
            int doga = random.Next(1, 3);
            if (doga == 1)
            {
                Console.WriteLine("Gentlemen, I have goooood news!\n5 sentences, 5 seconds.");
                elegemvan += 5;
            }
            else if (doga == 2)
            {
                Console.WriteLine("Gentleman, unfortunately I have bad news...");
            }
            doga = 0;
            Console.WriteLine("Óra közben elgondolkoztál azon, hogy sok értelme nincs az órának, hiszen az emelt érettségis feladatokat végig hibátlanul oldod meg.");
            Console.WriteLine("Vége az órának.");
            elegemvan = 5;
            x1 = elegemvan;
            x2 = becsengo;
            x3 = ehseg;
            x4 = hugyholyag;
            return 1;
        }
        static int Tortenelem(int elegemvan, int becsengo, int ehseg, int hugyholyag, bool gameover, out int x1, out int x2, out int x3, out int x4)
        {
            Random random = new Random();
            Console.WriteLine("Nem is tudod mennyit késett Tozó, de valahogy nem is tud érdekelni.");
            int feleles = random.Next(1, 5);
            if (feleles == 1 || feleles == 4)
            {
                Console.WriteLine("Hááát, mára felelés volt kiadva...\nImádkozz, hogy ne te kerülj sorra.");
                if (feleles == 4)
                {
                    Console.WriteLine("Téged választott, neked annyi, ugyanis nem tanultál semmit.");
                    elegemvan += 10;
                }
                else
                {
                    Console.WriteLine("A mai a szerencsenapod, nem téged választott.");
                }
                elegemvan += 5;
            }
            else
            {
                Console.WriteLine("Ma nem felelünk.");
            }
            feleles = 0;
            Console.WriteLine("Ez egy nyugis óra, csak próbálj meg nem bealudni.");
            Console.WriteLine("Vége az órának.");
            elegemvan += 5;
            x1 = elegemvan;
            x2 = becsengo;
            x3 = ehseg;
            x4 = hugyholyag;
            return 1;
        }
        static int Fizika(int elegemvan, int becsengo, int ehseg, int hugyholyag, bool gameover, out int x1, out int x2, out int x3, out int x4)
        {
            Random random = new Random();
            Console.WriteLine("8 perc késés, nem korai egy kicsit tanárnő?");
            int feleles = random.Next(1, 3);
            if (feleles == 1)
            {
                Console.WriteLine("Na, gyorsan csukjatok be mindent...");
                Console.WriteLine("Mivel senki nem tud semmit, te is sorrakerültél (te se tudsz semmit, miért is tudnál).");
                elegemvan += 10;
            }
            else
            {
                Console.WriteLine("Ma nem felelünk.");
            }
            Console.WriteLine("Természetesen a kicsengő előtt 2 perccel még van idő még egy feladatra (mire előkeresi kicsengetnek).");
            Console.WriteLine("Vége az órának (3 perccel kicsengő után).");
            elegemvan += 15;
            becsengo += 3;
            x1 = elegemvan;
            x2 = becsengo;
            x3 = ehseg;
            x4 = hugyholyag;
            return 1;
        }
        static int Irodalom(int elegemvan, int becsengo, int ehseg, int hugyholyag, bool gameover, out int x1, out int x2, out int x3, out int x4)
        {
            Random random = new Random();
            Console.WriteLine("Detréné valahogy bevonszolta magát 5 perc késéssel a tanárija melletti terembe.");
            Console.WriteLine("Feltett neked egy szubjektív kérdést, te megválaszoltad, de szerinte nincs igazad.");
            elegemvan += 5;
            Console.WriteLine("Szavakba nem önthető, mennyire nem történik semmi ezen az órán, de figyelned kell, mert észreveszi, ha másfele jár az eszed.");
            Console.WriteLine("Vége az órának.");
            elegemvan += 30;
            x1 = elegemvan;
            x2 = becsengo;
            x3 = ehseg;
            x4 = hugyholyag;
            return 1;
        }
    }
}
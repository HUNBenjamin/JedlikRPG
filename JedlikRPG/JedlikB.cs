using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        static int JedlikBepulet(int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<List<dynamic>> Inventory, bool gameover, int osztondij, Difficulty difficulty, int choice, out int x1, out int x2, out int x3, out int x4, out int x5, out List<List<dynamic>> x6, out bool x7, out int x8, out Difficulty x9, out int x10)
        {
            int péz = osztondij;
            choice = 0;
            while (choice < 1 || choice > 4)
            {
                if (choice == 0) { 
                    Console.WriteLine("Merre tartasz?\n1 - Tesi\n2 - Pince\n3 - Padlás (meglepetés)\n4 - Vissza az A épületbe");
                    Console.Write("Választás: ");
                    choice = int.Parse(Console.ReadLine());
                }

                string ora = "tesi";

                if (choice == 1 && ora == "tesi")
                {
                    Console.Clear();
                    statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                    Tesi(elegemvan, ero, out elegemvan, out ero);
                    choice = 0;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Gratulálunk, túléltél egy napot.\n\r\n                   ██████████████                 \r\n               ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒████             \r\n             ██▒▒▒▒▒▒          ▒▒▒▒▒▒██           \r\n           ██▒▒▒▒      ░░░░░░      ▒▒▒▒██         \r\n         ██▒▒▒▒    ░░░░░░░░░░░░░░    ▒▒▒▒██       \r\n         ██▒▒    ░░░░██████████░░░░    ▒▒██       \r\n       ██▒▒▒▒  ░░░░██          ██░░░░  ▒▒▒▒██     \r\n       ██████  ░░██              ██░░    ▒▒██     \r\n     ██      ████  ████          ██░░░░  ▒▒██     \r\n   ██                  ██        ████░░██████     \r\n   ██                  ██      ██    ██    ████   \r\n     ██    ████      ██      ██                ██ \r\n       ████    ██████        ██                ██ \r\n                              ██             ██   \r\n                               ██        ████     \r\n                                 ████████         \r\n\r\n");
                    Environment.Exit(0);    

                }
                else if (choice == 2)
                {
                    Console.Clear();
                    statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                    Pince();
                    choice = 0;
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                    Padlas(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, osztondij, out elegemvan, out ehseg, out hugyholyag, out ero, out gameover, out Inventory, out osztondij);
                    choice = 0;
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                    becsengo -= 2;
                    hatsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, osztondij, gameover, difficulty, Inventory, out becsengo);
                    choice = 0;
                }
            }
            x1 = becsengo;
            x2 = elegemvan;
            x3 = ehseg;
            x4 = hugyholyag;
            x5 = ero;
            x6 = Inventory;
            x7 = gameover;
            x8 = osztondij;
            x9 = difficulty;
            x10 = choice;
            return 0;
        }


        static void Tesi(int elegemvan, int ero, out int x1, out int x2)
        {
            Random random = new Random();
            int adibaIttvan = random.Next(1, 3);
            int oltozoSzag = random.Next(1, 6);
            Console.WriteLine("Na irány öltözni, Németh Ádám már nagyon vár rád!");
            if (oltozoSzag == 3)
            {
                Console.WriteLine("Valaki megint összekeverte a zuhanyzót a vécével, ezért az így keletkezett szagtól eszméleted vesztetted.");
            }
            if (adibaIttvan == 1)
            {
                Console.WriteLine("Németh Ádám szokásos széles mosolyával fogad tesiórán.");
                Console.WriteLine("Megdícséred a cipőjét? Biztos értékelné.");
                Console.WriteLine("1 - Persze, legjobb tanár\n2 - Áh, az enyém úgyis jobb");
                Console.Write("Választás: ");
                int choice = 0;
                while (choice < 1 || choice > 2)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Megdícsérted a lépőit, és bár huszadjára van ugyanaz rajta , ugyanakkora mosolyt csaltál az arcára, mint első alkalommal.");
                        elegemvan -= 5;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Bár nem változtatott volna sokmindenen, azért alap lett volna megdícsérni a tanár úr csukáit.");
                    }
                }
                choice = 0;
                Console.WriteLine("Amíg a többiek rúgják a bőrt, nincs kedved megemelni a nehezet a szertárban? Nincs olyan, hogy valaki túl erős.");
                Console.WriteLine("1 - Beach body, here I come\n2 - Inkább átöltöznék");
                Console.Write("Választás: ");
                while (choice < 1 || choice > 2)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Jónéhányszor felemelted a súlyokat, és bár bűzlik tőle a kezed, attól még erősebb lettél.");
                        ero += 5;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Így előbb elmehettél öltözni, de most fél óráig csak nézel ki a fejedből, bármi világmegváltó gondolat nélkül.");
                    }
                }
            }
            else if (adibaIttvan == 2)
            {
                int choice = 0;
                Console.WriteLine("Hát Ádibá már megint Pécsett tanulgat, de ne aggódj, nem lesz helyettesítés. Addig majd fociznak a többiek.");
                Console.WriteLine("Amíg a többiek rúgják a bőrt, nincs kedved megemelni a nehezet a szertárban? Nincs olyan, hogy valaki túl erős.");
                Console.WriteLine("1 - Beach body, here I come\n2 - Inkább átöltöznék");
                Console.Write("Választás: ");
                while (choice < 1 || choice > 2)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Jónéhányszor felemelted a súlyokat, és bár bűzlik tőle a kezed, attól még erősebb lettél.");
                        ero += 5;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Így előbb elmehettél öltözni, de most fél óráig csak nézel ki a fejedből, bármi világmegváltó gondolat nélkül.");
                    }
                }
            }
            x1 = elegemvan;
            x2 = ero;
            return;
        }
        static void Pince()
        {
            Console.WriteLine("Pingpongozás közben a labda levándorolt a pincébe, de ez volt az utolsó labda, valakinek le kéne menni érte.");
        }
        static void Padlas(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<List<dynamic>> Inventory, int osztondij, out int x1, out int x2, out int x3, out int x4, out bool x5, out List<List<dynamic>> x6, out int x7)
        {

            int péz = osztondij;
            Console.WriteLine($"Egy dohos porfedte padlóra vetetted lábad, a sötetben felcsillan egy szempár és a következő árucikkeket ajánlja fel:");
            Console.WriteLine("Itt különböző tárgyakat tudsz venni, amelyek segíthetnek átjutni a napodon");
            Console.WriteLine("1 - Xanax (-60 elegem van)          15.000f" +
                              "\n2 - UTP kábel (+40 erő)           15.000f" +
                              "\n3 - Grántotta (-100 éhség)        15.000f" +
                              "\n4 - Táska megtekintése" +
                              "\n5 - Vissza a fénybe"); 
            while (!gameover)
            {
                while (choice >= 0 || choice <= 5)
                {
                    if (choice == 0)
                    {
                        Console.WriteLine($"Egy dohos porfedte padlóra vetetted lábad, a sötetben felcsillan egy szempár és a következő árucikkeket ajánlja fel:");
                        Console.WriteLine("Spéci áruk tárháza fogad...");
                        Console.WriteLine("1 - Xanax (-60 elegem van)          15.000f" +
                                          "\n2 - UTP kábel (+40 erő)           18.000f" +
                                          "\n3 - Grántotta (-100 éhség)        15.000f" +
                                          "\n4 - Táska megtekintése" +
                                          "\n5 - Vissza a fénybe");
                    }
                    choice = Input("Választás: ");
                    if (choice == 1)
                    {
                        if (péz >= 15000)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nModern problémák, modern megoldások.");
                            péz -= 15000;
                            ItemSzam(Inventory, "Xanax", out Inventory);
       
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 15000f");
                        }
                        choice = 0;
                    }
                    if (choice == 2)
                    {
                        if (péz >= 18000)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nFelfegyverkeztél egy UTP kábellel. A csillogó műanyag tekintélyt parancsolva csillog a zsebedben.");
                            péz -= 18000;
                            ItemSzam(Inventory, "UTP kábel", out Inventory);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 18000f");
                        }
                        choice = 0;
                    }
                    if (choice == 3)
                    {
                        if (péz > 15000)
                        {
                            Console.Clear();
                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);
                            Console.WriteLine("\nGrántottás vagy.");
                            péz -= 15000;
                            ItemSzam(Inventory, "Grántotta", out Inventory);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 15000f");
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
    }
}

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
            Console.WriteLine("Csak nem a B épületben lesz órád?\nMerre tartasz?\n1 - Tesi\n2 - Adatbázis\n3 - Digitális technika\n4 - Pince\n5 - Padlás (meglepetés)\n6 - Vissza az A épületbe");
            Console.Write("Választás: ");
            choice = int.Parse(Console.ReadLine());
            while (choice <= 1 && choice >= 6)
            {
                if (choice == 1)
                {
                    Tesi(elegemvan, ero, out elegemvan, out ero);
                }
                //else if (choice == 2)
                //{
                //    AdatB(elegemvan,gameover,out elegemvan,out gameover);
                //}
                //else if (choice == 3)
                //{
                //    DigTech(elegemvan,gameover, out elegemvan, out gameover);
                //}
                else if (choice == 4)
                {
                    Pince();
                }
                else if (choice == 5)
                {
                    Padlas(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, osztondij, out elegemvan, out ehseg, out hugyholyag, out ero, out gameover, out Inventory, out osztondij);
                }
                else if (choice == 6)
                {
                    becsengo -= 2;
                    hatsoKapu(becsengo, elegemvan, ehseg, hugyholyag, ero, out becsengo);
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
                int choice = int.Parse(Console.ReadLine());
                while (choice != 1 || choice != 2)
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
            }
            else if (adibaIttvan == 2)
            {
                Console.WriteLine("Hát Ádibá már megint Pécsett tanulgat, de ne aggódj, nem lesz helyettesítés. Addig majd fociznak a többiek.");
            }
            Console.WriteLine("Amíg a többiek rúgják a bőrt, nincs kedved megemelni a nehezet a szertárban? Nincs olyan, hogy valaki túl erős.");
            Console.WriteLine("1 - Beach body, here I come\n2 - Inkább átöltöznék");
            Console.Write("Választás: ");
            int choice2 = int.Parse(Console.ReadLine());
            choice2 = int.Parse(Console.ReadLine());
            while (choice2 != 1 || choice2 != 2)
            {
                choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    Console.WriteLine("Jónéhányszor felemelted a súlyokat, és bár bűzlik tőle a kezed, attól még erősebb lettél.");
                    ero += 5;
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Így előbb elmehettél öltözni, de most fél óráig csak nézel ki a fejedből, bármi világmegváltó gondolat nélkül.");
                }
            }
            x1 = elegemvan;
            x2 = ero;
        }
        //static void AdatB(int elegemvan, bool gameover, out int x1,out bool x2)
        //{
        //    Console.WriteLine("Becsöngettek, úgyhogy már csak 15 perc van a tanárnő érkezéséig.");
        //    Console.WriteLine("Mit teszel, hogy elüsd az időt?");
        //    Console.WriteLine("1 - Orosz desszert recepteket nézel a YouTube-on\n2 - Merge Fruit");
        //    Console.Write("Választás: ");
        //    int choice = int.Parse(Console.ReadLine());
        //    while (choice != 1 || choice != 2)
        //    {
        //        choice = int.Parse(Console.ReadLine());
        //        if (choice == 1)
        //        {
        //            Console.WriteLine("Rákattintottál a \"Csak 3 hozzávaló, 15 perc és kész a finom\" videóra, és csorgattad rá a nyáladat, tudván, hogy úgyse fogod sohase elkészíteni.");
        //            elegemvan -= 5;
        //        }
        //        else if (choice == 2)
        //        {
        //            Console.WriteLine("Új rekordot állítottál volna fel a játékban, de túl sok volt egymáson a citrom.");
        //        }
        //    }
        //    Console.WriteLine("Striderné csak megérkezett, és munkához is lát.\nScreenTask működik, úgyhogy talán nem maradsz le, már ha persze csinálsz valamit.\nAz egyetlen feladatod csak kussban végigülni az órát, és néha csinálhatnád az órai munkát is.");
        //    elegemvan += 5;
        //    if (elegemvan < 100)
        //    {
        //        gameover = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("A könnyebik órákhoz tartozott, de akkor is túlélted.");
        //    }
        //    x1 = elegemvan;
        //    x2 = gameover;
        //}
        //static void DigTech(int elegemvan,bool gameover, out int x1, out bool x2)
        //{
        //    Console.WriteLine("Ez az óra csak fél órát vesz igénybe, mert csak annyi marad, mire bekapcsolnak a gépek a B7-ben.");
        //    Console.WriteLine("Próbálj meg lenyugodni, ez az óra sokkal többnek érződik.");
        //    Console.WriteLine("Amíg Szűcs Gábor magyarázza az általa kitalált tananyagot, mit teszel?");
        //    Console.WriteLine("1 - Megpróbálsz figyelni, és a füzetbe is bekeríted a vetített anyagot\n2 - Emojikat spammelsz a meetben\n3 - Nyomot hagysz a Jamboardon");
        //    Console.Write("Választás: ");
        //    int choice = int.Parse(Console.ReadLine());
        //    while (choice <= 1 && choice >= 5)
        //    {
        //        if (choice == 1)
        //        {
        //            Console.WriteLine("Két oldal be is telt a füzetedben. Lehet, hogy minimálbérért fogsz dolgozni az elkövetkezendő harminc évben, de legalább tudod, hogy a konjuktív szabályos alak a maxtermek és kapcsolatából áll.");
        //            elegemvan += 10;
        //        }
        //        else if (choice == 2)
        //        {
        //            Console.WriteLine("Beállítottad a színesbőrű emojikat, és 5 percen keresztül likeokat spammeltél. Sokkal jobban érzed magad.");
        //            elegemvan -= 5;
        //        }
        //        else if (choice == 3)
        //        {
        //            Console.WriteLine("Létrehoztál egy Jamboardot, és beillesztetted a slozaik.jpg-t.");
        //            elegemvan -= 5;
        //        }
        //    }
        //    if (elegemvan < 100)
        //    {
        //        Console.WriteLine("Sikeresen túlélted ezt az órát, minden tiszteletem.");
        //        gameover = true;
        //    }
        //    x1 = elegemvan;
        //    x2 = gameover;
        //}
        static void Pince()
        {
            Console.WriteLine("Pingpongozás közben a labda levándorolt a pincébe, de ez volt az utolsó labda, valakinek le kéne menni érte.");
            //Console.WriteLine("A pincében szembetalálod magad egy nether portált megszégyenítő kapuval, a mellette lévő tábla szerint ha átmész rajta, az iskola egy véletlenszerű pontján fogsz kikötni.");
            //Console.WriteLine("Igénybe veszed a kaput? A használata ingyenes.");
            //Console.WriteLine("1 - Igénybe veszem\n2 - Talán majd máskor");
            //Console.Write("Választás: ");
            //int choice = int.Parse(Console.ReadLine());
            //while (choice != 1 || choice != 2)
            //{
            //    choice = int.Parse(Console.ReadLine());
            //    if (choice == 1)
            //    {
            //        Console.WriteLine("Na hol kötöttél ki? Mi se tudjuk...");
            //        // random shortcut
            //    }
            //    else if (choice == 2)
            //    {
            //        Console.WriteLine("Én se bíztam volna a kapuban, gondolj bele, milyen lett volna, ha a vécébe kerültél volna, mikor Tüncike épp pókhálózza a kéztörlő dobozokat...");
            //    }
            //}
            // oriaspatkany
        }
        static void Padlas(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<List<dynamic>> Inventory, int osztondij, out int x1, out int x2, out int x3, out int x4, out bool x5, out List<List<dynamic>> x6, out int x7)
        {

            int péz = osztondij;
            Console.WriteLine($"Egy dohos porfedte padlóra vetetted lábad, a sötetben felcsillan egy szempár és a következő árucikkeket ajánlja fel:");
            Console.WriteLine("Itt különböző tárgyakat tudsz venni, amelyek segíthetnek átjutni a napodon");
            Console.WriteLine("1 - Xanax (-60 elegem van)          15.000f" +
                              "\n2 - UTP kábel (+40 erő)           18.000f" +
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
                            Inventory.Add(new List<dynamic> { "Xanax", 1 });
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
                            Inventory.Add(new List<dynamic> { "UTP kábel", 1 });
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
                            Inventory.Add(new List<dynamic> { "Grántotta", 1 });
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 16000f");
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

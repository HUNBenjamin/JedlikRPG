using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class JedlikB
    {
        static void JedlikBepulet()
        {
            Console.WriteLine("Csak nem a B épületben lesz órád?\nMerre tartasz?\n1 - Tesi\n2 - Adatbázis\n3 - Digitális technika\n4 - Pince\n5 - Padlás (meglepetés)");
            Console.Write("Választás: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice <= 1 && choice >= 5)
            {
                if (choice == 1)
                {
                    Tesi();
                }
                else if (choice == 2)
                {
                    AdatB();
                }
                else if (choice == 3)
                {
                    DigTech();
                }
                else if (choice == 4)
                {
                    Pince();
                }
                else if (choice == 5)
                {
                    Padlas();
                }
            }
        }
        static void Tesi()
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
                        // elegemvan -= 5
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
                    // ero += 5
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("Így előbb elmehettél öltözni, de most fél óráig csak nézel ki a fejedből, bármi világmegváltó gondolat nélkül.");
                }
            }
        }
        static void AdatB()
        {
            Console.WriteLine("Becsöngettek, úgyhogy már csak 15 perc van a tanárnő érkezéséig.");
            Console.WriteLine("Mit teszel, hogy elüsd az időt?");
            Console.WriteLine("1 - Orosz desszert recepteket nézel a YouTube-on\n2 - Merge Fruit");
            Console.Write("Választás: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 || choice != 2)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Rákattintottál a \"Csak 3 hozzávaló, 15 perc és kész a finom\" videóra, és csorgattad rá a nyáladat, tudván, hogy úgyse fogod sohase elkészíteni.");
                    // elegemvan -= 5
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Új rekordot állítottál volna fel a játékban, de túl sok volt egymáson a citrom.");
                }
            }
            Console.WriteLine("Striderné csak megérkezett, és munkához is lát.\nScreenTask működik, úgyhogy talán nem maradsz le, már ha persze csinálsz valamit.\nAz egyetlen feladatod csak kussban végigülni az órát, és néha csinálhatnád az órai munkát is.");
            // elegemvan += 5
            // if elegemvan < 100
            Console.WriteLine("A könnyebik órákhoz tartozott, de akkor is túlélted.");
        }
        static void DigTech()
        {
            Console.WriteLine("Ez az óra csak fél órát vesz igénybe, mert csak annyi marad, mire bekapcsolnak a gépek a B7-ben.");
            Console.WriteLine("Próbálj meg lenyugodni, ez az óra sokkal többnek érződik.");
            Console.WriteLine("Amíg Szűcs Gábor magyarázza az általa kitalált tananyagot, mit teszel?");
            Console.WriteLine("1 - Megpróbálsz figyelni, és a füzetbe is bekeríted a vetített anyagot\n2 - Emojikat spammelsz a meetben\n3 - Nyomot hagysz a Jamboardon");
            Console.Write("Választás: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice <= 1 && choice >= 5)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Két oldal be is telt a füzetedben. Lehet, hogy minimálbérért fogsz dolgozni az elkövetkezendő harminc évben, de legalább tudod, hogy a konjuktív szabályos alak a maxtermek és kapcsolatából áll.");
                    // elegemvan += 10
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Beállítottad a színesbőrű emojikat, és 5 percen keresztül likeokat spammeltél. Sokkal jobban érzed magad.");
                    // elegemvan -= 5
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Létrehoztál egy Jamboardot, és beillesztetted a slozaik.jpg-t.");
                    // elegemvan -= 5
                }
            }
            // if elegemvan < 100
            Console.WriteLine("Sikeresen túlélted ezt az órát, minden tiszteletem.");
        }
        static void Pince()
        {
            Console.WriteLine("Pingpongozás közben a labda levándorolt a pincébe, de ez volt az utolsó labda, valakinek le kéne menni érte.");
            Console.WriteLine("A pincében szembetalálod magad egy nether portált megszégyenítő kapuval, a mellette lévő tábla szerint ha átmész rajta, az iskola egy véletlenszerű pontján fogsz kikötni.");
            Console.WriteLine("Igénybe veszed a kaput? A használata ingyenes.");
            Console.WriteLine("1 - Igénybe veszem\n2 - Talán majd máskor");
            Console.Write("Választás: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 || choice != 2)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Na hol kötöttél ki? Mi se tudjuk...");
                    // random shortcut
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Én se bíztam volna a kapuban, gondolj bele, milyen lett volna, ha a vécébe kerültél volna, mikor Tüncike épp pókhálózza a kéztörlő dobozokat...");
                }
            }
            // oriaspatkany
        }
        static void Padlas()
        {
            Console.WriteLine("Elnézted a termet, vagy tudod hová jöttél? Üdv a Black Marketen!");
            Console.WriteLine("Mivel szolgálhatunk?");
            // blackmarket todo
        }
    }
}

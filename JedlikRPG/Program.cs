using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Nyomj egy entert a kezdéshez ");
            ConsoleKeyInfo nehezseg = Console.ReadKey();
            Nehezseg(nehezseg);
          
            int alvas = 6;
            int busz = 30;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyag = 80;
            int ero = 0;

            bool buszjegy = false;

            bool gameover = false;
            List<string> Inventory = new List<string>();


            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Helyszín: Otthon ");
            Console.WriteLine($"Idő: ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");


            Console.WriteLine($"Egy újabb napra ébredtél szánalmas életedben {alvas} óra alvással. Ma is be kell menned a Jedlik Ányos Gépipari és Informatikai Technikumba.");
            Console.WriteLine($"Készülj el, a busz {busz} perc múlva érkezik");
            Console.WriteLine("");

            Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)\n4 - Táska megtekintése");
            int choice = 0;



            while(gameover != true)
            {
                if (reggel(choice, busz, elegemvan, ehseg, hugyholyag, ero, Inventory, gameover, buszjegy, out choice, out busz, out elegemvan, out ehseg, out hugyholyag, out ero, out Inventory, out gameover, out buszjegy) == 1)
                {
                    gameover = true;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
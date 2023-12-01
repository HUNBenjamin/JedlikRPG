using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JedlikRPG
{
    public static class Item
    {

        public static string[] Names = { "Taknyos zsebkendő", "Kaja", "Alkohol", "Pelenka" };
        public static string[] Descriptions = { "Taknyos", "Egyszerű pékáru ami csökkenti az éhséget.", "A subidubi segíti általános jókedvünk megőrzését", "A nap folyamán nem kell hugyoznod" };
        public static int[] Elegemvan = { 0, 0, -20, 0 };
        public static int[] Hugyholyag = { 0, 0, 25, 0 };
        public static int[] Erő = { 0, 5, 5, 0 };
    }
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   __     ______     _____     __         __     __  __     ______     ______   ______    \r\n  /\\ \\   /\\  ___\\   /\\  __-.  /\\ \\       /\\ \\   /\\ \\/ /    /\\  == \\   /\\  == \\ /\\  ___\\   \r\n _\\_\\ \\  \\ \\  __\\   \\ \\ \\/\\ \\ \\ \\ \\____  \\ \\ \\  \\ \\  _\"-.  \\ \\  __<   \\ \\  _-/ \\ \\ \\__ \\  \r\n/\\_____\\  \\ \\_____\\  \\ \\____-  \\ \\_____\\  \\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\    \\ \\_____\\ \r\n\\/_____/   \\/_____/   \\/____/   \\/_____/   \\/_/   \\/_/\\/_/   \\/_/ /_/   \\/_/     \\/_____/ \r\n");
            Console.WriteLine("Nyomj egy entert a kezdéshez ");
            ConsoleKeyInfo nehezseg = Console.ReadKey();
            Nehezseg(nehezseg);
          
            int alvas = 6;
            int busz = 30;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyag = 80;
            int ero = 0;
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
                while (choice < 1 || choice > 3)
                {
                    choice = Input("Választás: ");
                    if (choice == 1)
                    {
                        hugyholyag = 0;
                        busz -= 2;
                        vizeles(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                        choice = 0;
                    }
                    if (choice == 2)
                    {
                        ehseg -= 25;
                        busz -= 15;
                        reggelizes(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                        choice = 0;
                    }
                    if (choice == 3)
                    {
                        busz -= 3;
                        buszSeta(choice, busz, elegemvan, ehseg, hugyholyag, ero);
                        choice = 0;
                    }
                    if (choice == 4)
                    {
                        Console.WriteLine("Kinyitva a táskád ezt találod:");
                        foreach (string Name in Item.Names)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(Name);

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
            }
        }
    }
}
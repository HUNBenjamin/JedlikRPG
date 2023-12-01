
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        string command;
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
            bool gameover = false;


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
            Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)");
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
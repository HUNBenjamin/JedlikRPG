
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
            Console.WriteLine("   __     ______     _____     __         __     __  __     ______     ______   ______    \r\n  /\\ \\   /\\  ___\\   /\\  __-.  /\\ \\       /\\ \\   /\\ \\/ /    /\\  == \\   /\\  == \\ /\\  ___\\   \r\n _\\_\\ \\  \\ \\  __\\   \\ \\ \\/\\ \\ \\ \\ \\____  \\ \\ \\  \\ \\  _\"-.  \\ \\  __<   \\ \\  _-/ \\ \\ \\__ \\  \r\n/\\_____\\  \\ \\_____\\  \\ \\____-  \\ \\_____\\  \\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\    \\ \\_____\\ \r\n\\/_____/   \\/_____/   \\/____/   \\/_____/   \\/_/   \\/_/\\/_/   \\/_/ /_/   \\/_/     \\/_____/ \r\n");
            Console.Write("\nÍrd be a karaktered nevét: ");

            string név = Console.ReadLine();

            Console.WriteLine("A karaktered neve: " + név);
=======
            int alvas = 6;
            int busz = 30;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyag = 80;
            int ero = 0;
            bool gameover = false;

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
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                        Console.WriteLine("\nElmentél vizelni egy jót");
                        hugyholyag = 0;
                        busz -= 2;
                        Console.WriteLine($"Készülj el, a busz {busz} perc múlva érkezik");
                        Console.WriteLine("");
                        Console.WriteLine("2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)");
                        choice = 0;
                    }
                    if (choice == 2)
                    {
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                        Console.WriteLine("\nMég életedben nem ettél finomat. Bár a házi koszt nem csillapítja az elégedetlenséged, melyet iskolád okoz");
                        ehseg -= 25;
                        busz -= 15;
                        Console.WriteLine($"Készülj el, a busz {busz} perc múlva érkezik");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elmész a buszmegállóba (3 perc)");
                        choice = 0;
                    }
                    if (choice == 3)
                    {
                        Console.Clear();

                        Console.WriteLine($"Idő: ");
                        Console.WriteLine($"Elegem van: {elegemvan}");
                        Console.WriteLine($"Éhség: {ehseg}");
                        Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                        Console.WriteLine($"Erő: {ero}\n\n");

                        busz -= 3;
                        Console.WriteLine($"Kisétáltál a buszmegállóba, a járatod {busz} perc múlva érkezik");
                    }
                    if (busz < 0)
                    {
                        Console.WriteLine("\nSajnos lekésted a buszt.");
                        Console.WriteLine("Nem sikerült beérned az iskolába, így túl sok hiányzás miatt kirúgtak.");
                        gameover = true;
                        Console.WriteLine("A játéknak vége\n");
                        break;
                    }
                }
            }
            
        }

    }
}
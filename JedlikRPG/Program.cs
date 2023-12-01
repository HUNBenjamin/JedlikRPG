﻿using System;
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


            int alvas = 8;
            int busz = 30;
            int osztondij = 60000;
            double szorzo = 0.1;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyag = 80;
            int ero = 0;
            bool gameover = false;
            List<string> Inventory = new List<string>();
            
            Console.WriteLine("Könnyű - 1");
            Console.WriteLine("Közepes - 2");
            Console.WriteLine("Nehéz - 3");
            Console.WriteLine("Extrém - 4");
            Console.Write("Add meg a nehézségi szintet: ");
            int nehezsegiSzint = Convert.ToInt32(Console.ReadLine());
            if (nehezsegiSzint == 1)
            {
                Nehezseg(8, 30, 60000, 0.1);
            }
            else if (nehezsegiSzint == 2)
            {
                Nehezseg(6, 20, 42000, 0.25);
            }
            else if (nehezsegiSzint == 2)
            {
                Nehezseg(3, 7, 25000, 0.4);
            }
            else if (nehezsegiSzint == 2)
            {
                Nehezseg(0, 3, 8000, 0.6);
            }



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
                        foreach (string item in Inventory)
                        {
                            Console.WriteLine(item);
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
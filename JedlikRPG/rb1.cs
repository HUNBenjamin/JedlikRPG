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
        static void rb1()
        {
            
            
        }
        static int Input(string text)
        {
            int value;
            do
            {
                Console.Write(text);
            }
            while (!int.TryParse(Console.ReadLine(), out value));
            return value;
        }

        static int otthon(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover)
        {
            while (choice < 1 || choice > 3)
            {
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    Console.Clear();

                    Console.WriteLine($"Helyszín: Otthon ");
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
                    return 0;
                }
                if (choice == 2)
                {
                    Console.Clear();

                    Console.WriteLine($"Helyszín: Otthon ");
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
                    return 0;
                }
                if (choice == 3)
                {
                    Console.Clear();

                    Console.WriteLine($"Helyszín: Otthon ");
                    Console.WriteLine($"Idő: ");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");

                    busz -= 3;
                    Console.WriteLine($"Kisétáltál a buszmegállóba, a járatod {busz} perc múlva érkezik");
                    return 1;
                }
                if (busz < 0)
                {
                    Console.WriteLine("\nSajnos lekésted a buszt.");
                    Console.WriteLine("Nem sikerült beérned az iskolába, így túl sok hiányzás miatt kirúgtak.");
                    gameover = true;
                    Console.WriteLine("A játéknak vége\n");
                    return 2;
                }
                return 2;
                

            }
            return 0;

        }

        static void buszmegallo(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover)
        {
            choice = 0;
            while (choice < 1 || choice > 2)
            {
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    Console.Clear();

                    Console.WriteLine($"Helyszín: Otthon ");
                    Console.WriteLine($"Idő: ");
                    Console.WriteLine($"Elegem van: {elegemvan}");
                    Console.WriteLine($"Éhség: {ehseg}");
                    Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                    Console.WriteLine($"Erő: {ero}\n\n");
                }         
        }
        }
    }
}

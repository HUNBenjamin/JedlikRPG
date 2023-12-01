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

        static void vizeles(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero)
        {
            Console.Clear();

            Console.WriteLine($"Helyszín: Otthon ");
            Console.WriteLine($"Idő: ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");
            Console.WriteLine("\nElmentél vizelni egy jót");
            Console.WriteLine($"Készülj el, a busz {busz} perc múlva érkezik");
            Console.WriteLine("");

            Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)\n4 - Táska megtekintése");
        }

        static void reggelizes(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero)
        {
            Console.Clear();

            Console.WriteLine($"Helyszín: Otthon ");
            Console.WriteLine($"Idő: ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");
            Console.WriteLine("\nMég életedben nem ettél finomat. Bár a házi koszt nem csillapítja az elégedetlenséged, melyet iskolád okoz.");
            Console.WriteLine($"Készülj el, a busz {busz} perc múlva érkezik");
            Console.WriteLine("");

            Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)\n4 - Táska megtekintése");
        }

        static void buszSeta(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero)
        {
            Console.Clear();

            Console.WriteLine($"Helyszín: Buszmegálló");
            Console.WriteLine($"Idő: ");
            Console.WriteLine($"Elegem van: {elegemvan}");
            Console.WriteLine($"Éhség: {ehseg}");
            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
            Console.WriteLine($"Erő: {ero}\n\n");


            Console.WriteLine($"Kisétáltál a buszmegállóba, a járatod {busz} perc múlva érkezik");
        }

        static void jegyvetel(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero)
        {
            choice = 0;
            {
                Console.Clear();

                Console.WriteLine($"Helyszín: Buszmegálló ");
                Console.WriteLine($"Idő: ");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");

                Console.WriteLine("Vettél egy menetjegyet, ezzel jogosulttá váltál az utazásra.");
            }
        }

        static void buszraszallas(int choice, int busz, int elegemvan, int ehseg, int hugyholyag, int ero)
        {

                Console.Clear();

                Console.WriteLine($"Helyszín: Busz ");
                Console.WriteLine($"Idő: ");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Erő: {ero}\n\n");
                Console.WriteLine("Megérkezett a járat.\nA városközpont felé tartasz és épp azon elmélkedsz hol romlott el minden.");

        }
    }
}


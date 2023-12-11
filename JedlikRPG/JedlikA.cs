using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void JedlikA()
        {


        }

        static int JedlikA(int choice, int becsengo, int elegemvan, int ehseg, int hugyholyag, int ero, List<string> Inventory, bool gameover, bool buszjegy, out int x1, out int x2, out int x3, out int x4, out int x5, out int x6, out List<string> x7, out bool x8, out bool x9)
        {
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine($"Úgy tűnik az első órád matek. Menj órára mielőtt becsengetnek ({becsengo} perc)");
                Console.WriteLine("Számos lehetőség van a továbbhaladásra. Annyi éve ide jársz, mégis egyfolytában eltévedsz. Merre tovább?\n");
                choice = Input("Választás: ");
                if (choice == 1)
                {
                    elsoKapu();
                }
                if (choice == 2)
                {
                    hatsoKapu();
                }
                if (choice == 3)
                {
                    ebedlo();
                }
                if (choice == 4)
                {
                    gepeszLepcso();
                }
                if (choice == 5)
                {
                    folyoso();
                }

            }
        }
    }
}
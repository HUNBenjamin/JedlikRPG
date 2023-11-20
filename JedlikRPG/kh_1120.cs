using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class Program
    {
        static void kh_1120()
        {
            int konnyu = 1;
            int kozepes = 2;
            int nehez = 3;
            int extrem = 4;
        }
        static int Nehezseg(int nehezsegiSzint, out int stats)
        {
            int alvasido = 0;
            int reggelido = 0;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyagAllapot = 80;
            int ero = 0;
            int osztondij = 0;
            nehezsegiSzint = Console.ReadLine("Add meg a nehézségi szintet: ");
            if (nehezsegiSzint == konnyu)
            {
                alvasido = 480;
                reggelido = 30;
                osztondij = 60000;
            }
        }
    }
}

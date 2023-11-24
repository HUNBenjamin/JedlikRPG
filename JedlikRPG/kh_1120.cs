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
            Console.WriteLine("Add meg a nehézségi szintet: ");
            Console.WriteLine("Könnyű - 1");
            Console.WriteLine("Közepes - 2");
            Console.WriteLine("Nehéz - 3");
            Console.WriteLine("Extrém - 4");
            int nehezseg = Convert.ToInt32(Console.ReadLine());
            Nehezseg(nehezseg);
        }
        static double Nehezseg(int nehezsegiSzint)
        {
            int konnyu = 1;
            int kozepes = 2;
            int nehez = 3;
            int extrem = 4;
            int elegemvan = 0;
            int ehseg = 50;
            int hugyholyagAllapot = 80;
            int ero = 0;
            int alvasido = 0;
            int reggelido = 0;
            int osztondij = 0;
            double szorzo = 0;
            Console.WriteLine("Könnyű - 1");
            Console.WriteLine("Közepes - 2");
            Console.WriteLine("Nehéz - 3");
            Console.WriteLine("Extrém - 4");
            Console.Write("Add meg a nehézségi szintet: ");
            nehezsegiSzint = Convert.ToInt32(Console.ReadLine());
            if (nehezsegiSzint == konnyu)
            {
                alvasido = 480;
                reggelido = 30;
                osztondij = 60000;
                szorzo = 0.1;
                Console.WriteLine("Könnyű nehézség.");
            }
            else if (nehezsegiSzint == kozepes)
            {
                alvasido = 360;
                reggelido = 20;
                osztondij = 42000;
                szorzo = 0.25;
                Console.WriteLine("Közepes nehézség.");
            }
            else if (nehezsegiSzint == nehez)
            {
                alvasido = 180;
                reggelido = 7;
                osztondij = 25000;
                szorzo = 0.4;
                Console.WriteLine("Nehéz nehézség.");
            }
            else if (nehezsegiSzint == extrem)
            {
                reggelido = 3;
                osztondij = 8000;
                szorzo = 0.6;
                Console.WriteLine("Extrém nehézség.");
            }
            return alvasido;
            return reggelido;
            return osztondij;
            return szorzo;
            return elegemvan;
            return ehseg;
            return hugyholyagAllapot;
            return ero;
        }
    }
}

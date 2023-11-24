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
            Console.Write("Nyomj egy entert a kezdéshez ");
            ConsoleKeyInfo nehezseg = Console.ReadKey();
            Console.Clear();
            Nehezseg(nehezseg);
        }
        static double Nehezseg(ConsoleKeyInfo keyInfo)
        {
            int alvasido = 0;
            int reggelido = 0;
            int osztondij = 0;
            double szorzo = 0;
            Console.WriteLine("Könnyű - 1");
            Console.WriteLine("Közepes - 2");
            Console.WriteLine("Nehéz - 3");
            Console.WriteLine("Extrém - 4");
            Console.Write("Add meg a nehézségi szintet: ");
            int nehezsegiSzint = Convert.ToInt32(Console.ReadLine());
            if (nehezsegiSzint == 1)
            {
                alvasido = 480;
                reggelido = 30;
                osztondij = 60000;
                szorzo = 0.1;
                Console.WriteLine("Könnyű nehézség.");
            }
            else if (nehezsegiSzint == 2)
            {
                alvasido = 360;
                reggelido = 20;
                osztondij = 42000;
                szorzo = 0.25;
                Console.WriteLine("Közepes nehézség.");
            }
            else if (nehezsegiSzint == 3)
            {
                alvasido = 180;
                reggelido = 7;
                osztondij = 25000;
                szorzo = 0.4;
                Console.WriteLine("Nehéz nehézség.");
            }
            else if (nehezsegiSzint == 4)
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
        }
    }
}

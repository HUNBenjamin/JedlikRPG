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

        }
        static bool Between(int a, int b, int number)
        {
            return (a <= number && number <= b);
        }
        static double Nehezseg(ConsoleKeyInfo keyInfo)
        {
            int alvas = 0;
            int busz = 0;
            int osztondij = 0;
            double szorzo = 0;
            Console.WriteLine("Könnyű - 1");
            Console.WriteLine("Közepes - 2");
            Console.WriteLine("Nehéz - 3");
            Console.WriteLine("Extrém - 4");
            Console.Write("Add meg a nehézségi szintet: ");
            int nehezsegiSzint = Convert.ToInt32(Console.ReadLine());
            while (!Between(1, 4, nehezsegiSzint))
            {
                Console.WriteLine("Na akkor most mégegyszer");
                Console.Write("Add meg a nehézségi szintet: ");
                nehezsegiSzint = Convert.ToInt32(Console.ReadLine());
            }
            if (nehezsegiSzint == 1)
            {
                alvas = 480;
                busz = 30;
                osztondij = 60000;
                szorzo = 0.1;
                Console.WriteLine("Könnyű nehézség.");
            }
            else if (nehezsegiSzint == 2)
            {
                alvas = 360;
                busz = 20;
                osztondij = 42000;
                szorzo = 0.25;
                Console.WriteLine("Közepes nehézség.");
            }
            else if (nehezsegiSzint == 3)
            {
                alvas = 180;
                busz = 7;
                osztondij = 25000;
                szorzo = 0.4;
                Console.WriteLine("Nehéz nehézség.");
            }
            else if (nehezsegiSzint == 4)
            {
                busz = 3;
                osztondij = 8000;
                szorzo = 0.6;
                Console.WriteLine("Extrém nehézség.");
            }
            return alvas;
            return busz;
            return osztondij;
            return szorzo;
        }
    }
}

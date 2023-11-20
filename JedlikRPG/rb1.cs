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
            Console.WriteLine($"Egy újabb napra ébredtél szánalmas életedben {} óra alvással. Ma is be kell menned a Jedlik Ányos Gépipari és Informatikai Technikumba.");
            Console.WriteLine($"Készülj el, a busz {} perc múlva érkezik");
            Console.WriteLine("");
            Console.WriteLine("1 - Elmész vizelni (2 perc)\n2 - Elfogyasztod a reggelid (15 perc)\n3 - Elmész a buszmegállóba (3 perc)");
            int choice = 0;
            while (choice < 1 || choice > 3)
            {
                Console.ReadLine("Következő lépésed: ");
            }
            
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
    }
}

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
    }
}

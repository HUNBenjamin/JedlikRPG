using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    internal partial class JedlikB
    {
         static void JedlikBepulet()
         {
             Console.WriteLine("Csak nem a B épületben lesz órád?\nMerre tartasz?\nÖltöző - 1\nPince - 2\nPadlás (black market) - 3");
             Console.Write("Választás: ");
             int choice = int.Parse(Console.ReadLine());
             if (choice == 1)
             {
                 Oltozo();
             }
             else if (choice == 2)
             {
                 Pince();
             }
             else if (choice == 3)
             {
                 Padlas();
             }
             else
             {
                 Console.WriteLine("Na akkor most mégegyszer");
                 choice = int.Parse(Console.ReadLine());
             }
         }
         static void Oltozo()
         {
             Console.WriteLine("Na irány öltözni, Németh Ádám már nagyon vár rád!");
             Console.WriteLine("Németh Ádám szokásos széles mosolyával fogad tesiórán.");
             Console.WriteLine("Megdícséred a cipőjét? Biztos értékelné.");
             Console.Write("Választás: ");
             Console.WriteLine("Amíg a többiek rúgják a bőrt, nincs kedved megemelni a nehezet a szertárban? Nincs olyan, hogy valaki túl erős.");
             Console.Write("Választás: ");
         }
         static void Pince()
         {
             Console.WriteLine("Pingpongozás közben a labda levándorolt a pincébe, de ez volt az utolsó labda, valakinek le kéne menni érte.");
         
             Console.WriteLine("A pincében szembetalálod magad egy nether portált megszégyenítő kapuval, a mellette lévő tábla szerint ha átmész rajta, az iskola egy véletlenszerű pontján fogsz kikötni.");
             Console.WriteLine("Igénybe veszed a kaput? A használata ingyenes.");
             Console.Write("Választás: ");
         }
         static void Padlas()
         {
             Console.WriteLine("Elnézted a termet, vagy tudod hová jöttél? Üdv a Black Marketen!");
             Console.WriteLine("Mivel szolgálhatunk?");
         }
    }
}

using System;
using System.Numerics;

namespace JedlikRPG
{
    internal partial class Program
    {
        public static string[] Items = { "Kaja", "Alkohol", "Pelenka", "Eldobható pelenka", /*bufe*/ "Melegszendvics", "Energiaital", "Nyalóka", /*feketepiac*/ "Xanax", "UTP kábel", "Grántotta" };
        public static string[] Descriptions = { "Egyszerű pékáru ami csökkenti az éhséget.", "A subidubi segíti általános jókedvünk megőrzését", "A nap folyamán nem kell hugyoznod",/*bufe*/ "Elsőre gombásnak hitted, ám ez egy sonkás szendvics.", "Végtére is a szíved és a fogaid nem ingyen lakbérben élnek...", "Az élet amúgyis szopás", /*feketepiac*/ "Nagyban csökkenti az elegem van statot.", "Ha már másra nem jó a CAT4-es szabvány...cserébe rendkívül fájdalmas", "Ételek királya, királyok étele." };
        public static int[] Ehseg       = { 20, 0, 0, 0,  /*bufe*/30, -5, 1, /*feketepiac*/ 0, 0, -100 };
        public static int[] Elegemvan   = { 0, -20, 0, 0,/*bufe*/ 0, 0, 0,  /*feketepiac*/ -60, 0, -5 };
        public static int[] Hugyholyag  = { 0, 25, 0, 0,/*bufe*/ 0, 15, 0, /*feketepiac*/ 0, 0, 0 };
        public static int[] Erő         = { 5, 5, 0, 0,/*bufe*/ 5, 10, 0, /*feketepiac*/ -5, 40, 18 };
        public static string[] Ritkaság = { "common", "common", "perma", "boost", /*bufe*/ "common", "common", "common", /*feketepiac*/ "boost", "boost", "boost" };

        public static void UseItem(List<List<dynamic>> inventory, string itemToUse,int ehseg,int elegemvan, int hugyholyag,int ero,out int x1, out int x2, out int x3, out int x4, out List<List<dynamic>> x5)
        {
            int itemID = Items.ToList().IndexOf(itemToUse);

            foreach(var item in inventory)
            {
                if (item[0] == itemToUse && item[1] >= 1)
                {
                    x1 = ehseg + Ehseg[itemID];
                    x2 = elegemvan + Elegemvan[itemID];
                    x3 = hugyholyag + Hugyholyag[itemID];
                    x4 = ero + Erő[itemID];
                    if (--item[1] == 0) inventory.Remove(item);
                    x5 = inventory;
                    return;
                }
            }
            x1 = ehseg;
            x2 = elegemvan;
            x3 = hugyholyag;
            x4 = ero;
            x5 = inventory;
        }

        public static bool VanPelenka(List<List<dynamic>> inventory, out List<List<dynamic>> x1)
        {
            foreach(var item in inventory)
            {
                if (item[0] == "Eldobható pelenka")
                {
                    inventory.Remove(item);
                    x1 = inventory;
                    return true;
                }
                if (item[0] == "Pelenka")
                {
                    x1 = inventory;
                    return true;
                }
            }
            x1 = inventory;
            return false;
        }

        public static void PrintInventory(List<List<dynamic>> inventory)
        {
            int index = 0;
            Console.Clear();
            Console.WriteLine("Színmagyarázat:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nem valami különleges item");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valamilyen statod jelentősen növelő item");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Végleges effektet adó item\n");
            foreach (var item in inventory)
            {
                index++;
                int itemID = Items.ToList().IndexOf(item[0]);
                SetColor(Ritkaság[itemID]);
                Console.WriteLine($"{index}. Item Name: {Items[itemID]}\n{Descriptions[itemID]}\n Stats: Elegemvan: {Elegemvan[itemID]}\tHugyholyag: {Hugyholyag[itemID]}\tErő: {Erő[itemID]}\nRitkaság: {Ritkaság[itemID]}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void SetColor(string ritkasag)
        {
            if (ritkasag == "perma")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (ritkasag == "common")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (ritkasag == "boost")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}



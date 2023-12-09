using DocumentFormat.OpenXml.Bibliography;
using System;

namespace JedlikRPG
{
    public partial class Item
    {
        public static string[] Items = { "Kaja", "Alkohol", "Pelenka",/*bufe*/ "Melegszendvics", "Energiaital", "Nyalóka", /*feketepiac*/ };
        public static string[] Descriptions = { "Egyszerű pékáru ami csökkenti az éhséget.", "A subidubi segíti általános jókedvünk megőrzését", "A nap folyamán nem kell hugyoznod",/*bufe*/ "Elsőre gombásnak hitted, ám ez egy sonkás szendvics.", "Végtére is a szíved és a fogaid nem ingyen lakbérben élnek...", "Az élet amúgyis szopás", /*feketepiac*/  };
        public static int[] Elegemvan = { 0, -20, 0, /*bufe*/ 0, 0, 0, /*feketepiac*/  };
        public static int[] Hugyholyag = { 0, 25, 0, /*bufe*/ 0, 15, 0, /*feketepiac*/  };
        public static int[] Erő = { 5, 5, 0, /*bufe*/ 5, 10, 0 };
        public static string[] Ritkaság = { "common", "common", "perma", /*bufe*/ "common", "common", "common", /*feketepiac*/  };

        static Dictionary<int, int> inventory = new Dictionary<int, int>();

        public static void addToInventory(int itemID)
        {
            inventory.Add(itemID, 1);
        }

        public static void RemoveItemFromInventory(int itemID)
        {
            inventory.Remove(itemID);
        }

        public static void usedItem(int itemID, int used)
        {
            foreach (var item in inventory)
            {
                if (item.Key == itemID)
                {
                    inventory[itemID] -= used;
                    if (inventory[itemID] == 0)
                    {
                        RemoveItemFromInventory(itemID);
                    }
                }
            }
        }
        public void PrintInventory()
        {
            Console.Clear();
            Console.WriteLine("Színmagyarázat:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nem valami különleges item");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valamilyen statod jelentősen növelő item");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Végleges effektet adó item");
            foreach (var item in inventory)
            {
                int itemID = item.Key;
                SetColor(Ritkaság[itemID]);
                Console.WriteLine($"Item Name: {Items[itemID]}\n{Descriptions[itemID]}\n Stats: Elegemvan: {Elegemvan[itemID]}\tHugyholyag: {Hugyholyag[itemID]}\tErő: {Erő[itemID]}\nRitkaság: {Ritkaság[itemID]}");
                Console.ResetColor();
            }
        }

        void SetColor(string ritkasag)
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
//                                               black market:

//public string[] Items = { "" };
//public string[] Descriptions = { "" };
//public int[] Elegemvan = {  };
//public int[] Hugyholyag = {  };
//public int[] Erő = {  };
//public string[] Ritkaság = { "" };



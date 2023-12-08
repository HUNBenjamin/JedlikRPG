namespace JedlikRPG
{
    internal partial class Program
    {
        static void km()
        {

            //}
            //public class Item
            //{
            //    public string Name = "Taknyos zsebkendő";
            //    public string Description = "Taknyos.";

            //    string[] Items = { "Kaja", "Alkohol", "Pelenka" };
            //    string[] Descriptions = { "-20 éhség", "-20 elegem van", "A nap folyamán nem kell hugyoznod" };
            }

            static void statDisplay(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<string> Inventory, int péz)
            {
                Console.WriteLine($"Idő: ");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Egyenleged: {péz}");
                Console.WriteLine($"Erő: {ero}\n\n");
            }

            static void Eurobolt(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<string> Inventory)
            {

                int péz = 6000;
                Console.WriteLine($"Beléptél az Euróboltba");
                Console.WriteLine("Itt különböző tárgyakat tudsz venni, amelyek segíthetnek átjutni a napodon");
                Console.WriteLine("1 -   Kaja(-20 éhség)\t3000f\n2 - Alkohol (-20 elegem van)\t5000f\n3 - Pelenka (A mai nap folyamán nem kell mosdóba menned)\t15.000f\n4 - Táska megtekintése");
                while (gameover != true)
                {
                    while (choice < 1 || choice > 3)
                    {
                        choice = Input("Választás: ");
                        if (choice == 1 && péz > 3000)
                        {
                            Console.Clear();

                            statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);

                            Console.WriteLine("\nMegvetted az ételt.");
                            péz = péz - 3000;
                            Inventory.Add("Étel");
                            choice = 0;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 3000f");
                        }
                        if (choice == 2 && péz > 6000)
                        {
                            Console.Clear();

                            Console.WriteLine($"Idő: ");
                            Console.WriteLine($"Elegem van: {elegemvan}");
                            Console.WriteLine($"Éhség: {ehseg}");
                            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                            Console.WriteLine($"Egyenleged: {péz}");
                            Console.WriteLine($"Erő: {ero}\n\n");

                            Console.WriteLine("\nEgy üveg vodkával nehezebb lett a táskád.");
                            Inventory.Add("Alkohol");
                            Console.WriteLine("");
                            choice = 0;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 6000f");
                        }
                        if (choice == 3 && péz > 15000)
                        {
                            Console.Clear();

                            Console.WriteLine($"Idő: ");
                            Console.WriteLine($"Elegem van: {elegemvan}");
                            Console.WriteLine($"Éhség: {ehseg}");
                            Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                            Console.WriteLine($"Egyenleged: {péz}");
                            Console.WriteLine($"Erő: {ero}\n\n");

                            Console.WriteLine("\nEltetted a pelust");
                            Inventory.Add("Pelenka");
                            Console.WriteLine("");
                            choice = 0;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 6000f");
                        }
                        if (choice == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Színmagyarázat:");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Nem valami különleges item");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valamilyen statod jelentősen növelő item");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Végleges effektet adó item");
                            Console.ResetColor();
                            int i = 1;

                            foreach (string item in Inventory)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{i++}. - {item}");

                            }
                        }
                    }
                }
            }
        }
    }

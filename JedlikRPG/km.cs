namespace JedlikRPG
{
    internal partial class Program
    {


            static void statDisplay(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<string> Inventory, int péz)
            {
                Console.WriteLine($"Idő: ");
                Console.WriteLine($"Elegem van: {elegemvan}");
                Console.WriteLine($"Éhség: {ehseg}");
                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                Console.WriteLine($"Egyenleged: {péz}");
                Console.WriteLine($"Erő: {ero}\n\n");
            }

            static void Eurobolt(int choice, int elegemvan, int ehseg, int hugyholyag, int ero, bool gameover, List<List<dynamic>> Inventory,int osztondij, out int x1, out int x2, out int x3, out int x4, out bool x5,out List<List<dynamic>> x6, out int x7)
            {

                int péz = osztondij;
                Console.WriteLine($"Beléptél az Euróboltba");
                Console.WriteLine("Itt különböző tárgyakat tudsz venni, amelyek segíthetnek átjutni a napodon");
                Console.WriteLine("1 -   Kaja(-20 éhség)\t3000f\n2 - Alkohol (-20 elegem van)\t5000f\n3 - Pelenka (A mai nap folyamán nem kell mosdóba menned)\t15.000f\n4 - Táska megtekintése\n5 - Kilépés az Euróboltból");
                while (!gameover)
                {
                    while (choice >= 0 || choice <= 5)
                    {
                        if(choice == 0)
                        {
                            Console.WriteLine($"Beléptél az Euróboltba");
                            Console.WriteLine("Itt különböző tárgyakat tudsz venni, amelyek segíthetnek átjutni a napodon");
                            Console.WriteLine("1 -   Kaja(-20 éhség)\t3000f\n2 - Alkohol (-20 elegem van)\t5000f\n3 - Pelenka (A mai nap folyamán nem kell mosdóba menned)\t15.000f\n4 - Táska megtekintése\n5 - Kilépés az Euróboltból");
                        }
                        choice = Input("Választás: ");

                        if (choice == 1)
                        {
                            if(péz >= 3000)
                            {
                                Console.Clear();

                                statDisplay(choice, elegemvan, ehseg, hugyholyag, ero, gameover, Inventory, péz);

                                Console.WriteLine("\nMegvetted az ételt.");
                                péz -= 3000;
                                Inventory.Add(new List<dynamic> { "Kaja", 1 });
                                
                        }
                            else{
                                Console.Clear();
                                Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 3000f");
                            }
                            choice = 0;
                        }
 
                        if (choice == 2)
                        {

                            if (péz >= 6000)
                            {
                                Console.Clear();

                                Console.WriteLine($"Idő: ");
                                Console.WriteLine($"Elegem van: {elegemvan}");
                                Console.WriteLine($"Éhség: {ehseg}");
                                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                                Console.WriteLine($"Egyenleged: {péz}");
                                Console.WriteLine($"Erő: {ero}\n\n");

                                Console.WriteLine("\nEgy üveg vodkával nehezebb lett a táskád.");
                                Inventory.Add(new List<dynamic> { "Alkohol", 1 });
                                Console.WriteLine("");
                                
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 6000f");
                            }
                            choice = 0;
                            }

                        if (choice == 3)
                        {

                        if (péz > 15000)
                            {
                                Console.Clear();

                                Console.WriteLine($"Idő: ");
                                Console.WriteLine($"Elegem van: {elegemvan}");
                                Console.WriteLine($"Éhség: {ehseg}");
                                Console.WriteLine($"Húgyhólyag állapota: {hugyholyag}");
                                Console.WriteLine($"Egyenleged: {péz}");
                                Console.WriteLine($"Erő: {ero}\n\n");

                                Console.WriteLine("\nEltetted a pelust");
                                Inventory.Add(new List<dynamic> { "Pelenka", 1 });
                                Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nincs elég pénzed\nJelenlegi egyenleged: {péz}\nSzükséges egyenleg: 6000f");
                        }
                        choice = 0;

                        }

                        if (choice == 4)
                        {
                            int altChoice = -1;
                            while(altChoice == -1)
                            {
                                PrintInventory(Inventory);
                                Console.WriteLine("0. Kilépés");
                                altChoice = Input("Választás: ");
                            }
                            if (altChoice == 0) break ;
                            else
                            {
                                UseItem(Inventory, Inventory[altChoice-1][0],ehseg,elegemvan,hugyholyag,ero,out ehseg,out elegemvan,out hugyholyag,out ero,out Inventory);
                            }
                            Item item = new Item();
                            item.PrintInventory();
                        }
                    if (choice == 5)
                    {
                        x1 = elegemvan;
                        x2 = ehseg;
                        x3 = hugyholyag;
                        x4 = ero;
                        x5 = gameover;
                        x6 = Inventory;
                        x7 = péz;
                        return;
                    }
                    }
                }
                x1 = elegemvan;
                x2 = ehseg;
                x3 = hugyholyag;
                x4 = ero;
                x5 = gameover;
                x6 = Inventory;
                x7 = péz;
            }
        }
    }

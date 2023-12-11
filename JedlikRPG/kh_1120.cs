using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedlikRPG
{
    public class Difficulty
    {
        public int Alvas { get; private set; }
        public int Busz { get; private set; }
        public int Osztondij { get; private set; }
        public int Esely { get; private set; }
        public void NehezsegErtekek(int nehezseg)
        {
            Random randomEsemeny = new Random();
            switch (nehezseg)
            {
                case 1:
                    Alvas = 8;
                    Busz = 30;
                    Osztondij = 60000;
                    Esely = randomEsemeny.Next(1, 11);
                    break;

                case 2:
                    Alvas = 6;
                    Busz = 20;
                    Osztondij = 42000;
                    Esely = randomEsemeny.Next(1, 11);
                    break;

                case 3:
                    Alvas = 3;
                    Busz = 7;
                    Osztondij = 25000;
                    Esely = randomEsemeny.Next(1, 11);
                    break;

                case 4:
                    Alvas = 0;
                    Busz = 3;
                    Osztondij = 8000;
                    Esely = randomEsemeny.Next(1, 11);
                    break;

                default:
                    Console.WriteLine("Na akkor most mégegyszer");
                    break;
            }
        }
    }
}

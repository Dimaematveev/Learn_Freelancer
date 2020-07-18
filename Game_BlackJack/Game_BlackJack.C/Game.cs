using System;

namespace Game_BlackJack.C
{
    public class Game
    {
        public int BotsCount;
        public Game()
        {

        }

        public void StartGame()
        {
            
            while (!AskStarting())
            {
            }

            Console.WriteLine("Hello, write bots count");
            BotsCount = GetValue(10);
            for (int i = 0; i < BotsCount; i++)
            {

            }


        }

        private bool AskStarting()
        {
            Console.WriteLine("Want to play(y/n)");
            bool choise;
            while (true)
            {
                var cr = Console.ReadKey();
                if (cr.Key == ConsoleKey.Y || cr.Key == ConsoleKey.N)
                {
                    choise = cr.Key == ConsoleKey.Y;
                    break;
                }
                Console.Write("\b");
            }
            Console.WriteLine();
            return choise;
        }

        private int GetValue(int maxCount)
        {
            Console.WriteLine($"Введите значение не превышающее {maxCount}");
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value) && value <= maxCount) 
                {
                    return value;
                }
            }
        }
    }

}

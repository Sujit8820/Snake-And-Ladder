// See https://aka.ms/new-console-template for more information
using System;

namespace Snake_And_Ladder
{
    class Program

    {
        int position = 0;

        public static int CheckOption()
        {

            Random random = new Random();
            int option = random.Next(1, 4);
            return option;
        }
        public static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        public static void Main()
        {
            int position = 0;
            while (position != 100)
            {
                const int LADDER = 1;
                const int SNAKE = 2;
                const int NOPLAY = 3;

                switch (CheckOption())
                {
                    case LADDER:
                        position += DiceRoll();
                        break;

                    case SNAKE:
                        position -= DiceRoll();
                        position = position < 0 ? 0 : position;
                        break;

                    case NOPLAY:

                        break;

                }
                Console.WriteLine("Position" + position);
            }
        }

    }

}

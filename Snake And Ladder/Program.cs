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
            // Console.WriteLine("option"+option);
            return option;
        }
        public static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            // Console.WriteLine("diceno"+diceNumber);
            return diceNumber;
        }
        public static void Main()
        {
            int position = 0;
            int diceRoll = 0;
            while (position != 100)
            {
                const int LADDER = 1;
                const int SNAKE = 2;
                const int NOPLAY = 3;
                int diceNumber = DiceRoll();
                switch (CheckOption())
                {
                    case LADDER:
                        diceRoll++;
                        position = position + diceNumber > 100 ? position : position + diceNumber;

                        break;

                    case SNAKE:
                        diceRoll++;
                        position = position - diceNumber < 0 ? 0 : position - diceNumber;
                        break;

                    case NOPLAY:

                        break;

                }
                Console.WriteLine("Dice Roll " + diceRoll + " Position " + position);
            }
        }

    }

}

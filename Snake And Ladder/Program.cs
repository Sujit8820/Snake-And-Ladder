// See https://aka.ms/new-console-template for more information
using System;

namespace Snake_And_Ladder
{
    class Program

    {

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
        public static int Play(int option, int diceNumber)
        {
            int position = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NOPLAY = 3;

            switch (option)
            {
                case LADDER:
                    position += diceNumber;
                    break;

                case SNAKE:
                    position -= diceNumber;
                    break;

                case NOPLAY:

                    break;

            }
            return position;
        }
        public static void Main(string[] args)
        {
            int place = Play(CheckOption(), DiceRoll());
            Console.WriteLine("Position:" + place);
        }

    }

}

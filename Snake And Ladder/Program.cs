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


        public static int Turn()
        {

            Random random = new Random();
            int turn = random.Next(1, 3);
            return turn;
        }
        public static void Main()
        {
            int turn = Turn();
            const int PLAYER_ONE = 1;
            const int PLAYER_TWO = 2;

            int position = 0;
            int diceRoll = 0;
            int position1 = 0;
            int position2 = 0;
            while (position1 != 100 && position2 != 100)
            {
                const int LADDER = 1;
                const int SNAKE = 2;
                const int NOPLAY = 3;
                int diceNumber = DiceRoll();
                int option = CheckOption();
                if (turn == PLAYER_ONE)
                {
                    switch (option)
                    {
                        case LADDER:
                            diceRoll++;
                            position1 = position1 + diceNumber > 100 ? position1 : position1 + diceNumber;
                            turn = PLAYER_ONE;
                            break;

                        case SNAKE:
                            diceRoll++;
                            position1 = position1 - diceNumber < 0 ? 0 : position1 - diceNumber;
                            turn = PLAYER_TWO;
                            break;

                        case NOPLAY:
                            turn = PLAYER_TWO;
                            break;

                    }
                }
                else if (turn == PLAYER_TWO)
                {
                    switch (option)
                    {
                        case LADDER:
                            diceRoll++;
                            position2 = position2 + diceNumber > 100 ? position2 : position2 + diceNumber;
                            turn = PLAYER_TWO;

                            break;

                        case SNAKE:
                            diceRoll++;
                            position2 = position2 - diceNumber < 0 ? 0 : position2 - diceNumber;
                            turn = PLAYER_ONE;

                            break;

                        case NOPLAY:
                            turn= PLAYER_ONE;
                            break;

                    }
                }
                Console.WriteLine("Dice Roll " + diceRoll + "  Player One Position " + position1 + "  Player Two Position " + position2);
            }
        }

    }

}

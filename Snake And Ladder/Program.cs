// See https://aka.ms/new-console-template for more information
using System;

namespace Snake_And_Ladder
{
    class Programe
    {
        public static int dieRoll()
        {
            Random random = new Random();
            int dieNumber = random.Next(1,7);
            return dieNumber;
        }
        public static void Main(string[] args)
        {
            int position = dieRoll();
            Console.WriteLine("Position:" + position);
        }

    }

}

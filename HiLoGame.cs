using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    internal static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1,MAXIMUM+1);
        private static int pot = 11;

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(MAXIMUM);
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("\nYou guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("\nBad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");

        }
        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"\nThe number is at least {half}");
            }
            else
            {
                Console.WriteLine($"\nThe number is at most {half}");
            }
            pot--;
        }
        public static int GetPot()
        {
            return pot;
        }

    }
}

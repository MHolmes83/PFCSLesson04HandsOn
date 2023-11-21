using System;

namespace Lesson04HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubled Number: " + DoubleMe(4));

            Console.WriteLine("Quadrupled Number: " + QuadrupleMe(5));

            Console.WriteLine("Number Doubled Many Times: " + DoubleNumberMultipleTimes(2, 3));
        }

        public static int DoubleMe(int number)
        {
            return(number * 2);
        }

        public static int QuadrupleMe(int number)
        {
            return(DoubleMe(DoubleMe(number)));
        }

        public static int DoubleNumberMultipleTimes(int numberToBeDoubled, int amountOfTimes)
        {
            for (int i = 0; i < amountOfTimes; i++)
            {
                numberToBeDoubled = DoubleMe(numberToBeDoubled);
            }

            return numberToBeDoubled;
        }
    }
}
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Welcome();

            GreetPerson("Emilia");
            GreetPerson("Thomas");
            GreetPerson("Gail");
            GreetPerson("Abraham");

            Console.WriteLine(IsEven(2));

            int num1 = 1;
            int num2 = 2;

            int sum = Add(num1, num2);
            Console.WriteLine(sum);

            
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Earth!");
        }

        public static void GreetPerson(string personName)
        {
            Console.WriteLine("Hello, " + personName);
        }

        public static bool IsEven(int number)
        {
            bool result;

            if(number % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static int Add(int number1, int number2)
        {
            return(number1 + number2);
        }
    }
}
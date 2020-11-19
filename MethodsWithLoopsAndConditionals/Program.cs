using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();

            var num = 0;

            do
            {
                num++;
                numbers.Add(num);
            }
            while (num < 100);

            Console.WriteLine("Positive:");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

             static void UpByThrees()
            {
                var threes = new List<int>();

                var third = 0;

                do
                {
                    third = third + 3;
                    threes.Add(third);
                }
                while (third < 999);

                Console.WriteLine("Thirds:");

                foreach (var tri in threes)
                {
                    Console.WriteLine(tri);
                }
            }


             static bool AreTwoNumbersTheSame(int num1, int num2)
            {
                Console.WriteLine("Are 2 integers equal?");

                Console.WriteLine("What is your 1st number?");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your 2nd number?");
                num2 = int.Parse(Console.ReadLine());

                if (num1 != num2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
              }
                 static void EvenOrOdd(int number)
                {
                Console.WriteLine("What is your number?");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");

                    }

                }


            static void IsPositive()
            {
                Console.WriteLine("What is your number?");
                int num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }




        }
    }
}
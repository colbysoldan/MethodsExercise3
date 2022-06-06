using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintAllNumbers()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThrees()
        {
            for (var i=3; i<=999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void EqualOrNot(int x, int y)
        {
            //    var Guess1 = x;
            //    var Guess2 = y;
            //    Console.WriteLine("Pick a number:");
            //    var isInt = int.TryParse(Console.ReadLine(), out Guess1);
            //    if (!isInt)
            //    {
            //        Console.WriteLine("Not a valid number.");
            //    }
            //    Console.WriteLine("Pick another number:");
            //    var alsoInt = int.TryParse(Console.ReadLine(), out Guess2);
            //    if (!alsoInt)
            //    {
            //        Console.WriteLine("Not a valid number.");
            //    }
            //    if (Guess1 > Guess2)
            //    {
            //        Console.WriteLine($"{Guess1} is greater than {Guess2}");
            //    }
            //    else if (Guess2 < Guess1)
            //    {
            //        Console.WriteLine($"{Guess2} is greather than {Guess1}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{Guess1} and {Guess2} are equal.");
            //    }

            if (x == y)
        {
            Console.WriteLine("Those numbers are equal");
        }
        else
        {
            Console.WriteLine("Those numbers are not equal.");
        }
        }

        //Write a method to check whether a given number is even or odd


        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a whole number:");
            int input = (Convert.ToInt32(Console.ReadLine()));

            if (input % 2 == 1)
            {
                Console.WriteLine("This number is odd.");
            }
            else
            {
                Console.WriteLine("This number is even.");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg()
        {
            
            Console.WriteLine("Enter a number:");
            int yourNumber = (Convert.ToInt32(Console.ReadLine()));

            if (yourNumber == 0)
            {
                Console.WriteLine($"{yourNumber} is neither positive nor negative.");
            }
            else if (yourNumber == Math.Abs(yourNumber))
            {
                Console.WriteLine($"{yourNumber} is positive.");
            }
            else
            {
                Console.WriteLine($"{yourNumber} is negative");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote

        public static void CanYouVote()
        {
            //Console.WriteLine("How old are you?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(age >= 18 ? "Congratulations! You can vote!" : "Sorry, you're not old enough.");

            bool userAge;
            int age;

            do
            {
                Console.WriteLine("Please enter your age:");

                userAge = int.TryParse(Console.ReadLine(), out age);
            } while (!userAge);

            Console.WriteLine(age >= 18 ? "Congratulations! You can vote!" : "Sorry, you're not old enough.");

        }


        //Write a method to check if an integer (from the user) is in the range -10 to 10
        public static void NumberBetween()
        {
            
            bool response;
            int number;

            do
            {
                Console.WriteLine("Enter a number between -10 and 10:");
                response = int.TryParse(Console.ReadLine(), out number);
            }
            while (!response);


            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT between -10 and 10.");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable()
        {
            bool response;
            int result;

            do
            {
                Console.WriteLine("Enter an integer:");
                response = int.TryParse(Console.ReadLine(), out result);
            } while (!response);

            for(var i = 1; i <=12; i++)
            {
                Console.WriteLine($"{i} x {result} = {i * result}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1000 down to -1000.");
            PrintAllNumbers();
            Console.WriteLine();

            PrintByThrees();
            Console.WriteLine();
            
            EqualOrNot(46, 43);
            Console.WriteLine();
            EqualOrNot(44, 44);
            Console.WriteLine();

            EvenOrOdd();
            Console.WriteLine();

            PosOrNeg();
            Console.WriteLine();

            CanYouVote();
            Console.WriteLine();

            NumberBetween();
            Console.WriteLine();

            MultTable();
            Console.ReadLine();
        }
    }
}

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbersFrom1000ToMinus1000();
            PrintNumbersFrom3To999By3();
            CheckIfEqual(5, 5);
            CheckIfEvenOrOdd(7);
            CheckIfPositiveOrNegative(-3);
            CheckVotingEligibility();
        }
        static void PrintNumbersFrom1000ToMinus1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintNumbersFrom3To999By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        static void CheckIfEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are NOT equal.");
            }
        }
        static void CheckIfEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
        static void CheckIfPositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative.");
            }
            else
            {
                Console.WriteLine($"{num} is zero.");
            }
        }
        static void CheckVotingEligibility()
        {
            Console.WriteLine("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are old enough to vote!");
                }
                else
                {
                    Console.WriteLine("You are NOT old enough to vote, sorry.");
                }
            }
        }
    }

}

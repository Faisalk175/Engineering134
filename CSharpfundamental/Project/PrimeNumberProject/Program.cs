using System;

namespace PrimeNumberProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first integer:");
            string userInput1 = Console.ReadLine();
            int num1 = 0;
            
            

            while (!int.TryParse(userInput1, out num1))
            {

                Console.WriteLine("Invalid input, try again");
                userInput1 = Console.ReadLine();
            }


            Console.WriteLine("Enter second integer:");
            int num2 = 0;
            string userInput2 = Console.ReadLine();
            
            while (!int.TryParse(userInput2, out num2))
            {
                Console.WriteLine("Invalid input, try again");
                userInput2 = Console.ReadLine();
            }

            int i, count, n;

            var PrimeNumbers = new List<int>();
            for (n = num1; n <= num2; n++)
            {
                count = 0;
                for (i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && n != 1)
                {
                    Console.Write("{0} ", n);
                    PrimeNumbers.Add(n);
                }
                    

            }
            Console.WriteLine("");
            Console.WriteLine($"There number of prime numbers are: {PrimeNumbers.Count()}");
            Console.WriteLine($"Average of Prime Numbers is {PrimeNumbers.Average()}");

        }

    }
}
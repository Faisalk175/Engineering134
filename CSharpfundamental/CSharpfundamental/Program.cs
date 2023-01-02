using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace CSharpFundamentals
{
    public class Program
    {
        public static void Main()
        {

            string message4 = DemonstationMethod(2, 3, false);
            Console.WriteLine(message4);

            string result = ConditionsAndOutcome(17);
            Console.WriteLine(result);

            string message = "The red fox jumps over the lazy brown dog.";
            Console.WriteLine(ManipulatingPhrase(message));

            string phrase = "Good Morning";
            Console.WriteLine(ForeachLoopEveningTask(phrase));

            Console.WriteLine("Enter a password:");
            string userInput = Console.ReadLine();

            while (PasswordCheck(userInput) == false)
            {
                Console.Clear();
                // tell the user the password is incorrect, try again
                Console.WriteLine("Try agian");
            } 
            Console.WriteLine("Well done!");

            //Arrays 
            int[] nums = new int[5];
            for  (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }  
            // for loop is basically doing this
            // nums[0] = 1;
            // nums[1] = 2;
            // nums[2] = 3;
            // nums[3] = 4;
            // nums[4] = 5;

            //Lists
            List<char> name = new List<char>() { 'P', 'e', 't', 'e', 'r'};
            name.Reverse();

            //make a method that retursn a "D array which containas all the positions of a chessboard
            string[,] chessboard = MakeAChessboard();


        }

        private static string[,] MakeAChessboard()
        {
            List<char> columns = new() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            string[,] chessPositions = new string[8, 8];

            for(int y = 0; y < 8; y++) //nested loop
            {
                for (int x = 0; x < 8; x++)
                {
                    chessPositions[x, y] = $"{columns[x]}{8-y}";
                }
            }
            return chessPositions;
        }

        private static string ConditionsAndOutcome(int temperature)
        {
            

            if (temperature >= 35)
            {
                return "Nah, too hot to be outside";
            }
            else if (temperature >= 18 && temperature < 35)
            {
                return "Outdoor meal time";
            }
            else if (temperature < 18 && temperature > 0)
            {
                return "Sweater weather";
            }
            else
            {
                return "Literally Freezing";
            }
        }


        private static string ManipulatingPhrase(string message)
        {
          
            message = message.ToUpper().Replace('R', '*').Replace(" ", string.Empty);
            return message;
        }



        private static string DemonstationMethod(int x, int y, bool done)
        {
           
            if (x > y)
            {
                return "X is greater than Y";
            }
            else if (done)
            {
                return "Y is greater than X and done equals to true";
            }
            else
            {
                return "X is less than Y and done is false";
            }


        }

        private static string ForeachLoopEveningTask(string phrase)
        {
            
               phrase = phrase.ToUpper().Replace('E', '3').Replace('A', '4').Replace('I', '1').Replace('O', '0').Replace(" ", string.Empty);
            
               return phrase;
        }

        public static bool PasswordCheck(string inputPassword)
        {
           return (inputPassword == "Password!");
            
        }


        
    }

}


//int temperature = 17;

//if (temperature >= 35)
//{
//    Console.WriteLine("Nah, too hot to be outside");
//}
//else if (temperature >= 18 && temperature < 35)
//{
//    Console.WriteLine("Outdoor meal time");
//}
//else if (temperature < 18 && temperature > 0)
//{
//    Console.WriteLine("Sweater weather");
//}
//else
//{
//    Console.WriteLine("Literally Freezing");
//}


//string message = "The red fox jumps over the lazy brown dog.";
//message = message.ToUpper().Replace('R', '*').Replace(" ", string.Empty);
//Console.WriteLine(message);



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

            string phrase = "leetspeak";
            Console.WriteLine(ForeachLoopEveningTask(phrase));
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

            
            
            foreach(char letter in phrase)
            {
                phrase = phrase.ToUpper().Replace('E', '3').Replace('A', '4').Replace('I', '1').Replace('O', '0');
            }
               return phrase;
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



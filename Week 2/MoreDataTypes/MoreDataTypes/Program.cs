using System.Text;
namespace MoreDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            Console.WriteLine(StringExercise(myString));
            StringInterpolation("Faisal");
            ParsingStrings();
        }

        public static string StringExercise(string myString)
        {
            var intermediateString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            var nPos = intermediateString.IndexOf('N');
            var finalString = intermediateString.Remove(nPos + 1);
            return finalString;
        }

        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.Trim().ToUpper();
            var npos = trimmedUpperString.IndexOf('N');
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(npos + 1, sb.Length - npos - 1);
            return sb.ToString();
        }

        public static void StringInterpolation(string str)
        {
            Console.WriteLine("My name is:" + str + " Using +");
            Console.WriteLine($"My name is : {str} using interpolation");
            var num1 = 14;
            var num2 = 7;
            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
            var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0.####}";
            var fString3 = $"That will be {num2 / 3.0} Please";
        }

        public static void ParsingStrings()
        {
            // parsing strings
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();
            //int numApples = Int32.Parse(input);
            var success = Int32.TryParse(input, out int parsedApples);

        }



    }

}







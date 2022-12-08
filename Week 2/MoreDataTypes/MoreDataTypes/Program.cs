namespace MoreDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            Console.WriteLine(StringExercise(myString));
        }

        public static string StringExercise(string myString)
        {
            return myString.Replace(" ", "").ToUpper().Replace('L', '*').Replace('T', '*');
        }
    }

}







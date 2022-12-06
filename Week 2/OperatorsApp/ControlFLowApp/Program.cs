namespace ControlFLowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark = 90;
            var grade = mark >= 65 ? (mark >= 85 ? "distinction" : "Pass") : "Fail";

            Console.WriteLine(Priority(3));
            Console.WriteLine(CanDrive(12));
        }




        public static string Priority(int level)
        {
            string priority = "Code ";
            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }

        public static bool CanDrive(int age)
        {
            switch (age)
            {
                case >= 17:
                    return true;
                default:
                    return false;
            }
        }
    }
}
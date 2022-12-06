using Microsoft.VisualBasic;

namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            x++;
            ++y;

            int a = x++;
            int b = ++y;

            for (int i = 1; i <= 5; ++i)
            {
                Console.WriteLine(i);
            }

            var c = 5 / 2;
            var d = 5.0 / 2;
            var e = 5 / 3;
            double f = 5 / 2;

            var daysInaWeek = 7;
            var totalDaysToBirthday = 23;
            var weeksToBirthday = totalDaysToBirthday / daysInaWeek;
            var days = totalDaysToBirthday % daysInaWeek;


            Console.WriteLine(EvenOdd(5));
            int mass = 156;
            Console.WriteLine(mass + " pounds is equal to: " + GetStones(mass) + " stones and " + GetPounds(mass) + " pounds.");

           
        }
        public static bool EvenOdd(int num)
        {
            return num % 2 == 0;
        }

        public static int GetStones(int totalPounds)
        {
            return totalPounds / 14;
        }
        public static int GetPounds(int totalPounds)
        {
            return totalPounds % 14;
        }
        
    }
}
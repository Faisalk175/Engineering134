namespace StringCalculatorKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int Add(string nums)
        {
            if(nums == null)
            {
                return 0;
            }  

            string[] splitNums = nums.Split(',', '\n');
            int total = 0;

            foreach(string num in splitNums)
            {
                total += Int32.Parse(num);
            }
            return total;
        }





    }
}
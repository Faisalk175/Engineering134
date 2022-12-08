using System;
namespace NumericalDataTypesApp;

public class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;


        var age = 33;

        var height = 182.5f;
        var ageOfTheUniverse = 13128324234234uL;
        var makesSense = true;

        // implicit usings
        List<int> nums;
        var prices = new List<decimal>();

        float sum = 0;
        for (int i = 0; i < 700_000; i++)
        {
            sum += 1 / 7f;
        }
        Console.WriteLine(sum);
        Console.WriteLine(700_000 * 1 / 7f);

        if (700_000 / 7f == 100_000)
        {
            Console.WriteLine("700_000 is divisible by 7!");
        }
        else
        {
            Console.WriteLine("700_000 is not divisible by 7!");
        }
    }


}
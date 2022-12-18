
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace AdventOfCodeApp;

internal class Program
{
    static void Main(string[] args)
    {

        
        Console.WriteLine(HighestNumberOfCaloriesELfIsCarrying());
    }

    public static string HighestNumberOfCaloriesELfIsCarrying()
    {
        string calorieInput = File.ReadAllText("C:/Users/faisa/Documents/Engineering134/Week 3/AdventOfCode/AdventOfCodeApp/TextFile1.txt");
        string[] everyLine = calorieInput.Split("\n"); // \n is an escape sequence changes cursor position to beginning of the next file

        List<int> eachElfsCalorieTotal = new List<int>();


        int totalCalories = 0;

        foreach (string calorie in everyLine)
        {
            if (Int32.TryParse(calorie, out int output))
            {
                totalCalories += output;
            }
            else
            {

                eachElfsCalorieTotal.Add(totalCalories);
                totalCalories = 0;
            }
        }


        int highestCaloriesCarried = 0;

        foreach (int highest in eachElfsCalorieTotal)
        {
            if (highest > highestCaloriesCarried)
            {
                highestCaloriesCarried = highest;
            }
            
        }






        return $"The highest total calories is: {highestCaloriesCarried}";
    }




}
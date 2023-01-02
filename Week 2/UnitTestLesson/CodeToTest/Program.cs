namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        int age = -3;
        Console.WriteLine(GetGreeting(timeOfDay));
        Console.WriteLine(AvailableClassifications(age));
    }

    public static string GetGreeting(int timeOfDay)
    {
        string message;
        if (timeOfDay < 0 || timeOfDay > 23)
        {
            throw new ArgumentOutOfRangeException("Greeting cannot be out the range 0 to 23");
        }
         
        // 0 to 4
        if (timeOfDay >= 5 && timeOfDay < 12)
        {
            message = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            message = "Good afternoon!";
        }
        else
        // 19 to 24
        {
            message = "Good evening!";
        }
        return message;
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;

        if (ageOfViewer < 0)
        {
            throw new ArgumentOutOfRangeException("Age of the viewer cannot be less than 0");
        }


        if (ageOfViewer < 12)
        {
            result = "U & PG films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer <= 17)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else if (ageOfViewer <= 18)
        {
            result = "U, PG, 12, 15 & 18 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }



}




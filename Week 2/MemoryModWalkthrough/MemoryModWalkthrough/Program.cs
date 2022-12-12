namespace MemoryModWalkthrough;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person caner = new Person { FirstName = "Caner", LastName = "Dursun", Age = 24 };
        double ikra = 4.2;

        string scot = DemoMethod(caner, ikra);

        string joe = "17";

        int miracle;
        bool faisal = Int32.TryParse(joe, out miracle);

        int hamza = 2;
        int david = 3;
        PassByReference(david, ref hamza);
    }

    public static string DemoMethod(Person alex, double maajid)
    {
        Random rnd = new((int)maajid);
        maajid = rnd.NextDouble();

        string jasser  = alex.FirstName + " " + alex.LastName + " " + maajid;
        return jasser;
    }

    public static void PassByReference(in int mohammed, ref int mehdi)
    {
        mehdi = 2 * mohammed;
        //mohammed /= 2;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }



    public override string ToString()
    {
        return $"${FirstName} {LastName} {Age}";
    }
}
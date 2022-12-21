using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using VehicleClassApp;

namespace SafarParkApp;

public class Program
{
    static void Main(string[] args)
    {
        //var bobOne = new Person("Bob", "Builder");
        //var bobTwo = new Person("Bob", "Builder");

        //bobTwo.Age = 36;

        //Console.WriteLine("BobOne is BobTwo? " + bobOne.Equals(bobTwo));


        //var cesna = new Airplane(5);
        //var bushPlane = new Airplane(5);
        //bushPlane.Ascend(300);

        //bool isTheSame = cesna == bushPlane;

        //Console.WriteLine("Cesna is bushPlant? " +isTheSame);

        //List<Airplane> planes = new()
        //{
        //    cesna,
        //    bushPlane,
        //    new Airplane(15) {Altitude = 200}
        //};

        //planes.Sort();

        List<Person> people = new()
        {
            new Person("ALex", "Blunt"),
            new Person("Mohammed", "Ali"),
            new Person("Ikra", "Dahir")
        };

        foreach(Person p in people)
        {
            //Console.WriteLine(p);
        }

        Console.WriteLine(people[0]);

        var caner = new Person("Caner", "Dursun");
        people.Add(caner);
        people.Remove(caner);

        List<int> ints = new() { 5, 4, 3, 9, 0};
        //Add 8 to the list
        ints.Add(8);
        //Sort the list
        ints.Sort();
        //Remove the 2 digits starting at position 1
        ints.RemoveRange(1, 2);
        //Inster the number 1 at postion 2
        ints.Insert(2, 1);
        //Reverse the list
        ints.Reverse();
        ints.Remove(9);

        foreach (int i in ints)
        {
            Console.WriteLine($"{i} ");
        }

        Queue<Person> peopleQueue = new(people);
        //peopleQueue.Enqueue(new Person("ALex", "Blunt"));
        //peopleQueue.Enqueue(new Person("Mohammed", "Ali"));
        //peopleQueue.Enqueue(new Person("Ikra", "Dahir"));

        Console.WriteLine(peopleQueue.Peek());


        Stack<Person> peopleStack = new(people);
        //peopleStack.Push(new Person("ALex", "Blunt"));
        //peopleStack.Push(new Person("Mohammed", "Ali"));
        //peopleStack.Push(new Person("Ikra", "Dahir"));

        Console.WriteLine(peopleStack.Pop());

        int[] original = new int[] { 1, 2, 3, 4, 5 };
        int[] reversed = new int[original.Length];
        var stack = new Stack<int>();

       foreach(int n in original)
        {
            stack.Push(n);
        }

        int length = stack.Count;
        for (int i = 0; i < reversed.Length; i++)
        {
            reversed[i] = stack.Pop();
        }

        // Hash Set
        var planeSet = new HashSet<Airplane>
        {
            new Airplane(5) {Speed = 10, Altitude = 5},
            new Airplane(15) {Speed = 20, Altitude = 50},
            new Airplane(35) {Speed = 30, Altitude = 500},
        };

        foreach (var plane in planeSet) Console.WriteLine(plane);

        var plane1 = new Airplane(1);
        var plane2 = new Airplane(1);

        bool addCapacity1Plane = planeSet.Add(plane1);
        bool addCapacity1PlaneAgain = planeSet.Add(plane2);

        //Dictionary <key, value>

        var personDict = new Dictionary<string, Person>()
        {
            {"Tasheer", new Person("Mohammed", "Ali") },
            {"Nah", new Person("Mehdi", "Hamdi") },
            {"No", new Person("Scot", "Morrison") },
        };

        Console.WriteLine(personDict["Tasheer"]);
        personDict.Add("Maj", new Person("Maajid", "Ali"));

        var keys = personDict.Keys.ToArray();

        Console.WriteLine(keys[0]);

        string input = "The cat in the hat comes back";

        var countDict = new Dictionary<char, int>();
        foreach(char c in input.ToLower())
        {
            if (c == ' ')
            {
            }
            else if (countDict.ContainsKey(c))
            {
                countDict[c]++; 
            }
            else
            {
                countDict.Add(c, 1);    
            }
        }

        foreach (var kvp in countDict) Console.WriteLine($"<{kvp.Value}>");




        //Camera pentax = new Camera("Pentax");
        //WaterPistol superGun = new WaterPistol("Supersoaker");
        //LaserGun laserGun = new LaserGun("RayGun");

        //Hunter nish = new Hunter("Nish", "Mandal", pentax);
        //Console.WriteLine(nish.Shoot());

        //nish.Shooter = superGun;
        //Console.WriteLine(nish.Shoot());

        //nish.Shooter = laserGun;
        //Console.WriteLine(nish.Shoot());


        //nish.Shooter = superGun;
        //Console.WriteLine(nish.Shoot());


        //Hunter nish = new Hunter("Nish", "Mandal", "Nikon") { Age = 31 };
        ////{Age = 31} object initialistation has to "init"
        //nish.Age = 31; // no access to "init"

        //Person jasser = new Person("Jasser", "Bawi");
        //Person jassersTwin = new Person("Jasser", "Bawi");

        //Console.WriteLine(jasser.Equals(jassersTwin));
        //Console.WriteLine(jasser.GetType());

        //Console.WriteLine(nish);


        //Lion L = new Lion();    
        //Console.WriteLine(L);


        //Person alex = new Person("Alex", "Blunt", 18);
        //Console.WriteLine(alex.FullName());

        //Person mehdi = new Person("Mehdi", "Hamdi");
        //mehdi.Age = 24;
        //Console.WriteLine(mehdi.Age);

        //mehdi.Height = 285;


        ////Object Initialisation
        //int[] nums = {1,2,3,4,5,6,7,8,9};
        //Person faisal = new Person("Faisal", "Khalaf") { Age = 33, Height = 215 };
        //Person scot = new Person()
        //{
        //    FirstName = "Scot",
        //    LastName = "Morrisson",
        //    Age = 33,
        //    Height = 215
        //};


        //ShoppingList items = new ShoppingList()
        //{
        //    ShoppingCart = "Haye" 
        //};

        ////Structs
        //Point3D p = new Point3D(10,20);
        //Point3D p2; new Point3D(); //structs always have a parameterless constructor even in one isnt defined

        //Console.WriteLine(p.DistanceFromOrigin());
        //DoThis(scot, p);

        //Cat MrTibbles = new Cat();

        //List<IMoveable> safariObjects = new()
        //{
        //    jasser,
        //    jassersTwin,
        //    MrTibbles,
        //    nish,
        //    new Vehicle(12, 100) {NumPassengers = 6}
        //};


        //foreach(Object obj in safariObjects)
        //{
        //    IMoveable moveable = (IMoveable)obj;
        //    SpartaWrite(obj);
        //}



    }

    //  private static void SpartaWrite(object moveable)
    //  {
    //      if(moveable is Person)
    //      {
    //          var person = (Person)moveable;
    //          Console.WriteLine(person.FullName());
    //      }

    //      Console.WriteLine(moveable.Move());
    //      Console.WriteLine(moveable.Move(2));

    //  }

    //  public static void DoThis(Person person, Point3D point)
    //{
    //      person.Age = 100;
    //      point.z = 1_000_000;
    //} 
}
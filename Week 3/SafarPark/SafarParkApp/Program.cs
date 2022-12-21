using System.Net.Cache;
using VehicleClassApp;

namespace SafarParkApp;

public class Program
{
    static void Main(string[] args)
    {
        var bobOne = new Person("Bob", "Builder");
        var bobTwo = new Person("Bob", "Builder");

        bobTwo.Age = 36;

        Console.WriteLine("BobOne is BobTwo? " + bobOne.Equals(bobTwo));


        var cesna = new Airplane(5);
        var bushPlane = new Airplane(5);
        bushPlane.Ascend(300);

        bool isTheSame = cesna == bushPlane;

        Console.WriteLine("Cesna is bushPlant? " +isTheSame);

        List<Airplane> planes = new()
        {
            cesna,
            bushPlane,
            new Airplane(15) {Altitude = 200}
        };

        planes.Sort();
         
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
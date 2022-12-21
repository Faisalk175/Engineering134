
using SafariParkApp;
using System.Security.AccessControl;

namespace SafarParkApp;

public class Hunter : Person, IShootable
{
    public IShootable Shooter
    {
        get; set;
    }


    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;

    }

    public string Shoot()
    {
        return $"{FullName()} {Shooter}";
    }



}

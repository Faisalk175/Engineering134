
using System.Security.AccessControl;

namespace SafarParkApp;

public class Hunter : Person
{
    private string _camera;

    public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
    {
        _camera = camera;
        Hunter h = new();
        Console.WriteLine(h.Shoot());
    }

    public Hunter() { }


    public string Shoot()
    {
        return $"{FullName()} has taken a photo with their {_camera}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} and a {_camera} camera";
    }

    public override string FullName()
    {
        return base.FullName() + " " + _camera;
    }


}

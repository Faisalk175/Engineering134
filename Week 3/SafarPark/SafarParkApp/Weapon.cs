
using SafariParkApp;

namespace SafarParkApp;

public abstract class Weapon : IShootable
{
    public string _brand = "";
    public IShootable shooter
    { 
    
        get; set;
    }
    public Weapon(string brand)
    {
        _brand = brand;
    }

    public virtual string Shoot()
    {
        return $"Shooting a {Shoot}";
    }

    public override string ToString()
    {
        return $"Weapon {_brand} {shooter}";
    }

}

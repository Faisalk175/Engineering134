
namespace SafarParkApp
{
    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
            _brand = brand;

        }
        public override string Shoot()
        {
            return $"PSHH!";
        }

        public override string ToString()
        {
            return $"Weapon {_brand} {Shoot()}";
        }

    }
}

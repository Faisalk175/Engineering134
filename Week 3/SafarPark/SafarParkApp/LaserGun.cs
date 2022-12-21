

namespace SafarParkApp
{
    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"ZAPP!";
        }

        public override string ToString()
        {
            return $"Weapon {_brand} {Shoot()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public enum WeaponType
    {
        Waterpistol,
        LaserGun,
        BubbleBlaster
    }
    public abstract class Weapon : IShootable
    {
        
        private string _brand;
        public Weapon(WeaponType type, string brand)
        {
            _weaponType = type;
            _brand = brand;
        }
        public override string ToString()
        {
            string result = $"{base.ToString()} - {_brand}";
            switch (_weaponType)
            {
                case WeaponType.Waterpistol:
                    result = "Splash!! " + result;
                     break;
                case WeaponType.BubbleBlaster:
                    result = "Bubbles... " + result;
                    break;
                case WeaponType.LaserGun:
                    result = "Zing!! " + result;
                    break;
            }
            return result;
        }

        public virtual string Shoot()
        {
            return $"Shooting a {_weaponType}";
        }
    }
    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand) { }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand) { } 

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}



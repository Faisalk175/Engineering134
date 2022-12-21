
using SafariParkApp;

namespace SafarParkApp
{
    public class Camera : IShootable
    {
        private string _brand = "";

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Click";
        }


        public override string ToString()
        {
            return $"{_brand} " + $"{Shoot()}";
        }

    }
}

using SafarParkApp;

namespace WeaponTest
{
    public class Tests
    {

        [Test]
        public void GivenCameraPentax_WhenNishMandalCreated_ReturnNishShootingPentax()
        {
            Camera cam = new Camera("Pentax");
            Hunter Nish = new Hunter("Nish", "Mandal", cam);

            var result = Nish.Shoot();

            Assert.That(result, Is.EqualTo("Nish Mandal Pentax Click"));
        }

        [Test]
        public void GivenWeaponSupersoaker_WhenNishMandalCreated_ReturnNishSplash()
        {
            WaterPistol water = new WaterPistol("Supersoaker");
            Hunter Nish = new Hunter("Nish", "Mandal", water);

            var result = Nish.Shoot();

            Assert.That(result, Is.EqualTo("Nish Mandal Weapon Supersoaker PSHH!"));
        }
        [Test]
        public void GivenWeaponRayGun_WhenNishMandalCreated_ReturnNishZing()
        {

            LaserGun ray = new LaserGun("RayGun");
            Hunter Nish = new Hunter("Nish", "Mandal", ray);
            var result = Nish.Shoot();

            Assert.That(result, Is.EqualTo("Nish Mandal Weapon RayGun ZAPP!"));
        }
    }
}

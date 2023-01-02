using SafarParkApp;
namespace SafariParkTests;

public class VehicleTests
{

    [TestCase(0)]
    [TestCase(10)]
    [TestCase(20)]

    public void WhenGivenDifferentSpeeds_Vehicle_ConstructsCorrectly(int speed)
    {
        var v = new Vehicle(20, speed);
        Assert.That(v.Speed, Is.EqualTo(speed));
    } 

    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        //Arrange
        Vehicle v = new Vehicle();
        //Act
        var result = v.Move(2);
        //Assert
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);
    }
}
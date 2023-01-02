using SafarParkApp;

namespace PersonTests;

public class PersonTests
{
    //Checking that height can only be set values between 0 and 200
    [TestCase(0)]
    [TestCase(100)]
    [TestCase(200)]
    public void GivenValidValue_SetHeight_UpdatesValue(int height)
    {
        Person testPerson = new() { Height = height};
        int expectedHeight = height;
        int actualHeight = testPerson.Height;

        Assert.That(actualHeight, Is.EqualTo(expectedHeight));
    }

    
}
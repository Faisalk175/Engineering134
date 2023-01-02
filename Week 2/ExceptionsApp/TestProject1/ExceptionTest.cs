using ExceptionsApp;


namespace ExceptionTests
{
    public class Tests
    {
        [TestCase(0)]
        [TestCase(-99)]
        public void WhenMarkIsLessThanOne_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(
                () => Program.Grade(mark),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Mark cannot be out the range 1 to 100"));
        }
    }
}
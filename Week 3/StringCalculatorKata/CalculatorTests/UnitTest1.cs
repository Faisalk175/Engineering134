
using StringCalculatorKata;
namespace CalculatorTests
{
    public class Tests
    {
      
        [Test]
        public void Given1And2_Add_Return3()
        {
            string input = "1,2";

            int output = Program.Add(input);

            Assert.That(output, Is.EqualTo(3));
        }


        [Test]
        public void GivenUnknownAmount_Add_Return9()
        {
            string input = "1,2,6";

            int output = Program.Add(input);

            Assert.That(output, Is.EqualTo(9));
        }

        [Test]
        public void Given1_2_NewLine3_Add_Return6()
        {
            string input = "1,2\n3";

            int output = Program.Add(input);

            Assert.That(output, Is.EqualTo(6));
        }





    }
}
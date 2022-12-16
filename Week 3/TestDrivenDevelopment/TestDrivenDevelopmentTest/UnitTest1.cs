using TestDrivenDevelopmentApp;

namespace TestDrivenDevelopmentTest;

public class TDDTests
{
  

    [Test]
    public void Given1_FizzBuzz_Returns1()
    {
        int maxValue = 1;
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo("1"));
    }

    [Test]
    public void GIven2_FizzBuzz_Returns12()
    {
        int maxValue = 2;
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo("1 2"));
    }

    

    [Test]
    public void Given3_FizzBuzz_Returns12Fizz()
    {
        int maxValue = 3;
        string expectedValue = "1 2 Fizz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));
    }

    [Test]
    public void GivenMaximumValueOfFive_FizzBuzz_ReturnsAllNumbersInARow()
    {
        int maxValue = 5;
        string expectedValue = "1 2 Fizz 4 Buzz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));
    }

    [Test]
    public void GivenSomeMaximumValue_FizzBuzz_ReturnsAllNumbersInARow()
    {
        int maxValue = 10;
        string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));
    }

    [Test]
    public void GivenMaximumValeOf30_FizzBuzz_ReturnsAllNumbersInARow()
    {
        int maxValue = 30;
        string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));
    }


}
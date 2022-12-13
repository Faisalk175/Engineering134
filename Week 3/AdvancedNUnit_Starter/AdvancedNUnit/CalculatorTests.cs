using NuGet.Frameworks;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]

        public void PlayingWithConstraints()
        {
            //Arrange
            var subject = new Calculator { Num1 = 6 };

            //Act & Assert
            Assert.That(subject.DivisibleBy3());
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3(), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
            

        }

        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };

            var expectedStr = "AdvancedUnit.Calculator";
            Assert.That(subject.ToString(), Is.EqualTo(expectedStr));
            Assert.That(subject.ToString(), Does.Not.Contain("Potato").IgnoreCase);
            Assert.That(subject.ToString(), Is.Not.Empty);
        }

        public void RangeConstraint()
        {
            List<int> myDiceRolls = new() { 6, 6 };
            //var myDiceRolls2 = new List<int>() { 6, 6 };

            Assert.That(myDiceRolls[0], Is.InRange(1, 6));
            Assert.That(myDiceRolls, Is.All.InRange(1, 6));
           

        }

        public void StartWithConstraint()
        {
            string phrase = "work!";
            Assert.That(phrase, Does.StartWith("wor"));
        }

        public void ArrayRangeConstraint()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.That(numbers, Has.Exactly(2).InRange(1, 10));
        }

        public void ArrayChecker()
        {
            int[] arraycheck = Enumerable.Range(1, 99).ToArray();
            Assert.That(arraycheck.Length, Is.EqualTo(99));
        }

    }

    
}
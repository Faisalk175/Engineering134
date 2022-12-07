using CodeToTest;

namespace UnitTests
{
    public class Tests
    {

        [Test]
        public void GivenTImeOf8_GetGreeting_ReturnsGoodMorning()
        {
            // given time of 8
            //Arrange our precondition
            int time = 8;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good morning!"
            Assert.That(output, Is.EqualTo("Good morning!"));
        }

        [Test]
        public void GivenTImeOf14_GetGreeting_ReturnsGoodAfternoon()
        {
            // given time of 14
            //Arrange our precondition
            int time = 14;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good afternoon!"
            Assert.That(output, Is.EqualTo("Good afternoon!"));
        }

        [Test]
        public void GivenTImeOf21_GetGreeting_ReturnsGoodEvening()
        {
            // given time of 21
            //Arrange our precondition
            int time = 21;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GivenTImeOf3_GetGreeting_ReturnsGoodEvening()
        {
            // given time of 3
            //Arrange our precondition
            int time = 3;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good evening!"));
        }

        [TestCase(5)]
        [TestCase(11)]
        public void GivenMorningBoundaryValues_GetGreeting_ReturnsGoodMorning(int timeOfDay)
        {
            // given time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good morning!"));
        }

        [TestCase(12)]
        [TestCase(18)]
        public void GivenAfternoonBoundaryValues_GetGreeting_ReturnsGoodAfternoon(int timeOfDay)
        {
            // given time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good afternoon!"));
        }

        [TestCase(19)]
        [TestCase(23)]
        public void GivenEveningBoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            // given time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good evening!"));
        }
        [TestCase(0)]
        [TestCase(4)]
        public void GivenLateEveningBoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            // given time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good evening!"
            Assert.That(output, Is.EqualTo("Good evening!"));
        }
    }
    public class Classification_Tests
    {
        [TestCase(0)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenAgeUnder12_GetAvaiableClassifications_ReturnsUandPG(int ageOfViewer)
        {
            int age = ageOfViewer;

            string output = Program.AvailableClassifications(age);

            Assert.That(output, Is.EqualTo("U & PG films are available."));
        }

        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        public void GivenAgeUnder15_GetAvaiableClassifications_ReturnsUandPGand12(int ageOfViewer)
        {
            int age = ageOfViewer;

            string output = Program.AvailableClassifications(age);

            Assert.That(output, Is.EqualTo("U, PG & 12 films are available."));
        }

        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        public void GivenAgeUnder18_GetAvaiableClassifications_ReturnsUandPGand12and15(int ageOfViewer)
        {
            int age = ageOfViewer;

            string output = Program.AvailableClassifications(age);

            Assert.That(output, Is.EqualTo("U, PG, 12 & 15 films are available."));
        }

        [TestCase(18)]
        public void GivenAge18_GetAvaiableClassifications_ReturnsUandPGand12and15and18(int ageOfViewer)
        {
            int age = ageOfViewer;

            string output = Program.AvailableClassifications(age);

            Assert.That(output, Is.EqualTo("U, PG, 12, 15 & 18 films are available."));
        }

        [TestCase(19)]
        [TestCase(25)]
        [TestCase(32)]
        public void GivenAgeOver18_GetAvaiableClassifications_ReturnsAllFilmsAvailable(int ageOfViewer)
        {
            int age = ageOfViewer;

            string output = Program.AvailableClassifications(age);

            Assert.That(output, Is.EqualTo("All films are available."));
        }
    }
}

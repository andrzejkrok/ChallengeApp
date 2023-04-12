namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void NumberShouldReturnDifferentValue()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;
            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetFloatValuesShouldReturnEquals()
        {
            // arrange
            float number1 = 1.5f;
            float number2 = 3.47f;

            // act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CreateEmployeeShouldReturnDifferentObjects()
        {
            // arrange
            var employee1 = CreateEmployee("Dawid", "Wilk", "32");
            var employee2 = CreateEmployee("Ela", "Nowak", "25");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee CreateEmployee(string name, string surmame, string age)
        {
            return new Employee("Dawid", "Wilk", "32");
        }
    }
}

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Dawid", "Wilk", "32");
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(1);
            employee.AddScore(-4);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(9, result);
        }
    }
}
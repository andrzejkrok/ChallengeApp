
using ChallengeApp;

namespace EmployeeTests;

public class EmployeeTests
{
    [Test]
    public void GetStatisticShouldReturnEmployeeMinGrade()
    {
        var employee = new Employee("Dawid", "Wilk");
        employee.AddGrade(2);
        employee.AddGrade(7);
        employee.AddGrade(6);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(2, statistics.Min);
    }
    [Test]
    public void GetStatisticShouldReturnEmployeeMaxGrade()
    {
        var employee = new Employee("Dawid", "Wilk");
        employee.AddGrade(2);
        employee.AddGrade(7);
        employee.AddGrade(6);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(7, statistics.Max);
    }
    [Test]
    public void GetStatisticShouldReturnEmployeeAverageGrade()
    {
        var employee = new Employee("Dawid", "Wilk");
        employee.AddGrade(2);
        employee.AddGrade(7);
        employee.AddGrade(6);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(5, statistics.Average);
    }
}

using ChallengeApp;

namespace EmployeeTests;

public class EmployeeTests
{
    [Test]
    public void WriteNumberValue_ShouldReturnAverageAsLetter()
    {
        var employee = new Employee();
        employee.AddGrade('A');
        employee.AddGrade(47);
        employee.AddGrade('E');
        employee.AddGrade('D');
        employee.AddGrade(2);
        employee.AddGrade(4);

        var statistics = employee.GetStatistics();

        Assert.AreEqual('D', statistics.AverageLetter);
    }
    [Test]
    public void WriteNumberValue_ShouldReturnAverage()
    {
        var employee = new Employee();
        employee.AddGrade(30);
        employee.AddGrade(80);
        employee.AddGrade(100);


        var statistics = employee.GetStatistics();
        Assert.AreEqual(70, statistics.Average);
    }
    [Test]
    public void GetMaxStatisticsValue()
    {
        var employee = new Employee();
        employee.AddGrade('A');
        employee.AddGrade('B');
        employee.AddGrade('C');

        var statistics = employee.GetStatistics();

        Assert.AreEqual(100, statistics.Max);
    }

    [Test]
    public void GetMinStatisticsValue()
    {
        var employee = new Employee();
        employee.AddGrade('A');
        employee.AddGrade('B');
        employee.AddGrade('C');

        var statistics = employee.GetStatistics();

        Assert.AreEqual(60, statistics.Min);
    }
}
using ChallengeApp;

var employee = new Employee("Kuba", "Zasada");
employee.AddGrade("Kuba");
employee.AddGrade("2000");
employee.AddGrade(6000111215512151200);
employee.AddGrade(6.5);
employee.AddGrade(200);
employee.AddGrade(3.5); 
employee.AddGrade(20);
employee.AddGrade(60);
employee.AddGrade(60);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

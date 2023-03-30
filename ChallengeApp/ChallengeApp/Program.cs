using ChallengeApp;

Employee employee1 = new Employee("Dawid", "Wilk", "32");
Employee employee2 = new Employee("Ela", "Nowak", "25");
Employee employee3 = new Employee("Kuba", "Białek", "39");

employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);

employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);

employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);

List<Employee> employers = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employerWithMaxResult = null;

foreach (var employee in employers)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employerWithMaxResult = employee;
    }
}


Console.WriteLine("Najwyższą liczbę punktów zdobył/-a " + employerWithMaxResult.Name + " " + employerWithMaxResult.Surname);
Console.WriteLine("W wieku " + " " + employerWithMaxResult.Age + " " + "lat");
Console.WriteLine("z wynikiem" + " " + employerWithMaxResult.Result);


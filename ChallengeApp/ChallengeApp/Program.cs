string name = "Ewa";
string sex = "kobieta";
var age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("Nieletni mężczyzna");
}
else
{
    Console.WriteLine("Ktoś inny");
}
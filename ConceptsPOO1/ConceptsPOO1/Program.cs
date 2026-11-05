using ConceptsPOO1;

Console.WriteLine("Concepts POO");
Console.WriteLine("============");
/*try
{
	Console.WriteLine(new Date(2022, 02, 28));
    Console.WriteLine(new Date(2026, 11, 30));
    Console.WriteLine(new Date(2013, 12, 18));
	Console.WriteLine(new Date(2026, 04, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}
*/
Employee employee1 = new SalaryEmployee()
{
    id = 100,
    FirstName = "Oswaldo",
    LastName = "Sierra",
    BirthDate = new Date(1990, 05, 12),
    HiringDate = new Date(2020, 01, 15),
    IsActive = true,
    Salary = 1800000.45m
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    id = 101,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1995, 05, 12),
    HiringDate = new Date(2020, 01, 15),
    IsActive = true,
    Sales = 20000000,
    CommissionPercentaje = 0.03f
};
Console.WriteLine(employee2);
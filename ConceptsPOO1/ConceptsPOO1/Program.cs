using ConceptsPOO1;
using System.Linq.Expressions;

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
    id = 101,
    FirstName = "Oswaldo",
    LastName = "Sierra",
    BirthDate = new Date(1990, 05, 12),
    HiringDate = new Date(2020, 01, 15),
    IsActive = true,
    Salary = 1800000.45m
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    id = 102,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1995, 05, 12),
    HiringDate = new Date(2020, 01, 15),
    IsActive = true,
    Sales = 30000000,
    CommissionPercentaje = 0.03f
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    id = 103,
    FirstName = "Maria",
    LastName = "Gonzalez",
    BirthDate = new Date(1998, 05, 12),
    HiringDate = new Date(2020, 01, 15),
    IsActive = true,
    Hours = 200,
    HourValue = 20000.50m
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    id = 104,
    FirstName = "Pedro",
    LastName = "Lopez",
    BirthDate = new Date(2008, 05, 12),
    HiringDate = new Date(2026, 01, 15),
    IsActive = true,
    Base = 800000,
    Sales = 23000000,
    CommissionPercentaje = 0.015f
    
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    Console.WriteLine("--------------------------------------------------");
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                          ========================");
Console.WriteLine($"Total            {$"{payroll:C2}", 31}");

Invoice invoice1= new Invoice()
{
    id = 1,
    Description = "Ipone 13",
    Quantity = 6,
    Price = 4000000.00m
};
Invoice invoice2 = new Invoice()
{
    id = 2,
    Description = "Punta de Anca Premiun",
    Quantity = 6,
    Price = 30000.00m
};

Invoice invoice3 = new Invoice()
{
    id = 3,
    Description = "Muda de Ropa Dotación",
    Quantity = 10,
    Price = 250000.00m
};
Console.WriteLine("==================== COMPRAS ========================");
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
Console.WriteLine(invoice3);

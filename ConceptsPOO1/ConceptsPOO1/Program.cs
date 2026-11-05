using ConceptsPOO1;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
try
{
	Console.WriteLine(new Date(2022, 02, 28));
    Console.WriteLine(new Date(2026, 11, 31));
    Console.WriteLine(new Date(2013, 12, 18));
	Console.WriteLine(new Date(2026, 04, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}

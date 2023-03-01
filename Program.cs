using ConsoleApp1;

QuadraticEquation rovnice = new QuadraticEquation(2, 5, 2);

Console.WriteLine(rovnice.Discriminant());
Console.WriteLine(rovnice.RootCount());
foreach (var x in rovnice.Roots())
{
    Console.WriteLine(x);
}
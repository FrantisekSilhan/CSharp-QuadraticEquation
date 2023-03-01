using ConsoleApp1;

QuadraticEquation rovnice = new QuadraticEquation(0, -6, 8);

Console.WriteLine(rovnice.Discriminant());
Console.WriteLine("---");
Console.WriteLine(rovnice.RootCount());
Console.WriteLine("---");
foreach (var x in rovnice.Roots())
{
    Console.WriteLine(x);
}
Console.WriteLine("---");
foreach (var x in rovnice.Vertex())
{
    Console.WriteLine(x);
}
Console.WriteLine("---");
Console.WriteLine(rovnice.Value(6));
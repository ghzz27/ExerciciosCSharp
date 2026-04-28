// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

int N;
Console.WriteLine("Digite um numero: ");
N = int.Parse(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine("F1");
}
else if (N <= 100)
{
    Console.WriteLine("F2");
}
else if (N > 100)
{
    Console.WriteLine("F3");
}
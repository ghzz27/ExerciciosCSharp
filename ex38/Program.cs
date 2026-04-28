// See https://aka.ms/new-console-template for more information

int A, B, C, soma;
Console.WriteLine("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
C = int.Parse(Console.ReadLine());
soma = A + B;

if (soma < C)
{
    Console.WriteLine("menor");
}
else if (soma > C)
{
    Console.WriteLine("Maior");
}
else
{
    Console.WriteLine("Igual");
}

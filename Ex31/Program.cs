// See https://aka.ms/new-console-template for more information
int A, B;
Console.WriteLine("Digite o  valor de A: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("O Maior valor e de A: " + A);
}
else if (B > A)
{
    Console.WriteLine("O maior valor e de B: " + B);
}
else
{
    Console.WriteLine("Os Valores são iguais");
}

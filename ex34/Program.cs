// See https://aka.ms/new-console-template for more information
int A, B, C, vazia;
Console.WriteLine("Digite o primeiro valor:");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor:");
C = int.Parse(Console.ReadLine());

if (A > B)
{
    vazia = A;
    A = B;
    B = vazia;
}

if (A > C)
{
    vazia = C;
    A = C;
    C = vazia;
}

if (B > C)
{
    vazia = B;
    B = C;
    C = vazia;
}

Console.WriteLine("A ordem crescente é : " + A + ", " + B + ", " + C);




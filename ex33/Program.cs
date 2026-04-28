// See https://aka.ms/new-console-template for more information
double f1, f2, f3, media;

Console.WriteLine("Digite o valor da primeira nota da prova: ");
f1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da segunda nota da prova: ");
f2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da terceira nota da prova: ");
f3 = double.Parse(Console.ReadLine());

media = (f1 * 2 + f2 * 3 + f3 * 5 ) / 10;

Console.WriteLine("A media final deste aluno foi de: " + media);


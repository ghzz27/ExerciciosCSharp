// See https://aka.ms/new-console-template for more information
int salario1, C, V, salarioFixo, CC, CV, salarioTotal;

Console.WriteLine(("Qual valor do salario minimo?"));
salario1 = int.Parse(Console.ReadLine());

Console.WriteLine(("Quantos carros vendidos ?"));
C = int.Parse(Console.ReadLine());

Console.WriteLine(("Valor total das vendas ?"));
V = int.Parse(Console.ReadLine());

salarioFixo = salario1 * 2;
CC = C * 50;
CV = V * 5 / 100;
salarioTotal = salarioFixo + CC + CV;

Console.WriteLine(("Salario fixo (2 salarios minimos): " + salarioFixo));
Console.WriteLine(("Comissao de carros vendidos: " + CC ));
Console.WriteLine(("Comissao das vendas: " + CV ));
Console.WriteLine(("Salario total de vendedor: " + salarioTotal));




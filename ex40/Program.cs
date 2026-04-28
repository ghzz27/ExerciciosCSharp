// See https://aka.ms/new-console-template for more information
String nomeCliente;
int qtdParafusos, qtdPorcas, qtdArruelas;
double precoParafuso, precoPorca, precoArruela, totalCompra, totalBruto, totalDesconto;
double descontoParafusos, descontoPorcas, descontoArruelas;
double totalParafusos, totalPorcas, totalArruelas;

Console.Write("Digite o nome do cliente: ");
nomeCliente = Console.ReadLine();

Console.Write("Preço do parafuso: ");
precoParafuso = double.Parse(Console.ReadLine());

Console.Write("Preço da porca: ");
precoPorca = double.Parse(Console.ReadLine());

Console.Write("Preço da arruela: ");
precoArruela = double.Parse(Console.ReadLine());

Console.Write("Quantidade de parafusos: ");
qtdParafusos = int.Parse(Console.ReadLine());

Console.Write("Quantidade de porcas: ");
qtdPorcas = int.Parse(Console.ReadLine());

Console.Write("Quantidade de arruelas: ");
qtdArruelas = int.Parse(Console.ReadLine());

totalParafusos = precoParafuso * qtdParafusos;
totalPorcas = precoPorca * qtdPorcas;
totalArruelas = precoArruela * qtdArruelas;

descontoParafusos = totalParafusos * 0.20;
descontoPorcas = totalPorcas * 0.10;
descontoArruelas = totalArruelas * 0.30;

totalDesconto = descontoParafusos + descontoPorcas + descontoArruelas;

totalCompra = (totalParafusos + totalPorcas + totalArruelas) - totalDesconto;


Console.WriteLine("Cliente: " + nomeCliente);
Console.WriteLine("Quantidade de parafusos: " + qtdParafusos);
Console.WriteLine("Quantidade de porcas: " + qtdPorcas);
Console.WriteLine("Quantidade de arruelas: " + qtdArruelas);
Console.WriteLine("Total de desconto: R$ " + totalDesconto);
Console.WriteLine("Total a pagar: R$ " + totalCompra);


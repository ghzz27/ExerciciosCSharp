// See https://aka.ms/new-console-template for more information

int compra, pagar, troco, notas100, restante, notas10, notas1;

Console.WriteLine(("Qual o valor da compra ?"));
compra = int.Parse(Console.ReadLine());

Console.WriteLine(("Qual valor pago ?"));
pagar = int.Parse(Console.ReadLine());

troco = pagar - compra;
notas100 = (troco / 100);
restante = troco % 100;
notas10 = (restante / 10);
restante = restante % 10;
notas1 = restante;

Console.WriteLine(("Valor da compra: " + compra ));
Console.WriteLine(("Valor pago: " + pagar ));
Console.WriteLine(("troco: " + troco));
Console.WriteLine(("Notas de 100: " + notas100));
Console.WriteLine(("Notas de 10: " + notas10));
Console.WriteLine(( "Notas de 1: " + notas1));
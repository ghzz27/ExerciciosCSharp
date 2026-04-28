// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
string N1, N2, N3;
double comissao1, comissao2, comissao3, vendas1, vendas2, vendas3, total;

Console.WriteLine("Qual o nome do primeiro corretor ?");
N1 = Console.ReadLine();

Console.WriteLine("Qual o nome do segundo corretor ?");
N2 = Console.ReadLine();

Console.WriteLine("Qual o nome do corretor terceiro ?");
N3 = Console.ReadLine();


Console.WriteLine(("Quantas vendas fez o primeiro corretor?"));
vendas1 = int.Parse(Console.ReadLine());                             

Console.WriteLine(("Quantas vendas fez o segundo corretor??"));
vendas2 = int.Parse(Console.ReadLine());

Console.WriteLine(("Quantas vendas fez o terceiro corretor??"));
vendas3 = int.Parse(Console.ReadLine());




total = 0;

 /////////////////
    
    if(vendas1 > 5000000){
    comissao1 = vendas1 * 0.12;

    }else if (vendas1 >= 3000000)
{
    comissao1 = vendas1 * 0.095;
}
else
{
    comissao1 = vendas1 * 0.07;
    }

total = total + vendas1;

 //////////////////////

     if (vendas2 > 5000000)
{
    comissao2 = vendas2 * 0.12;

    }
else if (vendas2 >= 3000000)
{
    comissao2 = vendas2 * 0.095;
}
else
{
    comissao2 = vendas2 * 0.07;
    }

total = total + vendas2;

///////////////////////

     if (vendas3 > 50000)
{
    comissao3 = vendas3 * 0.12;

    }
else if (vendas3 >= 30000)
{
    comissao3 = vendas3 * 0.095;
}
else
{
    comissao3 = vendas3 * 0.07;
    }

total = total + vendas3;

/////////////////////////

     Console.WriteLine(("Nome: " + N1 + "| Vendas: " + vendas1 + "| comissao1: " + comissao1));
     Console.WriteLine(("Nome: " + N2 + "| Vendas: " + vendas2 + "| comissao2: " + comissao2));
     Console.WriteLine(("Nome: " + N3 + "| Vendas: " + vendas3 + "| comissao3: " + comissao3));

Console.WriteLine(("Total de vendas de empresa: " + total));

///////////////////////

// See https://aka.ms/new-console-template for more information

using System;

string nome;
double PT, MT, CG, media;


Console.WriteLine("Qual o seu nome");
nome = Console.ReadLine();

Console.WriteLine("Qual a nota da nota de portugues? ");
PT = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a nota da nota de matematica? ");
MT = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a nota da nota de Conhecimentos gerais? ");
CG = double.Parse(Console.ReadLine());

media = (PT + MT + CG ) / 3;
Console.WriteLine("A sua media foi: " + media);
if (media >= 7.0)
{
    Console.WriteLine ("Aprovado");
          }
else if (media < 5.0)
{
    Console.WriteLine("Reprovado");
          }

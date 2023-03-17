// See https://aka.ms/new-console-template for more information
/*
Três amigos jogaram na loteria desportiva. Caso eles ganhem, o prêmio deve
ser repartido de forma proporcional ao valor que cada um investiu. Desenvolva
um programa para ler o valor investido por cada amigo e o valor do prêmio.
Mostre na tela, o valor que cada um irá receber.
*/
using System;

namespace Exercice
{
    class Exercice07{
        static void Main(string[] agrs){
            const double premio = 1000000;
            double valor_1, valor_2, valor_3, valorTotal;
            double percent_1, percent_2, percent_3;
            Console.Write("Valor do Primeiro (Kz): ");
            valor_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor do Segundo (Kz): ");
            valor_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor do Terceiro (Kz): ");
            valor_3 = Convert.ToDouble(Console.ReadLine());

            valorTotal = valor_1 + valor_2 + valor_3;

            percent_1 = (valor_1)/valorTotal;
            percent_2 = (valor_2)/valorTotal;
            percent_3 = (valor_3)/valorTotal;
            
            valor_1 = percent_1*premio;
            valor_2 = percent_2*premio;
            valor_3 = percent_3*premio;

            Console.WriteLine("=================================================");
            Console.WriteLine("Premio Total: {0}.00 (Kz)", premio);
            Console.WriteLine("Premio do Primeiro: {0} (Kz)", (Math.Round(valor_1, 2)));
            Console.WriteLine("Premio do Segundo: {0} (Kz)", (Math.Round(valor_2, 2)));
            Console.WriteLine("Premio do Terceiro: {0} (Kz)", (Math.Round(valor_3, 2)));
            Console.WriteLine("=================================================");
        }
    }    
}

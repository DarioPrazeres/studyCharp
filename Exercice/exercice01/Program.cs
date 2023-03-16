// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Desenvolva um programa para trocar o valor de duas variáveis, a e b, de
tal modo que, no fim da execução, b possua o valor de a e vice-versa.
*/
using System;

namespace Exercice
{
    class Exercice01{
        static void Main(string[] agrs){
            //Var section
            int a, b, aaux, baux;       
            Console.WriteLine("Digite o Valor de A");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o Valor de B");
            b = Convert.ToInt16(Console.ReadLine());
            baux = a;
            aaux = b;
            a = aaux;
            b = baux;
            Console.WriteLine("O valor de A: " + a);
            Console.WriteLine("O valor de B: " + b);
        }
    }
}

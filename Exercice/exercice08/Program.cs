// See https://aka.ms/new-console-template for more information
/*
Desenvolva um programa para efectuar a troca de três variáveis a, b e c de
tal forma que, no final, b contém o valor de a, c contém o valor de b, e a contém
o valor de c. Por exemplo, para a = 5, b = 10 e c = 8, teríamos a= 8, b= 5 e c =
10.
*/
using System;

namespace Exercice
{
    class Exercice08{
        static void Main(string[] agrs){
            int A,B, C, Aaux, Baux, Caux;
            Console.Write("Digite o Valor de A: ");
            A = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o Valor de B: ");
            B = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o Valor de C: ");
            C = Convert.ToInt16(Console.ReadLine());
            Aaux = A;
            Baux = B;
            Caux = C;
            A = Caux;
            B = Aaux;
            C = Baux;
            Console.WriteLine("Novo Valor de A: "+ A);
            Console.WriteLine("Novo Valor de B: "+ B);
            Console.WriteLine("Novo Valor de C: "+ C);
        }
    }
}

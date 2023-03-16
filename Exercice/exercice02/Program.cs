// See https://aka.ms/new-console-template for more information
/*
Desenvolva um programa para ler um número inteiro e mostrar na tela a
soma do triplo do seu sucessor pelo dobro do seu antecessor.
*/
using System;

namespace Exercice
{
    class Exercice02{
        static void Main(string[] agrs){
            int number, sum;
            Console.WriteLine("Digite um Numero");
            number = Convert.ToInt16(Console.ReadLine());
            sum = 3*(number -1) + 2*(number + 1);
            Console.WriteLine("A soma entre o Sucessor e o antecessor: " + sum);
        }
    }
}

/*
Desenvolva um programa para ler um número real, e mostrar na tela o valor
absoluto desse número.
*/
using System;
namespace Exercice
{
    class Exercice11{
        static void Main(string[] agrs){
            double number;
            Console.Write("Insert a Number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The ABS is: {0}", Math.Abs(number));
        }
    }
}

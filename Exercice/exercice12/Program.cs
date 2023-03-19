/*
Desenvolva um programa para ler um número inteiro e verificar se esse
número é par ou impar.
*/
using System;
namespace Exercice
{
    class Exercice11{
        static void Main(string[] agrs){
            int number;
            Console.Write("Insert a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number%2)
            {
                case 0 : Console.WriteLine("The Number is Par"); break;                
                default: Console.WriteLine("The Number is not Par"); break;
            }
        }
    }
}

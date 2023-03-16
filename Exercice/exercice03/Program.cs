// See https://aka.ms/new-console-template for more information
/*
Desenvolva um programa para ler um número qualquer e mostrar na tela o
algarismo das dezenas.
*/
using System;

namespace Exercice
{
    class Exercice03{
        static void Main(string[] agrs){
            int number, dezena;
            Console.WriteLine("Digite o Numero");
            number =  Convert.ToInt16(Console.ReadLine());
            dezena = (number/10)%10;
            Console.WriteLine("Dezena: " + dezena);
        }
    }    
}

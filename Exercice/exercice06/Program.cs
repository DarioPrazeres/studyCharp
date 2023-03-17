// See https://aka.ms/new-console-template for more information
/*
Desenvolva um programa para ler um número inteiro menor do que 1000, e
mostrar na tela a soma dos seus dígitos. Por exemplo: 397 é igual a 3+9+7 = 19.
*/
using System;

namespace Exercice
{
    class Exercice06{
        static void Main(string[] agrs){
            int centena, dezena, unidade, numero;
            Console.Write("Digite o Numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            centena = numero/100;
            dezena = (numero%100)/10;
            unidade = (numero%100)%10;
            numero = centena + dezena + unidade;
            Console.WriteLine("A soma entre: {0} + {1} + {2} = {3}", centena, dezena, unidade, numero);
        }
    }    
}
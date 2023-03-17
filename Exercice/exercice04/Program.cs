// See https://aka.ms/new-console-template for more information
/*
Desenvolva um programa para ler os três lados de um triângulo. Calcular e
mostrar na tela o valor da área. Para o efeito, utilize a fórmula de Héron:
Área = √𝑠(𝑠 − 𝑎)(𝑠 − 𝑏)(𝑠 − 𝑐)
onde S = (𝒂+𝒃+𝒄)/𝟐
*/
using System;

namespace Exercice
{
    class Exercice04{
        static void Main(string[] agrs){
            double a, b, c, sum, area;
            Console.Write("Digite o Numero A: ");
            a =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Numero B: ");
            b =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Numero C: ");
            c =  Convert.ToDouble(Console.ReadLine());
            sum = (a+b+c)/2;
            area = Math.Sqrt(sum*(sum - a)*(sum - b)*(sum - c));
            Console.WriteLine("===================");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("The sum is: "+ sum);
            Console.WriteLine("The Area is: "+ Math.Round(area, 3));
        }
    }    
}

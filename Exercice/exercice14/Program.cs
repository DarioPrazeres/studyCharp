/*
Codifique um programa que, dados dois valores inteiros entre 1 e 10, calcule
e imprima: a média dos números, caso a soma deles seja menor que 8; o produto
entre os números, caso a soma deles seja igual a 8; a divisão do maior número
pelo menor, caso a soma deles seja maior que 8.
*/
using System;
namespace Exercice
{
    class Exercice14{
        static void Main(string[] agrs){
            int number_1, number_2, sum, mult, most, less;
            double media;
            Console.Write("Insert a Number 1 (1-10): ");
            number_1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert a Number 2 (1-10): ");
            number_2 = Convert.ToInt16(Console.ReadLine());
            sum = number_1 + number_2;
            if(sum < 8){
                media = (number_1 + number_2)/2;
                Console.WriteLine("The Media is: {0}", Math.Round(media, 2));
            }else if(sum == 8){
                mult = number_1 * number_2;
                Console.WriteLine("The Multiply is: {0}", mult);
            }else{
                if(number_1 > number_2){
                    most = number_1;
                    less = number_2;
                }else{
                    most = number_2;
                    less = number_1;
                }
                double div = Convert.ToDouble(most)/Convert.ToDouble(less);
                Console.WriteLine("The Divide is: {0}", div);
            }
        }
    }
}

/*
Dado o peso (kg) e a altura (m) de uma pessoa, calcular o índice de massa
corporal (IMC) e mostrar na tela a sua situação com base na seguinte tabela :

IMC = 𝑝𝑒𝑠𝑜/(𝐴𝑙𝑡𝑢𝑟𝑎 𝑥 𝐴𝑙𝑡𝑢𝑟𝑎)
IMC
Menos de 20
De 20 até 25
De 25 até 30
De 30 até 40
Acima de 40
Situação
Desnutrido
Normal
Excesso de peso
Obesidade leve
Obesidade grave
*/
using System;
namespace Exercice
{
    class Exercice15{
        static void Main(string[] agrs){
            double IMC, height, weight;
            Console.Write("Insert Your Weight (Kg): ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert Your Height (m): ");
            height = Convert.ToDouble(Console.ReadLine());
            IMC = IMCFunction(height, weight);

            if(IMC<20){
                Console.WriteLine("You are Desnutrido");
            }else if(IMC >= 20 && IMC < 25){
                Console.WriteLine("You are Good Weight");
            }else if(IMC>= 25 && IMC < 30){
                Console.WriteLine("You are weight excessive");
            }else if(IMC >= 30 && IMC < 40){
                Console.WriteLine("You are Obesity Low");
            }else{
                Console.WriteLine("You are Obesity high");
            }
        }
        static double IMCFunction(double altura, double peso){
            return peso/(altura * altura);
        }
    }
}

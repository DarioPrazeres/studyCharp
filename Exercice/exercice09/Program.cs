/*
Desenvolva um programa para calcular o salario de um professor. São
fornecidos os seguintes dados: valor da hora de trabalho, número de horas
trabalhadas e a percentagem de desconto para o INSS.
*/
using System;
namespace Exercice
{
    class Exercice09{
        static void Main(string[] agrs){
            double valueHour, numberHours, percentINSS, salario;
            Console.Write("Digite o Valor por Hora Em Kz: ");
            valueHour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Numero de Horas: ");
            numberHours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Percentagem do INSS (%): ");
            percentINSS = Convert.ToDouble(Console.ReadLine());
            salario = valueHour*numberHours;
            salario = salario - salario*(percentINSS/100);
            Console.WriteLine("O Salario Final e: {0} Kz", salario);
        }
    }
}

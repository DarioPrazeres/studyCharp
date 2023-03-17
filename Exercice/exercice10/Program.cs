/*
Uma agência de viagem pretende inovar os seus serviços, com a
conversão do seu dinheiro para as seguintes moedas: euros, dólares, rands e
libras. Sabe-se que a cotação do euro é de 14,00 Kz, do dólar 10,00 Kz, do rand
3,50 Kz e da libra 15,30 Kz. Desenvolva um programa para ler uma determinada
quantidade em kwanzas, e converter essa quantidade para essas moedas.
*/
using System;
namespace Exercice
{
    class Exercice09{
        static void Main(string[] agrs){
            double valorKz; 
            double valorEuro = 14.00; 
            double valorUs = 10.00; 
            double valorRand = 3.50;
            double valorLibra = 15.30;

            Console.Write("Digite o valor em Kz: ");
            valorKz = Convert.ToDouble(Console.ReadLine());
            valorEuro = valorKz/valorEuro;
            valorUs = valorKz/valorUs;
            valorRand = valorKz/valorRand;
            valorLibra = valorKz/valorLibra;
            Console.WriteLine("O valor em Euro: {0}",Math.Round(valorEuro, 2));
            Console.WriteLine("O valor em Dolar: {0}", Math.Round(valorUs, 2));
            Console.WriteLine("O valor em Rand: {0}", Math.Round(valorRand, 2));
            Console.WriteLine("O valor em Libra: {0}", Math.Round(valorLibra, 2));
        }
    }
}
// See https://aka.ms/new-console-template for more information
/*
Três apostadores ganharam o totobola e o valor é de um milhão de Kwanzas.
Esse valor será dividido por eles nas seguintes percentagens: O primeiro 
ganhador receberá 46%; O segundo receberá 32%; enquanto o terceiro receberá
o restante.
*/
using System;

namespace Exercice
{
    class Exercice05{
        static void Main(string[] agrs){
            const double premio = 1000000; 
            double firstWinner, secondWinner, thirdWinner;
            firstWinner = (46*premio)/100;
            secondWinner = (32*premio)/100;
            thirdWinner = premio - (firstWinner + secondWinner);
            Console.WriteLine("First Winner:" + firstWinner);
            Console.WriteLine("Second Winner:" + secondWinner);
            Console.WriteLine("Third Winner:" + thirdWinner);
        }
    }    
}
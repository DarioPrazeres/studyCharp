// See https://aka.ms/new-console-template for more information
/*
Tipos de Dados
-int
-long //Ex: long myNum = 15000000L
-double
-char 
-string
-bool
    *---Sintaxe---*
    type variableName =  value;
*/
using System;

namespace variables{
    class Program{
        
        static void Main(string[] agrs){
            string name="Dario Prazeres";
            float number_1 = 5.75F;
            double number_2 = 19.99;
            float number_3 = 35e3F;
            double number_4 = 12E4D;
            bool status = true;
            char gender = 'F';
            //About Convert Type
            int numInt = 9;
            double numDouble =  9.78;
            numInt = (int) numDouble;
            numInt = (int) number_1;

            Console.WriteLine("Hello!");
            Console.WriteLine("My name is: "+ name);
            Console.WriteLine("Number 1: " + number_1);
            Console.WriteLine("Number 2: " + (number_2 + number_1));
            Console.WriteLine("Number 3: " + number_3);
            Console.WriteLine("Number 4: " + number_4);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Convert Int To Double: " + numDouble);
            Console.WriteLine("Convert Double To Int: " + numInt);
        }
    }
}
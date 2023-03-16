// See https://aka.ms/new-console-template for more information
using System;

namespace inputOutput{
    class Program{
        static void Main(string[] agrs){
            String name;
            int age, anoNasc;
            const int anoActual = 2023;
            Console.WriteLine("Digite o seu Nome");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o ano de nascimento");
            anoNasc = Convert.ToInt16(Console.ReadLine());
            age = anoActual - anoNasc;
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
    }

}

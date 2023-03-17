/*Um cronômetro mede em segundos a quantidade de tempo decorrida entre
dois instantes. Converter o tempo de segundos para horas e de minutos para
segundos. Por exemplo:
Tempo em segundos
100
3800
Hora   
0
1
Minuto
1
3
Segundo
40
20
*/
using System;
namespace Exercice
{
    class Exercice11{
        static void Main(string[] agrs){
            int  timeSecond,hour, minute, second;
            Console.Write("Insert Time in second: ");
            timeSecond = Convert.ToInt16(Console.ReadLine());
            hour = timeSecond/3600;
            minute = (timeSecond/60)%10;
            second = (timeSecond-3600) - 3*60;
            Console.WriteLine("Time In Hour is: {0}", hour);
            Console.WriteLine("Time In Minutes is: {0}", minute);
            Console.WriteLine("Time In Seconds is: {0}", second);
        }
    }
}
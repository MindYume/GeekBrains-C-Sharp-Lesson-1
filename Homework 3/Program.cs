/*
3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


Грачёв Виктор
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            double x1 = double.Parse(askInfo("Enter x1: "));
            double y1 = double.Parse(askInfo("Enter y1: "));
            double x2 = double.Parse(askInfo("Enter x2: "));
            double y2 = double.Parse(askInfo("Enter y2: "));

            double distamce = calDistance(x1, y1, x2, y2);

            Console.WriteLine($"\nDistance: {distamce:F2}");

            Pause();
        }

        static double calDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }

        static string askInfo(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();

            return answer;
        }

        static void Pause()
        {
            Console.ReadKey();
        }
    }
}

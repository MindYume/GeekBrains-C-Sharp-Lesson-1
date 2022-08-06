/*
1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.


Грачёв Виктор
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name     = askInfo("Enter your name: ");
            string lastname = askInfo("Enter your last name: ");
            string height   = askInfo("Enter your height: ");
            string weight   = askInfo("Enter your weight: ");

            Console.WriteLine("\n" + name + " " + lastname + ", height: " + height + ", weight: " + weight);
            Console.WriteLine("{0} {1}, height: {2}, weight: {3}", name, lastname, height, weight);
            Console.WriteLine($"{name} {lastname}, height: {height}, weight: {weight}");

            Pause();
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

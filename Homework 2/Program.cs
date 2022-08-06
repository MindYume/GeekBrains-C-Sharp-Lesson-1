/*
2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.


Грачёв Виктор
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float weight = float.Parse( askInfo("Enter your weight in kilograms: ") );
            float height = float.Parse( askInfo("Enter your height in centimeters: ") );


            height = height / 100; // Перевод сантиметров в метры

            float index = weight / (height * height);
            Console.WriteLine($"\nIndex: {index}");

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

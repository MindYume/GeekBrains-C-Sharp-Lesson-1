/*
5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организовать в центре экрана.
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).


Грачёв Виктор
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string name = "Виктор";
            string lastname = "Грачёв";
            string city = "Ульяновск";

            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;

            string message = $"{name} {lastname}, город {city}";

            WriteMessage(message, windowWidth/2, windowHeight/2);

            Pause();
        }

        static void WriteMessage(string message, int x, int y)
        {
            Console.SetCursorPosition(x - message.Length/2, y);
            Console.WriteLine(message);
        }
        static void Pause()
        {
            Console.ReadKey();
        }
    }
}

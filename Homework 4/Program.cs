/*
4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
а) с использованием третьей переменной;
б) *без использования третьей переменной.


Грачёв Виктор
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // А
            int a = 5;
            int b = 6;

            int c = a;
            a = b;
            b = c;

            // Б

            int d = 10;
            int e = 4;

            (d, e) = (e, d);

        }
    }
}

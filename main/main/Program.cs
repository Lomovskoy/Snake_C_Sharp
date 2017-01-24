using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');// Создание обьекта класса
            p1.Draw();

            Point p2 = new Point(3, 5, '#');// Создание обьекта класса
            p2.Draw();

            HorizontLine lineHor = new HorizontLine( 5, 10, 8, '+');
            lineHor.Drow();

            HorizontLine lineVer = new HorizontLine(8, 12, 10, '+');
            lineVer.Drow();

            Console.ReadLine();
        }
    }
}

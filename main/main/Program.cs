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

            Console.ReadLine();
        }
    }
}

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
            //Console.SetBufferSize(90, 25);
            // Отрисовка рамок
            HorizontLine upLine = new HorizontLine(0, 78, 0, '+');
            HorizontLine downLine = new HorizontLine(0, 78, 24, '+');
            VerikalLine leftLine = new VerikalLine(0, 28, 0, '+');
            VerikalLine rightLine = new VerikalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            // Отрисовка точек
            Point p = new Point(4, 5, '*');// Создание обьекта класса
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
        }
    }
}

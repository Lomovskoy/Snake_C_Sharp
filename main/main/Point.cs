using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Point
    {
        public int x;// Данные
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)//Конструктор класса
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()// Метод класса
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

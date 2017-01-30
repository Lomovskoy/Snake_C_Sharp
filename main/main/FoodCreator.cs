using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeidth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeidth, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeidth = mapHeidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeidth - 2);
            return new Point(x, y, sym);
        }
    }
}

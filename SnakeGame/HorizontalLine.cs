using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class HorizontalLine : Figure//Naslednik Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)//Sozdanie gorizontalnih liniy
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}

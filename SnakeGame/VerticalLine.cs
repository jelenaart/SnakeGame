using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Klass naslednik ispolzuet dannie iz Figure
    class VerticalLine : Figure
    {
        //Konstruktor sozdaniya Vertikalnih Liniy
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
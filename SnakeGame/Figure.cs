using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Bazoviy klass dlya nasledovaniya drugimi klassami
    class Figure//Budet vklyu4at v sebya vse zavisimie ot nego klassi (zmeya, steni, point)
    {
        protected List<Point> pList;
        public void Draw()
        {
            //kazdaya to4ka v spiske
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        internal bool IsHit(Figure figure)//proverka na perese4enie kakih libo figur
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)//proverka na perese4enie Point
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
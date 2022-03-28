using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeGame
{
    //Klass naslednik, soderzhit dannie iz klassa Figure
    class Snake : Figure
    {
        //Napravlenie zmeiki
        public Direction direction;
        //Konstruktor dlya sozdaniya zmeiki
        public Snake(Point tail, int length, Direction _direction)
        {
            //dobavlenie to4ek v spisok
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                //Sozdanie Point
                Point p = new Point(tail);
                //Napravlenie
                p.Move(i, direction);
                //Dobavlenie Point
                pList.Add(p);
            }
        }
        //Funkciya dlya peredvizheniya zmeiki
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        //Publi4niy metod peredvizeniya zmeiki na sleduyushie koordinaty
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        internal bool IsHitTail()
        {//Proverka, bilo li perese4enie c hvostom
            var head = pList.Last();
            for (int i = 0; i < pList.Count-2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
        //Publi4niy metod, otve4ayushiy za upravlenie
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
        internal bool Eat(Point food)
        {//Proverka na polu4enie zmeikoy edi
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
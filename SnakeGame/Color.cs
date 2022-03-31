using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Color
    {
        public Color()
        { }
        public void ColorOfSnake()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Alustame!!! vajuta enter");
            string color = Console.ReadLine();
        }
    }
}
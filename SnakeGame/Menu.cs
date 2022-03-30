using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class End
    {
        public void YouLose()
        {
            int xOffset = 30;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("OI, SEE ON MÄNGU LÕPP!", xOffset, yOffset++);
            WriteText("PROOVI VEEL KORD?", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
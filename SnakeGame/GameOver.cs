using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameOver
    {
        private int score;
    }
    public GameOver(int score)
    {
        this.score=score;

    }
    public void GameOver()
    {
        Console.Clear();
        Console.SetWindowSize(80, 25);
        int xOff = 6;
        int yOff = 12;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(xOff, yOff++);
        Console.WriteLine("GAME OVER", xOff+20, yOff++);
    }

    public void Start()
        {

        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Score
    {
        public int score = 0;
        public int speed = 1;

        public Score(int score)
        {//sootvetstvie ochkam
            this.score = score;
        }
        public void ScorePlus()
        {//plus k ochkam
            score++;
        }
        public void ScorePrint()
        {//schet otobrazenie
            Console.SetCursorPosition(65, 1);
            Console.WriteLine("score " + score.ToString());
            Console.WriteLine("speed " + speed.ToString());
        }
        public void Speed(int speed)
        {
            this.speed = speed;
            int a = 30;
            while (score == speed)
            {

                Thread.Sleep(100 + a);
                a += 30;
                speed++;
            }
        }
    }
}

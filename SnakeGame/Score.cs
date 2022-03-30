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
        public int score;
        public int speed;
        public int lvl;

        public Score(int score, int lvl)
        {//sootvetstvie ochkam
            this.score = score;
            this.lvl = lvl;
        }
        public void ScorePlus()
        {//plus k ochkam
            score++;
            lvl++;
            speed++;
        }
        public void ScorePrint()
        {//schet otobrazenie
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("score " + score.ToString());
            Console.WriteLine("speed " + speed.ToString());
            Console.WriteLine("lvl"+ lvl.ToString());
        }
    }
}

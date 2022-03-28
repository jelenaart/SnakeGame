using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Score
    {
        public int score = 0;

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
        }
    }
}

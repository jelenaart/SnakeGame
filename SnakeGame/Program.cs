using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);
			//Vivod ramki na ekran, sozdanie sten
			Walls walls = new Walls(80, 25);
			walls.Draw();

			Params settings = new Params();
			Sounds sound = new Sounds(settings.GetResourceFolder());
			sound.Play("sound.mp3");
			Sounds soundeat = new Sounds(settings.GetResourceFolder());

			Score score = new Score(0);//peremennaya dlya ochkov, otobrazenie
			score.ScorePrint();

			Speed speed = new Speed();
			speed.SpeedPrint();
			
			//Vivod to4ki na ekran
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);//poyavlenie zmeiki s pervona4alnoy to4koy
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');//sozdanie edi
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)//beskone4niy cikl dlya kontrolya statusa zmeiki
			{
				if (walls.IsHit(snake) || snake.IsHitTail())//stop esli zadevaet stenu
				{
					sound.Play("lose.mp3");
					break;
				}
				if (snake.Eat(food))//sjedaet edu, dalee sozdaet novuyu edu
				{
					sound.Play("food.mp3");
					score.ScorePlus();//plus k ochkam
					score.ScorePrint();//obnovlyaet ochki
					food = foodCreator.CreateFood();
					food.Draw();

				}
				else
				{
					snake.Move();
				}
				Thread.Sleep(100);//zaderzhka zmeiki
				int a = 50;
				while (score == speed)
				{

					Thread.Sleep(100 + a);
					a += 50;
					speed++;

					if (Console.KeyAvailable)//upravlenie zmeikoy
					{
						ConsoleKeyInfo key = Console.ReadKey();
						snake.HandleKey(key.Key);
					}
				}
			}
		}
	}
}

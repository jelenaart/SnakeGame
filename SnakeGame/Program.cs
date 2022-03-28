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

			//Vivod to4ki na ekran
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);//poyavlenie zmeiki s pervona4alnoy to4koy
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');//sozdanie edi
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)//beskone4niy cikl dlya kontrolya statusa zmeiki
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}
				Thread.Sleep(100);//zaderzhka zmeiki

				if (Console.KeyAvailable)//upravlenie zmeikoy
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
		}
	}
}

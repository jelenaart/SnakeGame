using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
	class FoodCreator
	{
		private int mapWidht;//princip inkapsulyacii
		private int mapHeight;
		private char sym;

		Random random = new Random();

		public FoodCreator(int mapWidht, int mapHeight, char sym)
		//public metod, eda mozet poyavitsya po X,Y sootvetstvuyushim razmeram karti
		{
			this.mapWidht = mapWidht;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}
		public Point CreateFood()//eda po randomnim X,Y
		{
			int x = random.Next(2, mapWidht - 2);
			int y = random.Next(2, mapHeight - 2);
			return new Point(x, y, sym);
		}
	}
}
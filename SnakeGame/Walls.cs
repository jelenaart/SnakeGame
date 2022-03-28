using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeidht)
		{
			wallList = new List<Figure>();
			//Otrisovka ramki
			HorizontalLine upline = new HorizontalLine(0, mapWidth-2, 0, '*');
			HorizontalLine downline = new HorizontalLine(0, mapWidth-2, mapHeidht - 1, '*');
			VerticalLine leftline = new VerticalLine(0, mapHeidht -1, 0, '*');
			VerticalLine rightline = new VerticalLine(0, mapHeidht-1, mapWidth-2, '*');

			wallList.Add(upline);
			wallList.Add(downline);
			wallList.Add(leftline);
			wallList.Add(rightline);
		}
		internal bool IsHit(Figure figure)//proverka na perese4enie stenok
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}
		public void Draw()//otrisovka sten
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}

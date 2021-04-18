using System.Drawing;

namespace SnakeBattle
{
	public class Food : WorldObject
	{
		public Food(Point position)
		{
			Color = Color.Blue;
			Permeable = true;
			Position = position;
		}
	}
}

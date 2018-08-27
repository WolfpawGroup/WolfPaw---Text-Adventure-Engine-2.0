namespace WolfPaw_Text_Adventure_Engine_2
{
	public class Directions
	{
		public directions getDirection(string dir)
		{
			directions d = directions.None;

			switch (dir.ToLower())
			{
				case "n":
				case "north":
				case "f":
				case "forward":
					d = directions.Forward;
					break;


				case "w":
				case "west":
				case "l":
				case "left":
					d = directions.Left;
					break;


				case "s":
				case "south":
				case "b":
				case "back":
					d = directions.Back;
					break;


				case "e":
				case "east":
				case "r":
				case "right":
					d = directions.Right;
					break;

				default:
					d = directions.None;
					break;
			}

			return d;
		}
	}

	public enum directions
	{
		None,
		Forward,
		Right,
		Back,
		Left
	}
}
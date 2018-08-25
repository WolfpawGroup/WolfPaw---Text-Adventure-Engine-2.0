using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfPaw_Text_Adventure_Engine_2
{
	public class c_Room
	{
		public int ID { get; set; }
		public string Name { get; set; }								= "New Room";
		public int Height { get; set; }									= 30;
		public int Width { get; set; }									= 30;
		public List<c_Door> Doors { get; set; }							= new List<c_Door>();
		public List<c_Window> Windows { get; set; }						= new List<c_Window>();
		public List<c_Object> Objects { get; set; }						= new List<c_Object>();
		public Dictionary<string, string> Descriptions { get; set; }	= new Dictionary<string, string>();
	}

	public class c_Door
	{
		public int ID { get; set; }
		public string Name { get; set; }								= "Door to ...";
		public directions Direction { get; set; }						= directions.None;
		public bool Locked { get; set; }								= false;
		public c_Object Key { get; set; }								= null;
		public Dictionary<string, string> Descriptions { get; set; }	= new Dictionary<string, string>();
	}

	public class c_Window
	{
		public int ID { get; set; }
		public string Name { get; set; }								= "Door to ...";
		public directions Direction { get; set; }						= directions.None;
		public Dictionary<string, string> Descriptions { get; set; }	= new Dictionary<string, string>();
	}

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

using System.Collections.Generic;

namespace WolfPaw_Text_Adventure_Engine_2.types
{
	public class c_Room
	{
		public int ID { get; set; }
		public string Name { get; set; } = "New Room";
		public int Height { get; set; } = 30;
		public int Width { get; set; } = 30;
		public List<c_Door> Doors { get; set; } = new List<c_Door>();
		public List<c_Window> Windows { get; set; } = new List<c_Window>();
		public List<c_Object> Objects { get; set; } = new List<c_Object>();
		public Dictionary<string, string> Descriptions { get; set; } = new Dictionary<string, string>();
	}
}





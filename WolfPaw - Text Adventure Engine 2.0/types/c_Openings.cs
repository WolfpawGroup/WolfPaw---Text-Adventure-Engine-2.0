using System.Collections.Generic;

namespace WolfPaw_Text_Adventure_Engine_2.types
{
	public class c_Door
	{
		public int ID { get; set; }
		public string Name { get; set; } = "Door to ...";
		public directions Direction { get; set; } = directions.None;
		public bool Locked { get; set; } = false;
		public c_Object Key { get; set; } = null;
		public Dictionary<string, string> Descriptions { get; set; } = new Dictionary<string, string>();
	}

	public class c_Window
	{
		public int ID { get; set; }
		public string Name { get; set; } = "Door to ...";
		public directions Direction { get; set; } = directions.None;
		public Dictionary<string, string> Descriptions { get; set; } = new Dictionary<string, string>();
	}
}
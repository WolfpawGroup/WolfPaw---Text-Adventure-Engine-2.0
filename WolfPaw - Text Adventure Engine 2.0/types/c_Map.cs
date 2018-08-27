using System.Collections.Generic;

namespace WolfPaw_Text_Adventure_Engine_2.types
{
	public class c_Map
	{
		public int ID { get; set; }
		public string Name { get; set; }								= "New Map";
		public int Height { get; set; }									= 150;
		public int Width { get; set; }									= 150;
		public List<c_Room> Rooms { get; set; }							= new List<c_Room>();
		public Dictionary<string, string> Descriptions { get; set; }	= new Dictionary<string, string>();
	}
}

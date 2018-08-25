using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfPaw_Text_Adventure_Engine_2
{
	public class c_Object
	{
		public int ID { get; set; }
		public string Name { get; set; }								= "New Object";
		public objectType Type { get; set; }							= objectType.Pickup;

		//If object is key
		public c_Door ConnectedDoor { get; set; }						= null;

		//Multiple descriptions
		public Dictionary<string, string> Descriptions { get; set; }	= new Dictionary<string, string>();

	}

	public enum objectType
	{
					//e.g.:
					//-----------------------
		Pickup,		//	a penny
		Wearable,	//	a hat
		Usable,		//	a book -> can be read
		Weapon,		//	a knife
		Key,		//	opens a specific door
		Fixed,		//	a sofa
		Quest_Item	//	a clue to solving mistery
	}
}

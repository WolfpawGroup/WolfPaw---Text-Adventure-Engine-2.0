using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace WolfPaw_Text_Adventure_Engine_2.types
{
	/// <summary>
	/// Main object Class - inherited by object types
	/// </summary>
	public class c_Object
	{
		public	int								ID					{ get; set; }
		public	string							Name				{ get; set; }	= "New Object";
		public	objectType						Type				{ get; set; }	= objectType.Pickup;

		//Multiple descriptions
		public	Dictionary<string, string>		Descriptions		{ get; set; }	= new Dictionary<string, string>();
		public	Dictionary<c_Actions, string>	actionDescriptions	{ get; set; }	= new Dictionary<c_Actions, string>();
	}

	public class o_Key : c_Object
	{
		public	 bool							singleDoorUse		{ get; set; }	= true;
		public	 c_Door							doorId				{ get; set; }
		public	 c_Door[]						doorIds				{ get; set; }

		public o_Key()
		{
			Type = objectType.Key;
		}
	}

	public enum objectType
	{
		//e.g.:
		//-----------------------
		Pickup,     //	a penny
		Wearable,   //	a hat
		Usable,     //	a book -> can be read
		Weapon,     //	a knife
		Key,        //	opens a specific door
		Fixed,      //	a sofa
		Quest_Item  //	a clue to solving mistery
	}
}

using System;
using System.Collections.Generic;

namespace WolfPaw_Text_Adventure_Engine_2
{
	public class c_GenerateId
	{

		public c_GenerateId()
		{

		}

		private  Dictionary<string, int> types = new Dictionary<string, int>()
		{
			{	"map"		,	1	},
			{	"room"		,	2	},
			{	"door"		,	3	},
			{	"window"	,	4	},
			{	"object"	,	5	}
		};

		private  string getTypeFromChar(string t)
		{
			switch (t)
			{
				case "m": return "map";
				case "r": return "room";
				case "d": return "door";
				case "w": return "window";
				case "o": return "objects";
				default: return "";
			}
		}

		public  int getNextId(string idType)
		{
			int id = 0;
			int idT = 0;

			if(idType.Length == 1) { idType = getTypeFromChar(idType); }
			if (idType.Length > 0)
			{
				idT = types[idType];

				switch (idType)
				{
					case "map":		id = Convert.ToInt32(idT + "" + getNextMapId()		); break;
					case "room":	id = Convert.ToInt32(idT + "" + getNextRoomId()		); break;
					case "door":	id = Convert.ToInt32(idT + "" + getNextDoorId()		); break;
					case "window":	id = Convert.ToInt32(idT + "" + getNextWindowId()	); break;
					case "object":	id = Convert.ToInt32(idT + "" + getNextObjectId()	); break;
				}
				
				return id;
			}
			return -1;
		}

		public  int getCurrentId(string idType)
		{
			int id = 0;
			int idT = 0;

			if (idType.Length == 1) { idType = getTypeFromChar(idType); }
			if (idType.Length > 0)
			{
				idT = types[idType];

				switch (idType)
				{
					case "map":		id = Convert.ToInt32(idT + "" + getCurrentMapId()		); break;
					case "room":	id = Convert.ToInt32(idT + "" + getCurrentRoomId()		); break;
					case "door":	id = Convert.ToInt32(idT + "" + getCurrentDoorId()		); break;
					case "window":	id = Convert.ToInt32(idT + "" + getCurrentWindowId()	); break;
					case "object":	id = Convert.ToInt32(idT + "" + getCurrentObjectId()	); break;
				}
				
				return id;
			}
			return -1;
		}

		public  bool hasIdRows()
		{
			try
			{
				return false;
			}
			catch
			{
				return false;
			}
		}

		public  void initializeIds()
		{//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\local_db.mdf;Integrated Security=True
			
		}

		//-----------------------------------------------------------------------------------------------------

		private  string getCurrentMapId()
		{
			string id = "";

			

			return id;
		}

		private  string getCurrentRoomId()
		{
			string id = "";

			

			return id;
		}

		private  string getCurrentDoorId()
		{
			string id = "";
			

			return id;
		}

		private  string getCurrentWindowId()
		{
			string id = "";
			

			return id;
		}

		private  string getCurrentObjectId()
		{
			string id = "";
			

			return id;
		}

		//-----------------------------------------------------------------------------------------------------

		private  string getNextMapId()
		{
			string id = "";
			

			return id;
		}

		private  string getNextRoomId()
		{
			string id = "";
			

			return id;
		}

		private  string getNextDoorId()
		{
			string id = "";
			

			return id;
		}

		private  string getNextWindowId()
		{
			string id = "";
			

			return id;
		}

		private  string getNextObjectId()
		{
			string id = "";
			

			return id;
		}



	}
}

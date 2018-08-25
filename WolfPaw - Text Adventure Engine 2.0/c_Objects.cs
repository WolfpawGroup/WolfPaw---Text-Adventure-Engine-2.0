using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace WolfPaw_Text_Adventure_Engine_2
{
	class c_Objects
	{
	}

	[Serializable]
	[XmlRoot("PROJECT")]
	public class c_ProjectData
	{
		[XmlElement(DataType = "string",	ElementName = "title",				Order = 0, Type = typeof(string))]
		public string	initializer				{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "title",				Order = 1, Type=typeof(string))]
		public string	projectTitle			{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "author",				Order = 2, Type=typeof(string))]
		public string	projectAuthor			{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "folder",				Order = 3, Type=typeof(string))]
		public string	projectFolder			{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "shortDescription",	Order = 4, Type=typeof(string))]
		public string	projectShortDescription	{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "description",		Order = 5, Type=typeof(string))]
		public string	projectDescription		{ get; set; }

		[XmlArray(							ElementName = "FILES",				Order = 6)]
		[XmlArrayItem(ElementName = "file")]
		public string[] projectFiles			{ get; set; }

		[XmlElement(DataType = "string",	ElementName = "created",			Order = 7, Type = typeof(string))]
		public string projectCreationDate		{ get; set; } = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToLongTimeString();

		[XmlElement(DataType = "string",	ElementName = "modified",			Order = 8, Type = typeof(string))]
		public string projectLastModified		{ get; set; } = DateTime.Now.ToShortDateString() + "" + DateTime.Now.ToLongTimeString();

	}
}

﻿using System.Text;
using System.Xml;

namespace WolfPaw_Text_Adventure_Engine_2
{
	class c_XML
	{
		public string generateXMLDoc(dynamic data)
		{
			System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(data.GetType());

			XmlWriterSettings xs = new XmlWriterSettings()
			{
				DoNotEscapeUriAttributes = true,
				Indent = true,
				IndentChars = "	",
				NewLineChars = "\r\n",
				NewLineHandling = NewLineHandling.Replace,
				NewLineOnAttributes = true,
				Encoding = Encoding.UTF8,
				OmitXmlDeclaration = true,
				NamespaceHandling = NamespaceHandling.OmitDuplicates
			};
			
			StringBuilder sb = new StringBuilder();

			using (XmlWriter xw = XmlWriter.Create(sb,xs))
			{
				serializer.Serialize(xw, data);
			}
			string ret = sb.ToString();
			
			return ret;
		}
	}
}

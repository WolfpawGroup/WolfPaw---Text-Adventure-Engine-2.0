using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WolfPaw_Text_Adventure_Engine_2
{
	class c_SimpleJSON
	{
		/// <summary>
		/// Creates Json String from data passed to it
		/// </summary>
		/// <param name="data">Object[] containing string[2]-s | Each string[] containing a key value pair</param>
		/// <returns>String of serialized Json data</returns>
		public string createJsonString(object[] data)
		{
			StringBuilder ret = new StringBuilder();
			foreach (var v in data)
			{
				string[] sa = v as string[];
				if (sa != null)
				{
					ret.AppendFormat("\"{0}\":\"{1}\"", sa[0].Replace("\"", "\\\""), sa[1].Replace("\"", "\\\""));
					if (!data.Last().Equals(v))
					{
						ret.Append(", ");
					}
				}
			}

			return "{ " + ret.ToString() + " }";
		}

		/// <summary>
		/// Gets Keys and Values from Json String
		/// </summary>
		/// <param name="JSON">String containing simple Json data {"":"", "":""}</param>
		/// <returns>object[] containing object[]-s each of them containing an array of types and the 2 values eg: [Type[]{String,Int},"key":"1"]</returns>
		public object[] getDataFromJsonString(string JSON)
		{
			List<object> lo = new List<object>();
			string Json = JSON.Trim();
			if (!Json.StartsWith("{") || !Json.EndsWith("}")) { return null; }
			if (Json.Contains("\",\"")) { Json = Json.Replace("\",\"", "\", \""); }
			string[] jsa = Json.Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			Regex r = new Regex("\".*?\":\".*?\"");
			Regex num = new Regex("^\"\\d+\"$");

			foreach (string s in jsa)
			{
				string ss = s.Trim();
				if (r.IsMatch(ss))
				{
					object[] o = new object[3];
					Type[] tt = new Type[2];
					int i = 0;
					foreach (string sss in ss.Split(':'))
					{
						if (num.IsMatch(sss)) { tt[i] = 0.GetType(); }
						else { tt[i] = "".GetType(); }
						o[i + 1] = sss;
						i++;
					}
					o[0] = tt;
					lo.Add(o);
				}
			}

			return lo.ToArray();
		}
	}

	public class jsonReturn
	{
		public dynamic Key { get; set; }
		public dynamic Value { get; set; }
		public Type keyType { get; set; } = "".GetType();
		public Type valueType { get; set; } = "".GetType();

		public dynamic key()
		{
			return Key;
		}
	}

}

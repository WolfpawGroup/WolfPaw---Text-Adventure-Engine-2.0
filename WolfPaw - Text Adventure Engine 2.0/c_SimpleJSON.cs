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
		/// <returns>jsonReturn[] containing jsonReturn-s</returns>
		public jsonReturn[] getDataFromJsonString(string JSON)
		{
			List<jsonReturn> lo = new List<jsonReturn>();
			string Json = JSON.Trim();
			if (!Json.StartsWith("{") || !Json.EndsWith("}")) { return null; }
			Json = Json.Trim('{', '}');
			if (Json.Contains("\",\"")) { Json = Json.Replace("\",\"", "\", \""); }
			string[] jsa = Json.Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

			Regex r = new Regex("\".*?\":\".*?\"");
			Regex num = new Regex("^\\d+$");

			foreach (string s in jsa)
			{
				string ss = s.Trim();
				if (r.IsMatch(ss))
				{
					jsonReturn jr = new jsonReturn();
					int i = 0;

					foreach (string sss in ss.Split(':'))
					{
						string _s_ = sss.Trim('\\', '"');
						if (num.IsMatch(_s_))	{ if (i == 0) { jr.keyIsInt = true;		}	else { jr.valueIsInt = true;	} }
						else					{ if (i == 0) { jr.keyIsInt = false;	}	else { jr.valueIsInt = false;	} }

						if(i == 0)	{ jr.Key = _s_; }
						else		{ jr.Value = _s_; }

						i++;
					}

					lo.Add(jr);
				}
			}

			return lo.ToArray();
		}
	}

	public class jsonReturn
	{
		public dynamic Key { get; set; }
		public dynamic Value { get; set; }
		public bool keyIsInt { get; set; }
		public bool valueIsInt { get; set; }

		private int keyAsInt()
		{
			string v = Key;
			//v = v.Trim(new char[] { '\\', '"' });
			return Convert.ToInt32(v);
		}

		private string keyAsString()
		{
			return Key;
		}

		private int valueAsInt()
		{
			string v = Value;
			//v = v.Trim(new char[] { '\\', '"' });
			return Convert.ToInt32(v);
		}

		private string valueAsString()
		{
			return Value;
		}

		public dynamic key()
		{
			if (keyIsInt)
			{
				return keyAsInt();
			}
			else
			{
				return keyAsString();
			}
		}

		public dynamic value()
		{
			if (valueIsInt)
			{
				return valueAsInt();
			}
			else
			{
				return valueAsString();
			}
		}
	}

}

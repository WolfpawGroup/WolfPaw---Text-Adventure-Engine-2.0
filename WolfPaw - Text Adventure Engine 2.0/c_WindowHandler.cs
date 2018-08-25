using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_Text_Adventure_Engine_2
{
	class c_WindowHandler
	{
		public static void openWindow(c_SimpleJSON sj, Panel panel)
		{
			string j = panel.Tag.ToString();
			var v = sj.getDataFromJsonString(j);
			foreach (var vv in v)
			{
				switch ((vv.key() as string).ToLower())
				{
					case "w":
						panel.Width = vv.value();
						break;

					case "h":
						panel.Height = vv.value();
						break;

					case "t":
						panel.Top = vv.value();
						break;

					case "l":
						panel.Left = vv.value();
						break;
				}
			}

			panel.Visible = true;
		}
	}
}

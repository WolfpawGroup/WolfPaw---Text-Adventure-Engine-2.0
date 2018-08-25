using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_Text_Adventure_Engine_2
{
	public partial class Form1 : Form
	{
		c_SimpleJSON sj = new c_SimpleJSON();
		c_GenerateId cgenId;

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lv_Maps_List.SmallImageList = new ImageList() { ImageSize = new Size(22,22) };
			lv_Maps_List.SmallImageList.Images.Add(Properties.Resources.map);

			if (cgenId.hasIdRows())
			{
				Console.WriteLine("has ids");
			}
			else
			{
				Console.WriteLine("has NO ids");
			}

			cgenId.initializeIds();
			
			if (cgenId.hasIdRows())
			{
				Console.WriteLine("has ids");
			}
			else
			{
				Console.WriteLine("has NO ids");
			}
		}

		public void loadDataToLvMaps()
		{

			foreach(var vv in v)
			{
				ListViewItem map = new ListViewItem();
				map.ImageIndex = 0;
				lv_Maps_List.Items.Add(map);
				map.Text = vv.name;
			}
		}

		private void btn_Maps_Add_Click(object sender, EventArgs e)
		{
			string j = p_Maps_Add_Panel.Tag.ToString();
			var v = sj.getDataFromJsonString(j);
			foreach(var vv in v)
			{
				switch ((vv.key() as string).ToLower())
				{
					case "w":
						p_Maps_Add_Panel.Width = vv.value();
						break;

					case "h":
						p_Maps_Add_Panel.Height = vv.value();
						break;

					case "t":
						p_Maps_Add_Panel.Top = vv.value();
						break;

					case "l":
						p_Maps_Add_Panel.Left = vv.value();
						break;
				}

				p_Maps_Add_Panel.Visible = true;
				lbl_Maps_Add_ID.Text = cgenId.getNextId("map").ToString(); 
			}
		}

		public void addToData()
		{
			
		}

		private void btn_Maps_Add_OK_Click(object sender, EventArgs e)
		{

		}

		private void btn_Maps_Add_Cancel_Click(object sender, EventArgs e)
		{

		}
	}
}

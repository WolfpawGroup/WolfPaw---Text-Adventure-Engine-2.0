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
		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lv_Maps_List.SmallImageList = new ImageList() { ImageSize = new Size(22,22) };
			lv_Maps_List.SmallImageList.Images.Add(Properties.Resources.map);
		}

		public void loadDataToLvMaps()
		{
			local_dbDataSetTableAdapters.dt_table_mapsTableAdapter ta = new local_dbDataSetTableAdapters.dt_table_mapsTableAdapter();
			var v = ta.GetData();
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
			
		}

		public void addToData()
		{
			
		}
	}
}

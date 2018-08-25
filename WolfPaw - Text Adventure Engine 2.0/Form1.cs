using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_Text_Adventure_Engine_2
{
	public partial class Form1 : Form
	{
		c_SimpleJSON sj = new c_SimpleJSON();
		c_GenerateId cgenId = new c_GenerateId();

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lv_Maps_List.SmallImageList = new ImageList() { ImageSize = new Size(22,22) };
			lv_Maps_List.SmallImageList.Images.Add(Properties.Resources.map);
			cgenId.initializeIds();
		}

		public void loadDataToLvMaps()
		{
			/*
			foreach(var vv in v)
			{
				ListViewItem map = new ListViewItem();
				map.ImageIndex = 0;
				lv_Maps_List.Items.Add(map);
				map.Text = vv.name;
			}
			*/
		}

		private void btn_Maps_Add_Click(object sender, EventArgs e)
		{
			c_WindowHandler.openWindow(sj, p_Maps_Add_Panel);
			lbl_Maps_Add_ID.Text = cgenId.getNextId("map").ToString();
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

		private void btn_Menu_File_NewProject_Click(object sender, EventArgs e)
		{
			c_Project cp = new c_Project();
			cp.createNewProject("", "", "", "", "");
		}
	}
}

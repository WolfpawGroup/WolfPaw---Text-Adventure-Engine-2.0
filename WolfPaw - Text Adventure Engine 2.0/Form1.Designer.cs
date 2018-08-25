namespace WolfPaw_Text_Adventure_Engine_2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tc_Tabs = new System.Windows.Forms.TabControl();
			this.tp_Maps = new System.Windows.Forms.TabPage();
			this.btn_Maps_Delete = new System.Windows.Forms.Button();
			this.btn_Maps_Edit = new System.Windows.Forms.Button();
			this.btn_Maps_Add = new System.Windows.Forms.Button();
			this.lv_Maps_List = new System.Windows.Forms.ListView();
			this.ch_Maps_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Maps_MapName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.p_Maps_Add_Panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.num_Maps_Add_Height = new System.Windows.Forms.NumericUpDown();
			this.num_Maps_Add_Width = new System.Windows.Forms.NumericUpDown();
			this.tb_Maps_Add_Name = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_Maps_Add_ID = new System.Windows.Forms.Label();
			this.btn_Maps_Add_Cancel = new System.Windows.Forms.Button();
			this.btn_Maps_Add_OK = new System.Windows.Forms.Button();
			this.pb_Maps_Minimap = new System.Windows.Forms.PictureBox();
			this.btn_TS_AddMap = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tc_Tabs.SuspendLayout();
			this.tp_Maps.SuspendLayout();
			this.p_Maps_Add_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Maps_Add_Height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Maps_Add_Width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Maps_Minimap)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 584);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1014, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TS_AddMap,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tc_Tabs);
			this.splitContainer1.Size = new System.Drawing.Size(1014, 535);
			this.splitContainer1.SplitterDistance = 172;
			this.splitContainer1.TabIndex = 3;
			// 
			// tc_Tabs
			// 
			this.tc_Tabs.Controls.Add(this.tp_Maps);
			this.tc_Tabs.Controls.Add(this.tabPage2);
			this.tc_Tabs.Controls.Add(this.tabPage3);
			this.tc_Tabs.Controls.Add(this.tabPage5);
			this.tc_Tabs.Controls.Add(this.tabPage6);
			this.tc_Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_Tabs.Location = new System.Drawing.Point(0, 0);
			this.tc_Tabs.Multiline = true;
			this.tc_Tabs.Name = "tc_Tabs";
			this.tc_Tabs.SelectedIndex = 0;
			this.tc_Tabs.Size = new System.Drawing.Size(838, 535);
			this.tc_Tabs.TabIndex = 0;
			// 
			// tp_Maps
			// 
			this.tp_Maps.Controls.Add(this.p_Maps_Add_Panel);
			this.tp_Maps.Controls.Add(this.btn_Maps_Delete);
			this.tp_Maps.Controls.Add(this.btn_Maps_Edit);
			this.tp_Maps.Controls.Add(this.btn_Maps_Add);
			this.tp_Maps.Controls.Add(this.pb_Maps_Minimap);
			this.tp_Maps.Controls.Add(this.lv_Maps_List);
			this.tp_Maps.Location = new System.Drawing.Point(4, 22);
			this.tp_Maps.Name = "tp_Maps";
			this.tp_Maps.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Maps.Size = new System.Drawing.Size(830, 509);
			this.tp_Maps.TabIndex = 0;
			this.tp_Maps.Text = "Maps";
			this.tp_Maps.UseVisualStyleBackColor = true;
			// 
			// btn_Maps_Delete
			// 
			this.btn_Maps_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Maps_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Maps_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Maps_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Maps_Delete.Location = new System.Drawing.Point(122, 473);
			this.btn_Maps_Delete.Name = "btn_Maps_Delete";
			this.btn_Maps_Delete.Size = new System.Drawing.Size(49, 36);
			this.btn_Maps_Delete.TabIndex = 4;
			this.btn_Maps_Delete.Text = "-";
			this.btn_Maps_Delete.UseVisualStyleBackColor = true;
			// 
			// btn_Maps_Edit
			// 
			this.btn_Maps_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Maps_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Maps_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Maps_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Maps_Edit.Location = new System.Drawing.Point(48, 473);
			this.btn_Maps_Edit.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Maps_Edit.Name = "btn_Maps_Edit";
			this.btn_Maps_Edit.Size = new System.Drawing.Size(76, 36);
			this.btn_Maps_Edit.TabIndex = 3;
			this.btn_Maps_Edit.Text = "EDIT";
			this.btn_Maps_Edit.UseVisualStyleBackColor = true;
			// 
			// btn_Maps_Add
			// 
			this.btn_Maps_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Maps_Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Maps_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Maps_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_Maps_Add.Location = new System.Drawing.Point(0, 473);
			this.btn_Maps_Add.Name = "btn_Maps_Add";
			this.btn_Maps_Add.Size = new System.Drawing.Size(49, 36);
			this.btn_Maps_Add.TabIndex = 2;
			this.btn_Maps_Add.Text = "+";
			this.btn_Maps_Add.UseVisualStyleBackColor = true;
			this.btn_Maps_Add.Click += new System.EventHandler(this.btn_Maps_Add_Click);
			// 
			// lv_Maps_List
			// 
			this.lv_Maps_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lv_Maps_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Maps_Id,
            this.ch_Maps_MapName});
			this.lv_Maps_List.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_Maps_List.FullRowSelect = true;
			this.lv_Maps_List.GridLines = true;
			this.lv_Maps_List.Location = new System.Drawing.Point(0, 0);
			this.lv_Maps_List.Name = "lv_Maps_List";
			this.lv_Maps_List.Size = new System.Drawing.Size(171, 474);
			this.lv_Maps_List.TabIndex = 0;
			this.lv_Maps_List.UseCompatibleStateImageBehavior = false;
			this.lv_Maps_List.View = System.Windows.Forms.View.List;
			// 
			// ch_Maps_Id
			// 
			this.ch_Maps_Id.Text = "#";
			this.ch_Maps_Id.Width = 34;
			// 
			// ch_Maps_MapName
			// 
			this.ch_Maps_MapName.Text = "Map";
			this.ch_Maps_MapName.Width = 133;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(830, 509);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Rooms";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(830, 509);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Items";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(830, 509);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Properties";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(830, 509);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "tabPage6";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// p_Maps_Add_Panel
			// 
			this.p_Maps_Add_Panel.BackColor = System.Drawing.Color.Gainsboro;
			this.p_Maps_Add_Panel.BackgroundImage = global::WolfPaw_Text_Adventure_Engine_2.Properties.Resources.bg;
			this.p_Maps_Add_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_Maps_Add_Panel.Controls.Add(this.label1);
			this.p_Maps_Add_Panel.Controls.Add(this.num_Maps_Add_Height);
			this.p_Maps_Add_Panel.Controls.Add(this.num_Maps_Add_Width);
			this.p_Maps_Add_Panel.Controls.Add(this.tb_Maps_Add_Name);
			this.p_Maps_Add_Panel.Controls.Add(this.label5);
			this.p_Maps_Add_Panel.Controls.Add(this.label4);
			this.p_Maps_Add_Panel.Controls.Add(this.label3);
			this.p_Maps_Add_Panel.Controls.Add(this.lbl_Maps_Add_ID);
			this.p_Maps_Add_Panel.Controls.Add(this.btn_Maps_Add_Cancel);
			this.p_Maps_Add_Panel.Controls.Add(this.btn_Maps_Add_OK);
			this.p_Maps_Add_Panel.Location = new System.Drawing.Point(-100, -100);
			this.p_Maps_Add_Panel.Name = "p_Maps_Add_Panel";
			this.p_Maps_Add_Panel.Size = new System.Drawing.Size(0, 0);
			this.p_Maps_Add_Panel.TabIndex = 5;
			this.p_Maps_Add_Panel.Tag = "{\"W\":\"330\", \"H\":\"170\", \"L\":\"140\", \"T\":\"130\"}";
			this.p_Maps_Add_Panel.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Map";
			// 
			// num_Maps_Add_Height
			// 
			this.num_Maps_Add_Height.Location = new System.Drawing.Point(77, 101);
			this.num_Maps_Add_Height.Name = "num_Maps_Add_Height";
			this.num_Maps_Add_Height.Size = new System.Drawing.Size(63, 20);
			this.num_Maps_Add_Height.TabIndex = 9;
			// 
			// num_Maps_Add_Width
			// 
			this.num_Maps_Add_Width.Location = new System.Drawing.Point(77, 76);
			this.num_Maps_Add_Width.Name = "num_Maps_Add_Width";
			this.num_Maps_Add_Width.Size = new System.Drawing.Size(63, 20);
			this.num_Maps_Add_Width.TabIndex = 8;
			// 
			// tb_Maps_Add_Name
			// 
			this.tb_Maps_Add_Name.Location = new System.Drawing.Point(77, 50);
			this.tb_Maps_Add_Name.Name = "tb_Maps_Add_Name";
			this.tb_Maps_Add_Name.Size = new System.Drawing.Size(240, 20);
			this.tb_Maps_Add_Name.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Height: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Width: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Map name: ";
			// 
			// lbl_Maps_Add_ID
			// 
			this.lbl_Maps_Add_ID.AutoSize = true;
			this.lbl_Maps_Add_ID.Location = new System.Drawing.Point(8, 28);
			this.lbl_Maps_Add_ID.Name = "lbl_Maps_Add_ID";
			this.lbl_Maps_Add_ID.Size = new System.Drawing.Size(24, 13);
			this.lbl_Maps_Add_ID.TabIndex = 3;
			this.lbl_Maps_Add_ID.Text = "ID: ";
			// 
			// btn_Maps_Add_Cancel
			// 
			this.btn_Maps_Add_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Maps_Add_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Maps_Add_Cancel.Location = new System.Drawing.Point(242, 134);
			this.btn_Maps_Add_Cancel.Name = "btn_Maps_Add_Cancel";
			this.btn_Maps_Add_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Maps_Add_Cancel.TabIndex = 2;
			this.btn_Maps_Add_Cancel.Text = "CANCEL";
			this.btn_Maps_Add_Cancel.UseVisualStyleBackColor = false;
			this.btn_Maps_Add_Cancel.Click += new System.EventHandler(this.btn_Maps_Add_Cancel_Click);
			// 
			// btn_Maps_Add_OK
			// 
			this.btn_Maps_Add_OK.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Maps_Add_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Maps_Add_OK.Location = new System.Drawing.Point(11, 134);
			this.btn_Maps_Add_OK.Name = "btn_Maps_Add_OK";
			this.btn_Maps_Add_OK.Size = new System.Drawing.Size(75, 23);
			this.btn_Maps_Add_OK.TabIndex = 1;
			this.btn_Maps_Add_OK.Text = "OK";
			this.btn_Maps_Add_OK.UseVisualStyleBackColor = false;
			this.btn_Maps_Add_OK.Click += new System.EventHandler(this.btn_Maps_Add_OK_Click);
			// 
			// pb_Maps_Minimap
			// 
			this.pb_Maps_Minimap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Maps_Minimap.BackColor = System.Drawing.Color.Gainsboro;
			this.pb_Maps_Minimap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_Maps_Minimap.Location = new System.Drawing.Point(580, 259);
			this.pb_Maps_Minimap.Name = "pb_Maps_Minimap";
			this.pb_Maps_Minimap.Size = new System.Drawing.Size(250, 250);
			this.pb_Maps_Minimap.TabIndex = 1;
			this.pb_Maps_Minimap.TabStop = false;
			// 
			// btn_TS_AddMap
			// 
			this.btn_TS_AddMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_TS_AddMap.Image = ((System.Drawing.Image)(resources.GetObject("btn_TS_AddMap.Image")));
			this.btn_TS_AddMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_TS_AddMap.Name = "btn_TS_AddMap";
			this.btn_TS_AddMap.Size = new System.Drawing.Size(23, 22);
			this.btn_TS_AddMap.Text = "Add Map";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "toolStripButton6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 606);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tc_Tabs.ResumeLayout(false);
			this.tp_Maps.ResumeLayout(false);
			this.p_Maps_Add_Panel.ResumeLayout(false);
			this.p_Maps_Add_Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Maps_Add_Height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_Maps_Add_Width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Maps_Minimap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tc_Tabs;
		private System.Windows.Forms.TabPage tp_Maps;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.ListView lv_Maps_List;
		private System.Windows.Forms.ColumnHeader ch_Maps_Id;
		private System.Windows.Forms.ColumnHeader ch_Maps_MapName;
		private System.Windows.Forms.ToolStripButton btn_TS_AddMap;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.PictureBox pb_Maps_Minimap;
		private System.Windows.Forms.Button btn_Maps_Delete;
		private System.Windows.Forms.Button btn_Maps_Edit;
		private System.Windows.Forms.Button btn_Maps_Add;
		private System.Windows.Forms.Panel p_Maps_Add_Panel;
		private System.Windows.Forms.Button btn_Maps_Add_Cancel;
		private System.Windows.Forms.Button btn_Maps_Add_OK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown num_Maps_Add_Height;
		private System.Windows.Forms.NumericUpDown num_Maps_Add_Width;
		private System.Windows.Forms.TextBox tb_Maps_Add_Name;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_Maps_Add_ID;
	}
}


using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WolfPaw_Text_Adventure_Engine_2
{
	class c_Project
	{
		c_XML cx = new c_XML();

		string[] dirs = new string[] {
			"\\assets",
			"\\structure",
			"\\temp"
		};

		string[] files = new string[] {
			"\\project.taep",
			"\\assets\\conf.xml",
			"\\structure\\maps.xml",
			"\\structure\\rooms.xml",
			"\\structure\\doors.xml",
			"\\structure\\windows.xml",
			"\\structure\\objects.xml"
		};

		public void createNewProject(string projectName, string projectFolder, string authorName, string shortDescription, string description)
		{
			projectName = "New Project";
			authorName = "WolfyD";
			projectFolder = "F:\\projects\\new project";
			shortDescription = "Test Project";
			description = "This isn't even a project\r\nIt's just a fake file test thingy...";

			if (!Directory.Exists(projectFolder) || new DirectoryInfo(projectFolder).Attributes.HasFlag(FileAttributes.System | FileAttributes.ReadOnly)) { return; }

			List<string> projFiles = new List<string>();

			foreach (string s in dirs)
			{
				Directory.CreateDirectory(projectFolder + s);
			}

			foreach (string s in files)
			{
				File.Create(projectFolder + s).Close();
				projFiles.Add(projectFolder + s);
			}

			

			c_ProjectData pd = new c_ProjectData()
			{
				initializer = Application.ProductName + " - " + Application.ProductVersion,
				projectTitle = projectName,
				projectAuthor = authorName,
				projectFolder = projectFolder,
				projectFiles = projFiles.ToArray(),
				projectShortDescription = shortDescription,
				projectDescription = description
			};

			string ret = cx.generateXMLDoc(pd);

			Regex rx = new Regex("<PROJECT.*?>");
			if (rx.IsMatch(ret))
			{
				ret = rx.Replace(ret, "<PROJECT>");
			}

			File.WriteAllText(projFiles[0], ret);
		}
	}
}

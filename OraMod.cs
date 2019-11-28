using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class OraMod
	{
		private string path;
		private string modPath;
		private string modsdkPath;
		public string Version { get; set; }
		public string ModID { get; set; }
		public string ModName { get; set; }
		public string Author { get; set; }
		public ModConfig modConfig { get; set; }
		public OraModManifest Manifest { get; set; }
		public OraModEditorProject Project { get; set; }

		public string ModSDKPath
		{
			get
			{
				return modsdkPath;
			}
		}

		public string ModPath
		{
			get
			{
				return modPath;
			}
		}

		public OraMod(string path)
		{
			this.path = path;
		}

		public void Create()
		{
			modsdkPath = Path.Combine(path, ModName);
			modPath = Path.Combine(modsdkPath, "mods\\" + ModID);
			OraModEditorProject project = new OraModEditorProject();
			project.BasicInfo.ModID = ModID;
			project.BasicInfo.Name = ModName;
			project.BasicInfo.Author = Author;
			project.BasicInfo.EngineVersion = Version;
			project.Mod = this;
			project.Save(modsdkPath + "\\.project");
			Project = project;
		}

		public OraModEditorProject Open()
		{
			modsdkPath = path;
			modPath = Path.Combine(modsdkPath, "mods\\" + ModID);
			OraModEditorProject project = OraModEditorProject.Load(modsdkPath + "\\.project");
			project.Mod = this;
			Project = project;
			return project;
		}

		public void Init()
		{
			Manifest = new OraModManifest(modPath);
		}
	}
}

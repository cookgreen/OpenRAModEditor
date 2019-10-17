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
		}

		public void Open()
		{
			modsdkPath = path;
			modPath = Path.Combine(modsdkPath, "mods\\" + ModID);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor.ORA
{
	public class OraSDK
	{
		private string version;
		private string fullPath;
		public string Version { get { return version; } }
		public string FullPath { get { return fullPath; } }
		public OraMod Mod { get; set; }
		public OraSDK(string version, string fullPath)
		{
			this.version = version;
			this.fullPath = fullPath;
		}

		public void Run()
		{

		}
	}
}

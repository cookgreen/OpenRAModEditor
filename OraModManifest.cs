using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class OraModManifest
	{
		private Dictionary<string, string> prefixes;
		private string modPath;
		public string ID { get; set; }
		public List<string> Packages { get; set; }
		public Dictionary<string, string> Resources { get; set; }
		public Dictionary<string, string> Rules { get; set; }
		public Dictionary<string, string> Sequences { get; set; }
		public List<string> TileSets { get; set; }
		public List<string> Cursors { get; set; }
		public Dictionary<string, string> Chrome { get; set; }
		public List<string> Assemblies { get; set; }
		public List<string> ChromeLayout { get; set; }

		public OraModManifest(string modPath)
		{
			this.modPath = modPath;
			prefixes = new Dictionary<string, string>();
			Rules = new Dictionary<string, string>();
			Sequences = new Dictionary<string, string>();
			Chrome = new Dictionary<string, string>();
			Resources = new Dictionary<string, string>();
			Packages = new List<string>();

			MiniYaml miniYaml = new MiniYaml(Path.Combine(modPath, "mod.yaml"));
			foreach(var node in miniYaml.Nodes)
			{
				if (node.Name == "Packages")
				{
					foreach (var subNode in node.ChildNodes)
					{
						if (subNode.Name.StartsWith("$"))
						{
							ID = subNode.Value.Trim();
							prefixes.Add(ID, modPath);
						}
						else
						{
							if (subNode.Name.StartsWith(".") && subNode.Name.Length > 1)
							{
								DirectoryInfo di = new DirectoryInfo(modPath);
								di = new DirectoryInfo(Path.Combine(di.Parent.Parent.FullName, subNode.Name));
								prefixes.Add(subNode.Value.Trim(), di.FullName);
							}
							else if (subNode.Name.Contains('|'))
							{
								string[] tokens = subNode.Name.Split('|');
								if (prefixes.ContainsKey(tokens[0]))
								{
									string packagePath = Path.Combine(prefixes[tokens[0]], tokens[1]);
									Packages.Add(packagePath);
									DirectoryInfo di = new DirectoryInfo(packagePath);
									if (di.Exists)
									{
										var files = di.EnumerateFiles();
										foreach (var file in files)
										{
											Resources.Add(file.Name, file.FullName);
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (node.Name == "Rules")
					{
						foreach (var subNode in node.ChildNodes)
						{
							var tokens = subNode.Name.Split('|');
							if (prefixes.ContainsKey(tokens[0]))
							{
								string fullPath = Path.Combine(prefixes[tokens[0]], tokens[1]);
								string fileName = Path.GetFileName(fullPath);
								Rules.Add(fileName, fullPath);
							}
						}
					}
					else if (node.Name == "Sequences")
					{
						foreach (var subNode in node.ChildNodes)
						{
							var tokens = subNode.Name.Split('|');
							if (prefixes.ContainsKey(tokens[0]))
							{
								string fullPath = Path.Combine(prefixes[tokens[0]], tokens[1]);
								string fileName = Path.GetFileName(fullPath);
								Sequences.Add(fileName, fullPath);
							}
						}
					}
					else if (node.Name == "Chrome")
					{
						foreach (var subNode in node.ChildNodes)
						{
							var tokens = subNode.Name.Split('|');
							if (prefixes.ContainsKey(tokens[0]))
							{
								string fullPath = Path.Combine(prefixes[tokens[0]], tokens[1]);
								string fileName = Path.GetFileName(fullPath);
								Chrome.Add(fileName, fullPath);
							}
						}
					}
				}
			}
		}
	}
}

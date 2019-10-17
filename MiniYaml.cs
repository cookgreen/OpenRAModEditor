using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpenRAModEditor
{
	public class MiniYaml
	{
		private string miniYamlFilePath;
		public List<MiniYamlNode> Nodes { get; set; }

		public MiniYaml(string miniYamlFilePath)
		{
			this.miniYamlFilePath = miniYamlFilePath;
			Nodes = new List<MiniYamlNode>();
			Parse();
		}

		public void Parse()
		{
			MiniYamlNode currentNode = null;
			using (StreamReader reader = new StreamReader(miniYamlFilePath))
			{
				int lastCount = -1;
				while (reader.Peek() > -1)
				{
					string line = reader.ReadLine();
					if (string.IsNullOrEmpty(line))
					{
						continue;
					}
					int count = line.StartsWithCharCount('\t');
					if (count == 0)
					{
						currentNode = new MiniYamlNode();
						var tokens = line.Split(':');
						currentNode.Name = tokens[0].Replace("\t", null);
						if (tokens.Length > 1)
						{
							currentNode.Value = tokens[1];
						}
						Nodes.Add(currentNode);
					}
					else
					{
						if (count == 1)
						{
							if (currentNode.ParentNode != null)
							{
								currentNode = currentNode.ParentNode;
							}
							var subNode = new MiniYamlNode();
							var tokens = line.Split(':');
							subNode.Name = tokens[0].Replace("\t", null); ;
							if (tokens.Length > 1)
							{
								subNode.Value = tokens[1];
							}
							subNode.ParentNode = currentNode;
							currentNode.ChildNodes.Add(subNode);
							currentNode = subNode;
						}
						else
						{
							MiniYamlNode yamlNode = new MiniYamlNode();
							var tokens = line.Split(':');
							yamlNode.Name = tokens[0].Replace("\t", null);
							if (tokens.Length > 1)
							{
								yamlNode.Value = tokens[1];
							}
							int cunt = line.StartsWithCharCount('\t');
							if (count == lastCount)
							{
								yamlNode.ParentNode = currentNode.ParentNode;
								currentNode.ParentNode.ChildNodes.Add(yamlNode);
							}
							else if (cunt == lastCount + 1)
							{
								yamlNode.ParentNode = currentNode;
								currentNode.ChildNodes.Add(yamlNode);
							}
							else if (cunt == lastCount - 1)
							{
								yamlNode.ParentNode = currentNode.ParentNode.ParentNode;
								currentNode.ParentNode.ParentNode.ChildNodes.Add(yamlNode);
							}
							currentNode = yamlNode;
						}
					}
					lastCount = count;
				}
			}
		}
	}
}

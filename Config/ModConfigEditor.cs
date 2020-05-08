using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class ModConfigEditor
	{
		private static ModConfigEditor instance;
		public static ModConfigEditor Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ModConfigEditor();
				}
				return instance;
			}
		}
		public ModConfigEditor()
		{
		}

		public ModConfig ReadConfig(string modConfigFilePath)
		{
			ModConfig modConfig = new ModConfig();

			using (StreamReader reader = new StreamReader(modConfigFilePath))
			{
				while (reader.Peek() > -1)
				{
					string line = reader.ReadLine();
					if (!line.StartsWith("#") && !string.IsNullOrEmpty(line))
					{
						string[] tokens = line.Split('=');

						modConfig.AppendItemValue(tokens[0], tokens[1].Replace("\"", null));
					}
				}
			}

			return modConfig;
		}

		public void WriteConfig(ModConfig modConfig, string modConfigFilePath)
		{
			if (File.Exists(modConfigFilePath))
			{
				File.Delete(modConfigFilePath);
			}

			using (StreamWriter writer = new StreamWriter(modConfigFilePath))
			{
				foreach (var kpl in modConfig.ItemValuePairs)
				{
					writer.WriteLine(kpl.Key + "=\"" + kpl.Value+"\"");
				}
			}
		}
	}
}

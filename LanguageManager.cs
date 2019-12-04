using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public class LanguageManager
	{
		private const string LANGUAGE_DIR = "languages";
		private Dictionary<string, List<MiniYaml>> locateFiles;
		private Dictionary<string, string> translationDic;
		private static LanguageManager instance;
		public static LanguageManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new LanguageManager();
				}
				return instance;
			}
		}
		public AppConfig AppConfig { get; set; }

		public LanguageManager()
		{
			locateFiles = new Dictionary<string, List<MiniYaml>>();
			translationDic = new Dictionary<string, string>();
			translationDic.Add("cns", "简体中文");
			translationDic.Add("en", "English");

			string runningDir = Environment.CurrentDirectory;
			string languageDir = Path.Combine(runningDir, LANGUAGE_DIR);
			DirectoryInfo di = new DirectoryInfo(languageDir);
			foreach (var folder in di.EnumerateDirectories())
			{
				var locateFile = folder.EnumerateFiles().Where(o => o.Name == "ui.yaml");
				if (locateFile.Count() == 1)
				{
					locateFiles.Add(folder.Name, new List<MiniYaml>());
					locateFiles[folder.Name].Add(new MiniYaml(locateFile.First().FullName));
				}
			}
		}

		public string GetTranslation(string locate)
		{
			if (translationDic.ContainsKey(locate))
			{
				return translationDic[locate];
			}
			else
			{
				return locate;
			}
		}

		public string GetLocateByTranslation(string translation)
		{
			if (translationDic.ContainsValue(translation))
			{
				return translationDic.Where(o => o.Value == translation).FirstOrDefault().Key;
			}
			else
			{
				return translation;
			}
		}

		public List<string> GetLocates()
		{
			return locateFiles.Keys.ToList();
		}

		public string GetLocalizedString(string strID)
		{
			foreach (var locateFile in locateFiles[GetLocateByTranslation(AppConfig.Localization)])
			{
				var miniYamlNode = locateFile.Nodes[0].ChildNodes[0].ChildNodes.Where(o => o.Name == strID).FirstOrDefault();
				if (miniYamlNode != null)
				{
					return miniYamlNode.Value;
				}
			}
			return "!{No suck key}";
		}
	}
}

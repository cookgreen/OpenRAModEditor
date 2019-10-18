using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OpenRAModEditor
{
	[XmlRoot("EditorProject")]
	public class OraModEditorProject
	{
		[XmlAttribute]
		public string Version = "1.0";

		[XmlIgnore]
		public OraMod Mod { get; set; }

		public OraModEditorProjectBasicInfo BasicInfo { get; set; }

		public OraModEditorProjectSettings Settings { get; set; }

		public OraModEditorProject()
		{
			BasicInfo = new OraModEditorProjectBasicInfo();
			Settings = new OraModEditorProjectSettings();
		}

		public static OraModEditorProject Load(string projectFilePath)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(OraModEditorProject));
			FileStream stream = new FileStream(projectFilePath, FileMode.Open, FileAccess.Read);
			var project = serializer.Deserialize(stream) as OraModEditorProject;
			stream.Close();
			return project;
		}

		public void Save(string projectFilePath)
		{
			if (File.Exists(projectFilePath))
			{
				File.Delete(projectFilePath);
			}
			XmlSerializer serializer = new XmlSerializer(typeof(OraModEditorProject));
			FileStream stream = new FileStream(projectFilePath, FileMode.OpenOrCreate, FileAccess.Write);
			serializer.Serialize(stream, this);
			stream.Close();
		}
	}

	[XmlRoot("BasicInfo")]
	public class OraModEditorProjectBasicInfo
	{
		public string ModID { get; set; }
		public string Name { get; set; }
		public string EngineVersion { get; set; }
		public string Author { get; set; }
	}

	[XmlRoot("Settings")]
	public class OraModEditorProjectSettings
	{
		[XmlElement("Group")]
		public List<OraModEditorProjectSettingGroup> Groups { get; set; }

		public OraModEditorProjectSettings()
		{
			Groups = new List<OraModEditorProjectSettingGroup>();
		}

		public OraModEditorProjectSettingGroup AddGroup(string groupName)
		{
			if (Groups.Where(o => o.Name == groupName).Count() == 0)
			{
				OraModEditorProjectSettingGroup group = new OraModEditorProjectSettingGroup();
				group.Name = groupName;
				Groups.Add(group);
				return group;
			}
			else
			{
				return null;
			}
		}
	}

	[XmlRoot("Group")]
	public class OraModEditorProjectSettingGroup
	{
		[XmlAttribute]
		public string Name { get; set; }
		[XmlElement("Item")]
		public List<OraModEditorProjectSettingItem> SettingItems { get; set; }
		public OraModEditorProjectSettingGroup()
		{
			SettingItems = new List<OraModEditorProjectSettingItem>();
		}

		public void AddSetting(string item, string value)
		{
			var results = SettingItems.Where(o => o.ItemName == item);
			if (results.Count() == 0)
			{
				OraModEditorProjectSettingItem setting = new OraModEditorProjectSettingItem();
				setting.ItemName = item;
				setting.ItemValue = value;
				SettingItems.Add(setting);
			}
			else
			{
				results.ElementAt(0).ItemValue = value;
			}
		}
	}

	[XmlRoot("Item")]
	public class OraModEditorProjectSettingItem
	{
		[XmlAttribute("Name")]
		public string ItemName { get; set; }
		[XmlText]
		public string ItemValue { get; set; }
	}
}

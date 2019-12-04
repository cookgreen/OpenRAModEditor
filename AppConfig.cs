using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenRAModEditor
{
	[XmlRoot("Application")]
	public class AppConfig
	{
		private string fileName;
		[XmlElement]
		public string Localization { get; set; }

		public static AppConfig LoadConfig(string fileName)
		{
			FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);

			XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
			AppConfig config = serializer.Deserialize(stream) as AppConfig;
			config.fileName = fileName;

			stream.Close();
			return config;
		}

		public void Save()
		{
			FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);

			XmlSerializer serializer = new XmlSerializer(typeof(AppConfig));
			serializer.Serialize(stream, this);

			stream.Close();
		}
	}
}

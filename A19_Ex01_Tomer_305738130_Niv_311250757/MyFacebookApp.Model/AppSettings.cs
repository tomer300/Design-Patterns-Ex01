using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyFacebookApp.Model
{
	public class AppSettings
	{
		public static AppSettings Settings { get; private set; }

		private AppSettings() { }

		public Point Location { get; set; } = new Point(10, 10);

		public bool RememberUser { get; set; }

		public string LastAccessToken { get; set; } = string.Empty;

		public static void LoadAppSettings()
		{
			if (Settings == null)
			{
				Settings = new AppSettings();
				string pathOfSettingsFile = Environment.CurrentDirectory;
				pathOfSettingsFile += "\\appSettings.xml";
				if (File.Exists(pathOfSettingsFile) && new FileInfo(pathOfSettingsFile).Length > 0)
				{
					using (Stream stream = new FileStream(pathOfSettingsFile, FileMode.Open))
					{
						XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
						Settings = serializer.Deserialize(stream) as AppSettings;
					}
				}
			}
		}

		public void SaveAppSettings()
		{
			string pathOfSettingsFile = Environment.CurrentDirectory;
			pathOfSettingsFile += "\\appSettings.xml";
			FileMode fileMode = File.Exists(pathOfSettingsFile) ? FileMode.Truncate : FileMode.CreateNew;

			if (!RememberUser)
			{
				LastAccessToken = null;
			}

			using (Stream stream = new FileStream(pathOfSettingsFile, fileMode))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				serializer.Serialize(stream, this);
			}
		}
	}

}

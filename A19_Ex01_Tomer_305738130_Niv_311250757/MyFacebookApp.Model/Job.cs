using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MyFacebookApp.Model
{
    public class Job
    {
		private readonly HashSet<string> r_HitechWorkPlaces;
		private readonly HashSet<string> r_HitechKeyWords;
		public Job()
		{
			r_HitechWorkPlaces = buildSetFromXMLFile<WorkPlace>("MyFacebookApp.Model.israeliHitechList.xml");
			//r_HitechKeyWords = buildSetFromFile;
		}
		private HashSet<string> buildSetFromXMLFile<T>(string i_FileName)
		{
			HashSet<string> setFromFile = new HashSet<string>(); 

			if (File.Exists(i_FileName) && new FileInfo(i_FileName).Length > 0)
			{
				using (Stream stream = new FileStream(i_FileName, FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
					List < T > listFromFile = serializer.Deserialize(stream) as List<T>;
					
					foreach (T currMember in listFromFile)
					{
						setFromFile.Add(currMember.ToString());
					}
				}
			}
			return setFromFile;
		}
		public class HitechKeyWord
		{
			public string m_KeyWord { get; set; }
			public override string ToString()
			{
				return m_KeyWord;
			}
		}
		public class WorkPlace
		{
			public string m_Name { get; set; }
			public override string ToString()
			{
				return m_Name;
			}
		}

	}

}

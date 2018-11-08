using FacebookWrapper.ObjectModel;
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
		private readonly FacebookObjectCollection<AppUser> r_UserFriends;
		public Job(FacebookObjectCollection<AppUser> i_UserFriends)
		{
			r_HitechWorkPlaces = buildSetFromXMLFile<WorkPlace>(MyFacebookApp.Model.Properties.Resources.israeliHitechList);
			r_HitechKeyWords = buildSetFromXMLFile<HitechKeyWord>(MyFacebookApp.Model.Properties.Resources.hitechKeyWords);
			r_UserFriends = i_UserFriends;
		}
		private HashSet<string> buildSetFromXMLFile<T>(string i_XMLFileContent)
		{
			HashSet<string> setFromFile = new HashSet<string>();
			if (i_XMLFileContent.Length > 0)
			{
				using (TextReader reader = new StringReader(i_XMLFileContent))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
					List<T> listFromFile = serializer.Deserialize(reader) as List<T>;

					foreach (T currMember in listFromFile)
					{
						setFromFile.Add(currMember.ToString());
					}
				}
			}
			return setFromFile;
		}

		internal FacebookObjectCollection<AppUser> FindHitechWorkerContacts()
		{
			return null;
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

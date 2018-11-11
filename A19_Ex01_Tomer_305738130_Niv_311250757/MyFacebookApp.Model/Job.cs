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
			User stam = new User();

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

					foreach (T currentMember in listFromFile)
					{
						setFromFile.Add(currentMember.ToString());
					}
				}
			}
			return setFromFile;
		}

		internal FacebookObjectCollection<AppUser> FindHitechWorkerContacts()
		{
			FacebookObjectCollection<AppUser> hitechWorkingContacts = new FacebookObjectCollection<AppUser>();

			foreach (AppUser currentFriend in r_UserFriends)
			{
				if (worksAtKnownHitechCompany(currentFriend) || worksAtPotentiallyHitechRelatedCompany(currentFriend))
				{
					hitechWorkingContacts.Add(currentFriend);
				}
			}
			return hitechWorkingContacts;
		}

		private bool worksAtPotentiallyHitechRelatedCompany(AppUser i_CurrentFriend)
		{
			Page workPlace;
			bool doesAtPotentiallyHitechRelatedCompany = false;

			try
			{
				workPlace = i_CurrentFriend.GetWorkPlace();
				foreach (string wordInDescriptionOfWorkPlace in workPlace.Description.Split(' '))
				{
					if (r_HitechKeyWords.Contains(wordInDescriptionOfWorkPlace))
					{
						doesAtPotentiallyHitechRelatedCompany = true;
					}
				}
			}
			catch(Exception ex)
			{
				throw new Facebook.FacebookApiException(ex.Message);
			}

			return doesAtPotentiallyHitechRelatedCompany;
		}


		private bool worksAtKnownHitechCompany(AppUser i_CurrentFriend)
		{
			bool doesWorksAtKnownHitechCompany = false;
			string workPlace;
			try
			{
				workPlace = i_CurrentFriend.GetWorkPlace().Name.ToLower();
				if (r_HitechWorkPlaces.Contains(workPlace))
				{
					doesWorksAtKnownHitechCompany = true;
				}
			}
			catch(Exception ex)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch work experience."); 
			}
			return doesWorksAtKnownHitechCompany;
		}

		public class HitechKeyWord
		{
			public string m_KeyWord { get; set; }
			public override string ToString()
			{
				return m_KeyWord.ToLower();
			}
		}
		public class WorkPlace
		{
			public string m_Name { get; set; }
			public override string ToString()
			{
				return m_Name.ToLower();
			}
		}

	}
}



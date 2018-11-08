using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

//TODO:
//Check all exceptions messages.
//Check that all possible exception throwing are being used in try and catch!
//Check that refering facebook item with details (!= null).

//App ID: 2246590548924227

namespace MyFacebookApp.Model
{
	public class AppEngine
	{
		private AppUser m_LoggedUser;
		private Job m_Job;
		public AppEngine(AppUser i_AppUser)
		{
			m_LoggedUser = i_AppUser;
		}

		public string GetProfilePicture()
		{
			return m_LoggedUser.GetProfilePicture();

		}
		public string GetFirstName()
		{
			return m_LoggedUser.GetFirstName();
		}
		public string GetLastName()
		{
			return m_LoggedUser.GetLastName();
		}
		public FacebookObjectCollection<Album> GetAlbums()
		{
			return m_LoggedUser.GetAlbums();
		}

		public FacebookObjectCollection<AppUser> FindHitechWorkersContacts()
		{
			throw new NotImplementedException();
		}

		public FacebookObjectCollection<Event> GetEvents()
		{
			return m_LoggedUser.GetEvents();
		}
		public FacebookObjectCollection<Post> GetPosts()
		{
			return m_LoggedUser.GetPosts();
		}
		public FacebookObjectCollection<AppUser> GetFriends()
		{
			return m_LoggedUser.GetFriends();
		}

		public string GetCity()
		{
			return m_LoggedUser.GetCity();
		}

		public string GetBirthday()
		{
			return m_LoggedUser.GetBirthday();
		}
	}
}

using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

//App ID: 2246590548924227

namespace MyFacebookApp.Model
{
	public class AppEngine
	{
		private AppUser m_LoggedUser;
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
	}
}

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
		public FacebookObjectCollection<Album> GetAllAlbums()
		{
			return m_LoggedUser.GetAllAlbums();
		}
		public FacebookObjectCollection<Event> GetAllEvents()
		{
			return m_LoggedUser.GetAllEvents();
		}
		public FacebookObjectCollection<Post> GetAllPosts()
		{
			return m_LoggedUser.GetAllPosts();
		}
	}
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFacebookApp.Model
{
    public class AppUser
    {
        User m_LoggedInUser;

        public AppUser(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string GetProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }
        public string GetFirstName()
        {
            return m_LoggedInUser.FirstName;
        }
		public FacebookObjectCollection<Album> GetAllAlbums()
		{
			return m_LoggedInUser.Albums;
		}
		public FacebookObjectCollection<Event> GetAllEvents()
		{
			return m_LoggedInUser.Events;
		}
		public FacebookObjectCollection<Post> GetAllPosts()
		{
			return m_LoggedInUser.Posts;
		}
	}
}

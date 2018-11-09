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

		internal AppUser(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

		public string GetProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

		//TODO:
		//Add (!= null || Exceptions When taking data form logged user).

		public string GetFirstName()
        {
            return m_LoggedInUser.FirstName;
        }
		public string GetLastName()
		{
			return m_LoggedInUser.LastName;
		}
		public FacebookObjectCollection<Album> GetAlbums()
		{
			return m_LoggedInUser.Albums;
		}

		internal string GetGender()
		{

			return m_LoggedInUser.Gender.ToString();
		}

		internal FacebookObjectCollection<Event> GetEvents()
		{
			return m_LoggedInUser.Events;
		}
		internal FacebookObjectCollection<Post> GetPosts()
		{
			return m_LoggedInUser.Posts;
		}
		internal FacebookObjectCollection<AppUser> GetFriends()
		{
			FacebookObjectCollection<AppUser> friends = new FacebookObjectCollection<AppUser>();
			foreach (User currFriend in m_LoggedInUser.Friends)
			{
				friends.Add(new AppUser(currFriend));
			}

			return friends;
		}

		public Page GetWorkPlace()
		{
			Page workPlace = null;

			if (m_LoggedInUser.WorkExperiences != null)
			{
				if (m_LoggedInUser.WorkExperiences[m_LoggedInUser.WorkExperiences.Length - 1] != null)
				{
					workPlace = m_LoggedInUser.WorkExperiences[m_LoggedInUser.WorkExperiences.Length - 1].Employer;
				}
			}
			return workPlace;
		}

		public string GetCity()
		{
			return m_LoggedInUser.Location.Name;
		}

		public string GetBirthday()
		{
			return m_LoggedInUser.Birthday;
		}
	}
}

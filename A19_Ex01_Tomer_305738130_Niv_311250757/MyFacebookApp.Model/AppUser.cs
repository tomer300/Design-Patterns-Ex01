using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static FacebookWrapper.ObjectModel.User;

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
			string pictureURL;

			try
			{
				pictureURL = m_LoggedInUser.PictureNormalURL;

				if(pictureURL == null)
				{
					throw new ArgumentNullException("No profile picture.");
				}
			}
			catch(Exception ex)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch profile picture.");
			}

			return pictureURL;
			
        }

		public string GetFirstName()
        {
			string firstName;

			try
			{
				firstName = m_LoggedInUser.FirstName;

				if (firstName == null)
				{
					throw new ArgumentNullException("No first name.");
				}
			}
			catch (Exception ex)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch first name.");
			}

            return firstName;
        }

		public string GetLastName()
		{
			string lastName;

			try
			{
				lastName = m_LoggedInUser.LastName;

				if (lastName == null)
				{
					throw new ArgumentNullException("No last name.");
				}
			}
			catch (Exception ex)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch last name.");
			}

			return lastName;
		}

		public FacebookObjectCollection<Album> GetAlbums()
		{
			return m_LoggedInUser.Albums;
		}

		internal eGender? GetGender()
		{

			return m_LoggedInUser.Gender;
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
			foreach (User currentFriend in m_LoggedInUser.Friends)
			{
				friends.Add(new AppUser(currentFriend));
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

		internal eRelationshipStatus? GetRelationshipStatus()
		{
			return m_LoggedInUser.RelationshipStatus;
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

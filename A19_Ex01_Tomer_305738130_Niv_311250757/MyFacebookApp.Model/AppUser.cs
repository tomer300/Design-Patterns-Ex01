using System;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace MyFacebookApp.Model
{
	public class AppUser
	{
		private User m_LoggedInUser;

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
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's profile picture.");
			}

			return pictureURL;
		}

		public string GetCity()
		{
			string cityName;

			try
			{
				cityName = m_LoggedInUser.Location.Name;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's city.");
			}

			return cityName;
		}

		public string GetBirthday()
		{
			string birthday;

			try
			{
				birthday = m_LoggedInUser.Birthday;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's birthday.");
			}

			return birthday;
		}

		public string GetFirstName()
		{
			string firstName;

			try
			{
				firstName = m_LoggedInUser.FirstName;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's first name.");
			}

			return firstName;
		}

		public string GetLastName()
		{
			string lastName;

			try
			{
				lastName = m_LoggedInUser.LastName;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's last name.");
			}

			return lastName;
		}

		public FacebookObjectCollection<Album> GetAlbums()
		{
			FacebookObjectCollection<Album> albums;

			try
			{
				albums = m_LoggedInUser.Albums;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's albums.");
			}

			return albums;
		}

		internal eGender? GetGender()
		{
			eGender? usersGender;

			try
			{
				usersGender = m_LoggedInUser.Gender;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's gender.");
			}

			return m_LoggedInUser.Gender;
		}

		internal FacebookObjectCollection<Event> GetEvents()
		{
			FacebookObjectCollection<Event> events;

			try
			{
				events = m_LoggedInUser.Events;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's events.");
			}

			return events;
		}

		internal FacebookObjectCollection<Post> GetPosts()
		{
			FacebookObjectCollection<Post> posts;

			try
			{
				posts = m_LoggedInUser.Posts;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's posts.");
			}

			return posts;
		}

		internal FacebookObjectCollection<AppUser> GetFriends()
		{
			FacebookObjectCollection<AppUser> friends = new FacebookObjectCollection<AppUser>();
			FacebookObjectCollection<User> userFriends;

			try
			{
				userFriends = m_LoggedInUser.Friends;
				foreach (User currentFriend in userFriends)
				{
					friends.Add(new AppUser(currentFriend));
				}
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's friends.");
			}

			return friends;
		}

		public Page GetWorkPlace()
		{
			Page workPlace = null;
			WorkExperience[] allWorks;

			try
			{
				allWorks = m_LoggedInUser.WorkExperiences;
				if (allWorks != null && allWorks.Length > 0)
				{
					if (m_LoggedInUser.WorkExperiences[m_LoggedInUser.WorkExperiences.Length - 1] != null)
					{
						workPlace = m_LoggedInUser.WorkExperiences[m_LoggedInUser.WorkExperiences.Length - 1].Employer;
					}
				}
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's work experience.");
			}

			return workPlace;
		}

		internal eRelationshipStatus? GetRelationshipStatus()
		{
			eRelationshipStatus? userRelationshipStatus;
			try
			{
				userRelationshipStatus = m_LoggedInUser.RelationshipStatus;
			}
			catch (Exception)
			{
				throw new Facebook.FacebookApiException("Couldn't fetch user's relationship status.");
			}

			return m_LoggedInUser.RelationshipStatus;
		}
	}
}

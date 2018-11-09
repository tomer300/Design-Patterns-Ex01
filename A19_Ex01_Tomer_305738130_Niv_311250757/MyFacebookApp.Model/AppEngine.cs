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
//Check if able to create a function that handles creating a new picture box with width, height, async, sizemode.
//every try and catch need to be inside of ui part to show a messagebox, need to do try and catch in engine only if we want to change ex message.
//auto scroll to a picture in job screen
//chanage all curr to current
//change all functions to click insted of clicked
//clear every flowlayout/listbox/items in every function start.
//check if internal names are capital or not.
//check match album showing, need to deal with invoke (we want to invoke only when in homapanel and its null).
//App ID: 2246590548924227
namespace MyFacebookApp.Model
{
	public class AppEngine
	{
		private AppUser m_LoggedUser;
		private Job m_Job;
		private Match m_Match;
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
			if (m_Job == null)
			{
				m_Job = new Job(m_LoggedUser.GetFriends());
			}
			return m_Job.FindHitechWorkerContacts();
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

		public FacebookObjectCollection<AppUser> FindAMatch(bool i_ChoseGirls, bool i_ChoseBoys, string i_AgeRange)
		{
			if (m_Match == null)
			{
				m_Match = new Match(m_LoggedUser.GetFriends());
			}

			return m_Match.FindAMatch(i_ChoseGirls, i_ChoseBoys, i_AgeRange);
		}
	}
}

using System;
using FacebookWrapper;

namespace MyFacebookApp.Model
{
	public static class FacebookManager
	{
		public static AppEngine Login()
		{
				LoginResult loginResult = FacebookService.Login(
				"2246590548924227",
				"public_profile",
				"user_birthday",
				"user_gender",
				"user_friends",
				"user_events",
				"user_hometown",
				"user_likes",
				"user_location",
				"user_photos",
				"user_posts",
				/*"user_about_me",
				"user_relationships",
				"user_relationship_details",
				"user_work_history",*/

				//Check if neccessery
				"read_page_mailboxes",
				"manage_pages",
				"publish_pages"
				//"publish_actions",
				//"user_managed_groups",
				//"publish_actions",
				// "rsvp_event"
				);
			// These are NOT the complete list of permissions. Other permissions for example:
			// "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
			// The documentation regarding facebook login and permissions can be found here:
			 
			// https://developers.facebook.com/docs/facebook-login/permissions#reference

			if (!string.IsNullOrEmpty(loginResult.AccessToken))
			{
				AppSettings.Settings.LastAccessToken = loginResult.AccessToken;
				return new AppEngine(new AppUser(loginResult.LoggedInUser));
			}
			else
			{
				throw new Exception(loginResult.ErrorMessage);
			}
		}

		public static void Logout()
		{
			FacebookService.Logout(null);
		}

		public static AppEngine AutoLogin()
		{
			AppEngine appEngine = null;

			if(AppSettings.Settings.RememberUser && !string.IsNullOrEmpty(AppSettings.Settings.LastAccessToken))
			{
				LoginResult loginResult = FacebookService.Connect(AppSettings.Settings.LastAccessToken);
				appEngine = new AppEngine(new AppUser(loginResult.LoggedInUser));
			}

			return appEngine;
		}
	}
}

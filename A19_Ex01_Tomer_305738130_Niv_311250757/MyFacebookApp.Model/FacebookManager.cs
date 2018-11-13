using System;
using FacebookWrapper;

namespace MyFacebookApp.Model
{
	public class FacebookManager
	{		
		public AppEngine Login()
		{
			LoginResult result = FacebookService.Login(
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

			if (!string.IsNullOrEmpty(result.AccessToken))
			{
				return new AppEngine(new AppUser(result.LoggedInUser));
			}
			else
			{
				throw new Exception(result.ErrorMessage);
			}
		}

		public void Logout()
		{
			FacebookService.Logout(null);
		}
	}
}

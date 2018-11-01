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
        private AppDetails m_AppDetails;
        public bool HasLoginSuccessful { get; private set; }

        public void PerformLogin()
        {
            LoginResult result = FacebookService.Login("2246590548924227",
                "public_profile",
                //"user_education_history",
                "user_birthday",
                //"user_about_me",
                "user_friends",
                //"publish_actions",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
               // "user_managed_groups",
                "user_photos",
                "user_posts",
               // "user_relationships",
               // "user_relationship_details",
              //  "user_work_history",
                "read_page_mailboxes",
                //Check if neccessery
                "manage_pages",
                "publish_pages"
                //"publish_actions",

               // "rsvp_event"
                );
            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            // https://developers.facebook.com/docs/facebook-login/permissions#reference


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_AppDetails = new AppDetails(new AppUser(result.LoggedInUser));
                HasLoginSuccessful = true;
            }
            else
            {
                HasLoginSuccessful = false;
                MessageBox.Show(result.ErrorMessage);
            }

        }

        public string GetProfilePicture()
        {
            return m_AppDetails.GetProfilePicture();
        }
        public string GetFirstName()
        {
            return m_AppDetails.GetFirstName();
        }
    }
}

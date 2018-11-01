using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFacebookApp.Model
{
    public class AppDetails
    {
        AppUser m_LoggedInUser;

        public AppDetails(AppUser i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string GetProfilePicture()
        {
            return m_LoggedInUser.GetProfilePicture();
        }
        public string GetFirstName()
        {
            return m_LoggedInUser.GetFirstName();
        }
    }
}

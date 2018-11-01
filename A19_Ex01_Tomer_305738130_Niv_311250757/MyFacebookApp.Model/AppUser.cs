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
    }
}

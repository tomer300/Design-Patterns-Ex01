﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;


//App ID: 2246590548924227

namespace MyFacebookApp.Model
{
    public class AppEngine
    {
        private User m_User;
        public void PerformLogin()
        {
            //m_User= guy dll user;
            /* throw new NotImplementedException();g*/
            m_User = new User();
        }

        public string GetUserName()
        {
            //return m_User.FirstName;
            return "Tomer";
        }
    }
}

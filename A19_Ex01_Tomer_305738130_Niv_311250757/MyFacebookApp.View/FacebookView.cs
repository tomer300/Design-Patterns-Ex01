﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyFacebookApp.Model;
namespace MyFacebookApp.View
{
    public partial class FacebookView : Form
	{
        private readonly AppEngine r_AppEngine = new AppEngine();
		public FacebookView()
		{
			InitializeComponent();
		}


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void findJobButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_AppEngine.PerformLogin();
                //saving the access token to a file using the engine within the perform login.
                loginButton.Text = string.Format("Hi, {0}",r_AppEngine.GetUserName());
            }
            catch(Exception e1)
            {
                string stam = e1.Message;
                //couldnt login
            }
        }
    }
}

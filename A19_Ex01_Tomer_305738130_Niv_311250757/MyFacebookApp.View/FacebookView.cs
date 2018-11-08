using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyFacebookApp.Model;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.View
{
	public partial class FacebookView : Form
	{
		private AppEngine m_AppEngine;
		private FacebookManager m_FacebookManager;

		public FacebookView()
		{
			InitializeComponent();
		}

		private void findJobButton_Click(object sender, EventArgs e)
		{
			panelJob = new JobPanel(m_AppEngine);
			panelJob.AddLogoutButton(logoutButton);
			panelJob.AddBackToHomeButton(backToHomeButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(panelJob);
		}
		
		private void backToHomePage(object sender, EventArgs e)
		{
			panelMain.Controls.Clear();
			panelHomePage.AddLogoutButton(logoutButton);
			panelMain.Controls.Add(panelHomePage);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				m_FacebookManager = new FacebookManager();
				m_AppEngine = m_FacebookManager.Login();
				panelHomePage = new HomePanel(m_AppEngine);
				panelHomePage.AddLogoutButton(logoutButton);
				this.panelMain.Controls.Add(this.panelHomePage);
				setAppButtonsEnabledStatus(true);
				//Job stam = new Job();
			}
			catch (Exception exLogin)
			{
				MessageBox.Show(string.Format("Error! could'nt login - {0}.", exLogin.Message));
			}
		}

		private void setAppButtonsEnabledStatus(bool i_IsEnabled)
		{
			loadDetailsAppButton.Enabled = i_IsEnabled;
			findJobAppButton.Enabled = i_IsEnabled;
			findAMatchAppButton.Enabled = i_IsEnabled;
			logoutButton.Enabled = i_IsEnabled;
		}

		private void loadDetailsButton_Click(object sender, EventArgs e)
		{ 
			panelHomePage.ShowAllDetails();
		}

		private void findAMatchAppButton_Click(object sender, EventArgs e)
		{
			panelMatch = new MatchPanel(m_AppEngine);
			panelMatch.AddLogoutButton(logoutButton);
			panelMatch.AddBackToHomeButton(backToHomeButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(panelMatch);
		}
		
		private void logoutButton_Click(object sender, EventArgs e)
		{
			m_FacebookManager.Logout();
			panelMain.Controls.Clear();
			setAppButtonsEnabledStatus(false);
		}
	}
}

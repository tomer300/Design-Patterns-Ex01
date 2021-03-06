﻿using System;
using System.Windows.Forms;
using MyFacebookApp.Model;

namespace MyFacebookApp.View
{
	public partial class FacebookView : Form
	{
		private AppEngine m_AppEngine;

		public FacebookView()
		{
			InitializeComponent();
			createLogoutAndBackButtons();
 		}

		private void createLogoutAndBackButtons()
		{
			this.logoutButton = new RoundedButton();
			this.backToHomeButton = new RoundedButton();
			//
			// logoutButton
			// 
			this.logoutButton.Enabled = false;
			this.logoutButton.Location = new System.Drawing.Point(788, 10);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(135, 35);
			this.logoutButton.TabIndex = 10;
			this.logoutButton.Text = "Logout";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// backToHomeButton
			// 
			this.backToHomeButton.Location = new System.Drawing.Point(-1, 10);
			this.backToHomeButton.Name = "backToHomeButton";
			this.backToHomeButton.Size = new System.Drawing.Size(135, 35);
			this.backToHomeButton.TabIndex = 2;
			this.backToHomeButton.Text = "Back To Home";
			this.backToHomeButton.UseVisualStyleBackColor = true;
			this.backToHomeButton.Click += new System.EventHandler(this.backToHomePage);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			AppSettings.LoadAppSettings();

			if (AppSettings.Settings.RememberUser)
			{
				m_AppEngine = FacebookManager.AutoLogin();

				if (m_AppEngine != null)
				{
					createHomePanel();
					loadSettings();
				}
			}
		}

		private void loadSettings()
		{
			this.Location = AppSettings.Settings.Location;
			this.panelHomePage.RememberMeStatus = AppSettings.Settings.RememberUser;
			panelHomePage.ShowAllDetails();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			saveSettings();
		}

		private void saveSettings()
		{
			if (panelHomePage != null)
			{
				AppSettings.Settings.RememberUser = panelHomePage.RememberMeStatus;
			}

			AppSettings.Settings.Location = this.Location;
			AppSettings.Settings.SaveAppSettings();
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
				m_AppEngine = FacebookManager.Login();
				createHomePanel();
			}
			catch (Exception exLogin)
			{
				MessageBox.Show(string.Format("Error! could'nt login - {0}.", exLogin.Message));
			}
		}

		private void createHomePanel()
		{
			panelHomePage = new HomePanel(m_AppEngine);
			panelHomePage.AddLogoutButton(logoutButton);
			this.panelMain.Controls.Clear();
			this.panelMain.Controls.Add(this.panelHomePage);
			setAppButtonsEnabledStatus(true);
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
			this.panelMain.Controls.Clear();
			this.panelMain.Controls.Add(panelHomePage);
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
			FacebookManager.Logout();
			panelMain.Controls.Clear();
			setAppButtonsEnabledStatus(false);
		}
	}
}

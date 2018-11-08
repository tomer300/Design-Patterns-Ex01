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

			if(panelFindJob == null)
			{
				createJobPanel();
			}
			panelFindJob.Controls.Add(logoutButton);
			panelFindJob.Controls.Add(this.backToHomePageFromJobPanelButton);
			panelMain.Controls.Clear();
			panelMain.Controls.Add(panelFindJob);

		}

		private void createJobPanel()
		{
			this.panelFindJob = new Panel();
			this.findAJobButton = new Button();
			this.listBoxJobs = new ListBox();
			// 
			// panelFindJob
			//
			this.panelFindJob.Controls.Add(this.backToHomePageFromJobPanelButton);
			this.panelFindJob.Controls.Add(this.listBoxJobs);
			this.panelFindJob.Controls.Add(this.findAJobButton);
			this.panelFindJob.Location = new System.Drawing.Point(1, -2);
			this.panelFindJob.Name = "panelFindJob";
			this.panelFindJob.Size = new System.Drawing.Size(935, 536);
			this.panelFindJob.TabIndex = 2;
			// 
			// findAJobButton
			//
			this.findAJobButton.Location = new System.Drawing.Point(376, 66);
			this.findAJobButton.Name = "findAJobButton";
			this.findAJobButton.Size = new System.Drawing.Size(163, 55);
			this.findAJobButton.TabIndex = 0;
			this.findAJobButton.Text = "Find me a job!";
			this.findAJobButton.UseVisualStyleBackColor = true;
			// 
			// listBoxJobs
			// 
			this.listBoxJobs.FormattingEnabled = true;
			this.listBoxJobs.ItemHeight = 23;
			this.listBoxJobs.Location = new System.Drawing.Point(206, 162);
			this.listBoxJobs.Name = "listBoxJobs";
			this.listBoxJobs.Size = new System.Drawing.Size(529, 211);
			this.listBoxJobs.TabIndex = 1;
		}

		private void backToHomePage(object sender, EventArgs e)
		{
			panelMain.Controls.Clear();
			panelHomePage.addLogoutButton(logoutButton);
			panelMain.Controls.Add(panelHomePage);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				m_FacebookManager = new FacebookManager();
				m_AppEngine = m_FacebookManager.Login();
				panelHomePage = new JobPanel(m_AppEngine);
				panelHomePage.addLogoutButton(logoutButton);
				this.panelMain.Controls.Add(this.panelHomePage);
				setAppButtonsEnabledStatus(true);
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
			if(panelFindAMatch==null)
			{
				createMatchPanel();
			}
			panelFindAMatch.Controls.Add(this.backToHomePageFromJobPanelButton);
			panelFindAMatch.Controls.Add(logoutButton);
			panelMain.Controls.Clear();
				panelMain.Controls.Add(panelFindAMatch);
		}

		private void createMatchPanel()
		{ 
			this.panelFindAMatch = new Panel();
			this.findMeAMatchButton = new Button();
			this.flowLayoutPanelMatchPictures = new FlowLayoutPanel();
			this.labelBetweenAges = new Label();
			this.comboBoxAgeRanges = new ComboBox();
			this.labelInterestedIn = new Label();
			this.checkBoxBoys = new CheckBox();
			this.checkBoxGirls = new CheckBox();
			// 
			// panelFindAMatch
			// 
			this.panelFindAMatch.Controls.Add(this.backToHomePageFromJobPanelButton);
			this.panelFindAMatch.Controls.Add(this.findMeAMatchButton);
			this.panelFindAMatch.Controls.Add(this.flowLayoutPanelMatchPictures);
			this.panelFindAMatch.Controls.Add(this.labelBetweenAges);
			this.panelFindAMatch.Controls.Add(this.comboBoxAgeRanges);
			this.panelFindAMatch.Controls.Add(this.labelInterestedIn);
			this.panelFindAMatch.Controls.Add(this.checkBoxBoys);
			this.panelFindAMatch.Controls.Add(this.checkBoxGirls);
			this.panelFindAMatch.Location = new System.Drawing.Point(1, -2);
			this.panelFindAMatch.Name = "panelFindAMatch";
			this.panelFindAMatch.Size = new System.Drawing.Size(935, 536);
			this.panelFindAMatch.TabIndex = 2;
			// 
			// findMeAMatchButton
			// 
			this.findMeAMatchButton.Location = new System.Drawing.Point(362, 233);
			this.findMeAMatchButton.Name = "findMeAMatchButton";
			this.findMeAMatchButton.Size = new System.Drawing.Size(209, 39);
			this.findMeAMatchButton.TabIndex = 6;
			this.findMeAMatchButton.Text = "Find me a match!";
			this.findMeAMatchButton.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelMatchPictures
			// 
			this.flowLayoutPanelMatchPictures.Location = new System.Drawing.Point(15, 300);
			this.flowLayoutPanelMatchPictures.Name = "flowLayoutPanelMatchPictures";
			this.flowLayoutPanelMatchPictures.Size = new System.Drawing.Size(908, 223);
			this.flowLayoutPanelMatchPictures.TabIndex = 5;
			// 
			// labelBetweenAges
			// 
			this.labelBetweenAges.AutoSize = true;
			this.labelBetweenAges.Location = new System.Drawing.Point(358, 151);
			this.labelBetweenAges.Name = "labelBetweenAges";
			this.labelBetweenAges.Size = new System.Drawing.Size(157, 23);
			this.labelBetweenAges.TabIndex = 4;
			this.labelBetweenAges.Text = "Between Ages:";
			// 
			// comboBoxAgeRanges
			// 
			this.comboBoxAgeRanges.FormattingEnabled = true;
			this.comboBoxAgeRanges.Items.AddRange(new object[] {
			"18-20",
			"21-25",
			"25-30",
			"31-35",
			"36-40",
			"41-45",
			"46-50",
			"50+"});
			this.comboBoxAgeRanges.Location = new System.Drawing.Point(362, 186);
			this.comboBoxAgeRanges.Name = "comboBoxAgeRanges";
			this.comboBoxAgeRanges.Size = new System.Drawing.Size(208, 31);
			this.comboBoxAgeRanges.TabIndex = 3;
			// 
			// labelInterestedIn
			// 
			this.labelInterestedIn.AutoSize = true;
			this.labelInterestedIn.Location = new System.Drawing.Point(358, 43);
			this.labelInterestedIn.Name = "labelInterestedIn";
			this.labelInterestedIn.Size = new System.Drawing.Size(136, 23);
			this.labelInterestedIn.TabIndex = 2;
			this.labelInterestedIn.Text = "Interested In:";
			// 
			// checkBoxBoys
			// 
			this.checkBoxBoys.AutoSize = true;
			this.checkBoxBoys.Location = new System.Drawing.Point(362, 111);
			this.checkBoxBoys.Name = "checkBoxBoys";
			this.checkBoxBoys.Size = new System.Drawing.Size(75, 27);
			this.checkBoxBoys.TabIndex = 1;
			this.checkBoxBoys.Text = "Boys";
			this.checkBoxBoys.UseVisualStyleBackColor = true;
			// 
			// checkBoxGirls
			// 
			this.checkBoxGirls.AutoSize = true;
			this.checkBoxGirls.Location = new System.Drawing.Point(362, 78);
			this.checkBoxGirls.Name = "checkBoxGirls";
			this.checkBoxGirls.Size = new System.Drawing.Size(71, 27);
			this.checkBoxGirls.TabIndex = 0;
			this.checkBoxGirls.Text = "Girls";
			this.checkBoxGirls.UseVisualStyleBackColor = true;
		}
		
		private void logoutButton_Click(object sender, EventArgs e)
		{
			m_FacebookManager.Logout();
			panelMain.Controls.Clear();
			setAppButtonsEnabledStatus(false);
		}
	}
}

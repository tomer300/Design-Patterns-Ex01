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

		private void backToHomePAge(object sender, EventArgs e)
		{
			panelMain.Controls.Clear();
			panelHomePageTop.Controls.Add(logoutButton);
			panelMain.Controls.Add(panelHomePage);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			//Check if Exception nesseccery
			try
			{
				m_FacebookManager = new FacebookManager();
				m_AppEngine = m_FacebookManager.Login();
				fetchInitialDetails();
				this.panelMain.Controls.Add(this.panelHomePage);
				setAppButtonsEnabledStatus(true);
				setUserInfoVisibilityStatus(true);
			}
			catch (Exception exLogin)
			{
				MessageBox.Show(string.Format("Error! could'nt login - {0}.", exLogin.Message));
			}
		}

		private void setUserInfoVisibilityStatus(bool i_IsVisible)
		{
			labelFirstName.Visible = i_IsVisible;
			labelLastName.Visible = i_IsVisible;
			labelCity.Visible = i_IsVisible;
			labelBirthDay.Visible = i_IsVisible;
			labelFirstNameInfo.Visible = i_IsVisible;
			labelLastNameInfo.Visible = i_IsVisible;
			labelCityInfo.Visible = i_IsVisible;
			labelBirthdayInfo.Visible = i_IsVisible;
		}

		private void setAppButtonsEnabledStatus(bool i_IsEnabled)
		{
			loadDetailsAppButton.Enabled = i_IsEnabled;
			findJobAppButton.Enabled = i_IsEnabled;
			findAMatchAppButton.Enabled = i_IsEnabled;
			albumsButton.Enabled = i_IsEnabled;
			eventsButton.Enabled = i_IsEnabled;
			postsButton.Enabled = i_IsEnabled;
			friendsButton.Enabled = i_IsEnabled;
			logoutButton.Enabled = i_IsEnabled;
		}

		private void fetchAlbums()
		{
			FacebookObjectCollection<Album> allAlbums = m_AppEngine.GetAlbums();

			foreach (Album currAlbum in allAlbums)
			{
				PictureBox currAlbumPictureBox = new PictureBox();
				currAlbumPictureBox.Height = 100;
				currAlbumPictureBox.Width = 100;
				currAlbumPictureBox.Cursor = Cursors.Hand;
				currAlbumPictureBox.MouseEnter += new EventHandler(album_Enter);
				currAlbumPictureBox.MouseLeave += new EventHandler(album_Leave);
				currAlbumPictureBox.LoadAsync(currAlbum.CoverPhoto.PictureNormalURL);
				currAlbumPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				currAlbumPictureBox.Click += (sender, e) => album_Clicked(currAlbum);
				flowLayoutPanelAlbums.Controls.Add(currAlbumPictureBox);
			}
		}

		private void album_Leave(object sender, EventArgs e)
		{
			PictureBox albumLeft = sender as PictureBox;
			if (albumLeft != null)
			{
				albumLeft.BorderStyle = BorderStyle.None;
			}
		}

		private void album_Enter(object sender, EventArgs e)
		{
			PictureBox albumHovered = sender as PictureBox;
			if (albumHovered != null)
			{
				albumHovered.BorderStyle = BorderStyle.Fixed3D;
		}
	}

		private void album_Clicked(Album i_ClickedAlbum)
		{
			flowLayoutPanelAlbums.Controls.Clear();
			albumsButton.Text = "Back To Albums";
			foreach (Photo currPhoto in i_ClickedAlbum.Photos)
			{
				PictureBox currPhotoPictureBox = new PictureBox();
				currPhotoPictureBox.Width = 100;
				currPhotoPictureBox.Height = 100;
				currPhotoPictureBox.LoadAsync(currPhoto.PictureNormalURL);
				currPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				flowLayoutPanelAlbums.Controls.Add(currPhotoPictureBox);
			}

		}

		private void fetchInitialDetails()
		{
			PictureBoxUserProfile.LoadAsync(m_AppEngine.GetProfilePicture());
			labelFirstNameInfo.Text = m_AppEngine.GetFirstName();
			labelLastNameInfo.Text = m_AppEngine.GetLastName();
			labelCityInfo.Text = m_AppEngine.GetCity();
			labelBirthdayInfo.Text = m_AppEngine.GetBirthday();
			labelFirstName.AutoSize = true;
			labelLastNameInfo.AutoSize = true;
			labelCityInfo.AutoSize = true;
			labelBirthdayInfo.AutoSize = true;
		}

		private void albumsButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanelAlbums.Controls.Clear();
			albumsButton.Text = "Albums";
			try
			{
				fetchAlbums();
			}
			catch (Exception exAlbums)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch albums - {0}.", exAlbums.Message));
			}
		}

		private void eventsButton_Click(object sender, EventArgs e)
		{
			listBoxEvents.Controls.Clear();
			try
			{
				fetchEvents();
			}
			catch (Exception exEvents)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch events - {0}.", exEvents.Message));
			}

		}

		private void fetchEvents()
		{
			FacebookObjectCollection<Event> allEvents = m_AppEngine.GetEvents();
			listBoxEvents.Items.Clear();
			listBoxEvents.DisplayMember = "Name";
			foreach (Event fbEvent in allEvents)
			{
				listBoxEvents.Items.Add(fbEvent);
			}

			if (allEvents.Count == 0)
			{
				MessageBox.Show("No Events to retrieve :(");
			}

		}


		private void loadDetailsButton_Click(object sender, EventArgs e)
		{
			try { 
				fetchAlbums();
				fetchPosts();
				fetchEvents();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch information - {0}.", ex.Message));
			}

		}

		private void fetchPosts()
		{
			FacebookObjectCollection<Post> allPosts = m_AppEngine.GetPosts();
			tableLayoutPanelPosts.Controls.Clear();
			tableLayoutPanelPosts.RowStyles.Clear();
					
			foreach (Post currPost in allPosts)
			{

				Label postDetails = new Label();
				postDetails.Text = string.Format("Posted at: {0}{1}Post Type: {2}{3}"
					, currPost.CreatedTime.ToString(), Environment.NewLine, currPost.Type, Environment.NewLine);
				postDetails.AutoSize = true;
			
				bool isLegalPost = false;
				if (currPost.Message != null && currPost.Message.Length>0)
				{
					Label postMessage = new Label();
					postMessage.Text = currPost.Message;
					postMessage.AutoSize = true;
					tableLayoutPanelPosts.Controls.Add(postMessage);
					isLegalPost = true;
				}
				if (currPost.Caption != null && currPost.Caption.Length > 0)
				{
					Label postCaption = new Label();
					postCaption.Text = currPost.Caption;
					postCaption.AutoSize = true;
					tableLayoutPanelPosts.Controls.Add(postCaption);
					isLegalPost = true;
				}

				if (currPost.Type == Post.eType.photo)
				{
					PictureBox postPicture = new PictureBox();
					postPicture.Height = 100;
					postPicture.Width = 100;
					postPicture.LoadAsync(currPost.PictureURL);
					postPicture.SizeMode = PictureBoxSizeMode.StretchImage;
					tableLayoutPanelPosts.Controls.Add(postPicture);
					isLegalPost = true;
				}

				if (isLegalPost == true)
				{
					tableLayoutPanelPosts.Controls.Add(postDetails);
					Label seperator = new Label();
					seperator.Text = " ";
					seperator.AutoSize = true;
					tableLayoutPanelPosts.Controls.Add(seperator);
				}

			}
			Console.WriteLine("num of rows: " + tableLayoutPanelPosts.RowCount);
			if (allPosts.Count == 0)
			{
				MessageBox.Show("No Posts to retrieve :(");
			}
		}


		private void postsButton_Click(object sender, EventArgs e)
		{
			tableLayoutPanelPosts.Controls.Clear();
			try
			{
				fetchPosts();
			}
			catch (Exception exPosts)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch posts - {0}.", exPosts.Message));
			}
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

		private void friendsButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanelFriends.Controls.Clear();
			try
			{
				FacebookObjectCollection<AppUser> myFriends = m_AppEngine.GetFriends();
				foreach(AppUser friend in myFriends)
				{
					PictureBox pic = new PictureBox();
					pic.Width = 100;
					pic.Height = 100;
					pic.Load(friend.GetProfilePicture());
					pic.Paint += new PaintEventHandler((sender1, e1) =>
					{
						e1.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

						//string text = string.Format("{0} {1}", friend.GetFirstName(), friend.GetLastName());
						string firstName =  friend.GetFirstName();
						string lastName = friend.GetLastName();
						float fontSize = 12;
						SizeF firstNameSize = e1.Graphics.MeasureString(firstName, new Font("Franklin Gothic Heavy", fontSize));
						SizeF lastNameSize = e1.Graphics.MeasureString(lastName, new Font("Franklin Gothic Heavy", fontSize));
						/*	if(textSize.Width>pic.Width)
							{
								fontSize /= (float)1.3;
								textSize.Width /= (float)1.3;
								textSize.Height /= (float)1.3;
							}*/
						PointF locationToDraw = new PointF();
						locationToDraw.X = (pic.Width / 2) - (firstNameSize.Width / 2);
						locationToDraw.Y = (pic.Height/(float)1.4) - (firstNameSize.Height / (float)2);
						e1.Graphics.DrawString(firstName, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);
						locationToDraw.X = (pic.Width / 2) - (lastNameSize.Width / 2);
						locationToDraw.Y = (pic.Height / (float)1.1) - (lastNameSize.Height / (float)2);
						e1.Graphics.DrawString(lastName, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);

					}); ;
					
					flowLayoutPanelFriends.Controls.Add(pic);
				}
			}
			catch (Exception exPosts)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch posts - {0}.", exPosts.Message));
			}
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			m_FacebookManager.Logout();
			panelMain.Controls.Clear();
		}


		/*	private enum ePanelTypes
{
HomePage,
FindAJobPage,
FindADatePage,
}*/
	}
}

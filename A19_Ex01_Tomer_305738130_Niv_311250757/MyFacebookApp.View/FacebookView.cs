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
		private readonly AppEngine r_AppEngine = new AppEngine();
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
			panelMain.Controls.Clear();
			panelMain.Controls.Add(panelFindJob);

		}

		private void createJobPanel()
		{
			this.panelFindJob = new Panel();
			this.backToHomePageFromJobPanelButton = new Button();
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
			// 
			// backToHomePageFromJobPanelButton
			// 
			this.backToHomePageFromJobPanelButton.Location = new System.Drawing.Point(-1, 0);
			this.backToHomePageFromJobPanelButton.Name = "backToHomePageFromJobPanelButton";
			this.backToHomePageFromJobPanelButton.Size = new System.Drawing.Size(160, 55);
			this.backToHomePageFromJobPanelButton.TabIndex = 2;
			this.backToHomePageFromJobPanelButton.Text = "Back To Home";
			this.backToHomePageFromJobPanelButton.UseVisualStyleBackColor = true;
			this.backToHomePageFromJobPanelButton.Click += new EventHandler(backToHomePAge);

		}

		private void backToHomePAge(object sender, EventArgs e)
		{
			panelMain.Controls.Clear();
			panelMain.Controls.Add(panelHomePage);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			//Check if Exception nesseccery
			try
			{
				r_AppEngine.PerformLogin();
				fetchInitialDetails();
				setAppButtonsStatus(true);
				//saving the access token to a file using the engine within the perform login.
			}
			catch (Exception exLogin)
			{
				MessageBox.Show(string.Format("Error! could'nt login - {0}.", exLogin.Message));
			}
		}

		private void setAppButtonsStatus(bool i_Status)
		{
			loadDetailsAppButton.Enabled = i_Status;
			findJobAppButton.Enabled = i_Status;
			findDateAppButton.Enabled = i_Status;
			albumsButton.Enabled = i_Status;
			eventsButton.Enabled = i_Status;
			postsButton.Enabled = i_Status;

		}

		private void fetchAlbums()
		{
			FacebookObjectCollection<Album> allAlbums = r_AppEngine.GetAllAlbums();

			foreach (Album currAlbum in allAlbums)
			{
				PictureBox currAlbumPictureBox = new PictureBox();
				currAlbumPictureBox.Cursor = Cursors.Hand;
				currAlbumPictureBox.MouseHover += new EventHandler(album_Hovered);
				currAlbumPictureBox.LoadAsync(currAlbum.CoverPhoto.PictureNormalURL);
				currAlbumPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				currAlbumPictureBox.Click += (sender, e) => album_Clicked(currAlbum);
				flowLayoutPanelAlbums.Controls.Add(currAlbumPictureBox);
			}
		}

		private void album_Hovered(object sender, EventArgs e)
		{
			PictureBox albumHovered = sender as PictureBox;
			if (albumHovered != null)
			{
				/*Bitmap pic = new Bitmap(albumHovered.Image);
				for (int w = 0; w < pic.Width; w++)
				{
					for (int h = 0; h < pic.Height; h++)
					{
						Color c = pic.GetPixel(w, h);
						Color newC = Color.FromArgb(50, c);
						pic.SetPixel(w, h, newC);
					}
				}*/
		}
	}

		private void album_Clicked(Album i_ClickedAlbum)
		{
			flowLayoutPanelAlbums.Controls.Clear();
			albumsButton.Text = "Back To Albums";
			foreach (Photo currPhoto in i_ClickedAlbum.Photos)
			{
				PictureBox currPhotoPictureBox = new PictureBox();
				currPhotoPictureBox.LoadAsync(currPhoto.PictureNormalURL);
				currPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				flowLayoutPanelAlbums.Controls.Add(currPhotoPictureBox);
			}

		}

		private void fetchInitialDetails()
		{
			PictureBoxUserProfile.LoadAsync(r_AppEngine.GetProfilePicture());
			LabelUserName.Text = string.Format("Hi, {0}", r_AppEngine.GetFirstName());
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
			FacebookObjectCollection<Event> allEvents = r_AppEngine.GetAllEvents();
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

		private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void loadDetailsButton_Click(object sender, EventArgs e)
		{
			if (r_AppEngine.HasLoginSuccessful)
			{
				fetchAlbums();
				fetchEvents();
				fetchPosts();
			}
			else
			{
				MessageBox.Show("Please login first!");
			}
		}

		private void fetchPosts()
		{
			FacebookObjectCollection<Post> allPosts = r_AppEngine.GetAllPosts();

			foreach (Post currPost in allPosts)
			{
				if (currPost.Message != null)
				{
					//listViewPosts.Items.Add(currPost.Message);
					/*listViewPosts.Items.Add("--------");*/
				}
				/*else if (currPost.Caption != null)
				{
					listBoxPosts.Items.Add(currPost.Caption);
				}*/
				else
				{
					/*if(currPost.Type==Post.eType.photo)
					{ 
						PictureBox postPic = new PictureBox();
						postPic.Load(currPost.PictureURL);
						ImageList newPic = new ImageList();
						newPic.Images.Add(postPic.Image);
						listViewPosts.SmallImageList = newPic;
					}*/
				}
			}

			if (allPosts.Count == 0)
			{
				MessageBox.Show("No Posts to retrieve :(");
			}
		}

		private void postsButton_Click(object sender, EventArgs e)
		{
			listViewPosts.Controls.Clear();
			try
			{
				fetchPosts();
			}
			catch (Exception exPosts)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch posts - {0}.", exPosts.Message));
			}
		}
		/*	private enum ePanelTypes
	{
		HomePage,
		FindAJobPage,
		FindADatePage,
	}*/
	}
}

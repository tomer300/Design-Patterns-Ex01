using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model;

namespace MyFacebookApp.View
{
	public partial class HomePanel : UserControl, ILogoutable
	{
		private AppEngine m_AppEngine;

		public HomePanel(AppEngine i_AppEngine)
		{
			InitializeComponent();
			m_AppEngine = i_AppEngine;
			fetchInitialDetails();
		}

		//TODO: Minimize function
		private void friendsButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanelFriends.Controls.Clear();
			try
			{
				FacebookObjectCollection<AppUser> myFriends = m_AppEngine.GetFriends();
				foreach (AppUser friend in myFriends)
				{
					PictureBox pic = new PictureBox();
					pic.Width = 100;
					pic.Height = 100;
					pic.Load(friend.GetProfilePicture());
					pic.Paint += new PaintEventHandler((sender1, e1) =>
					{
						e1.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
						string firstName = friend.GetFirstName();
						string lastName = friend.GetLastName();
						float fontSize = 12;
						SizeF firstNameSize = e1.Graphics.MeasureString(firstName, new Font("Franklin Gothic Heavy", fontSize));
						SizeF lastNameSize = e1.Graphics.MeasureString(lastName, new Font("Franklin Gothic Heavy", fontSize));
						PointF locationToDraw = new PointF();
						locationToDraw.X = (pic.Width / 2) - (firstNameSize.Width / 2);
						locationToDraw.Y = (pic.Height / (float)1.4) - (firstNameSize.Height / (float)2);
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

		private void fetchAlbums()
		{
			FacebookObjectCollection<Album> allAlbums = m_AppEngine.GetAlbums();

			foreach (Album currAlbum in allAlbums)
			{
				if (currAlbum.Count > 0)
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
		}

		private void album_Leave(object sender, EventArgs e)
		{
			PictureBox albumLeft = sender as PictureBox;
			if (albumLeft != null)
			{
				albumLeft.BorderStyle = BorderStyle.None;
			}
		}

		internal void ShowAllDetails()
		{
			try
			{
				fetchAlbums();
				fetchPosts();
				fetchEvents();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch information - {0}.", ex.Message));
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
			panelUserDetails.SetProfilePicture(m_AppEngine.GetProfilePicture());
			panelUserDetails.SetFirstName(m_AppEngine.GetFirstName());
			panelUserDetails.SetLastName(m_AppEngine.GetLastName());
			panelUserDetails.SetCity(m_AppEngine.GetCity());
			panelUserDetails.SetBirthday(m_AppEngine.GetBirthday());
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

		//TODO: Minimize function
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
				if (currPost.Message != null && currPost.Message.Length > 0)
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

		public void AddLogoutButton(Button i_LogoutButton)
		{
			panelHomePageTop.Controls.Add(i_LogoutButton);
		}
	}
}

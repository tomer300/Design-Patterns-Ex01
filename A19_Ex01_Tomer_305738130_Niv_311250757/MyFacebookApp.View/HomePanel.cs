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
using System.Drawing.Drawing2D;

namespace MyFacebookApp.View
{
	public partial class HomePanel : UserControl, ILogoutable
	{
		private AppEngine m_AppEngine;
		private AlbumsManger m_AlbumsManager;

		public HomePanel(AppEngine i_AppEngine)
		{
			InitializeComponent();
			m_AppEngine = i_AppEngine;
			fetchInitialDetails();
		}

		private void friendsButton_Click(object sender, EventArgs e)
		{
			fetchFriends();
		}

		internal void ShowAllDetails()
		{
			try
			{
				displayAlbums();
				fetchPosts();
				fetchEvents();
				fetchFriends();
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Error! could'nt fetch information - {0}.", ex.Message));
			}
		}

		private void fetchFriends()
		{
			flowLayoutPanelFriends.Controls.Clear();
			try
			{
				FacebookObjectCollection<AppUser> myFriends = m_AppEngine.GetFriends();
				bool hasShownMessageBox = false;

				foreach (AppUser friend in myFriends)
				{
					string profilePictureURL = "";

					try
					{
						profilePictureURL = friend.GetProfilePicture();
					}
					catch (Exception ex)
					{
						if(!hasShownMessageBox)
						{
							MessageBox.Show(ex.Message);
							hasShownMessageBox = true;
						}
					}
					finally
					{
						PictureWrapper friendPictureWrapper = new PictureWrapper(profilePictureURL);
						PictureBox friendPicture = friendPictureWrapper.PictureBox;

						friendPicture.Paint += new PaintEventHandler((senderFriend, ePaint) =>
						{
							writeNameOnFriendPicture(senderFriend, ePaint, friend);
						});

						flowLayoutPanelFriends.Controls.Add(friendPicture);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void writeNameOnFriendPicture(object senderFriend, PaintEventArgs ePaint, AppUser i_Friend)
		{
			PictureBox friendPicture = senderFriend as PictureBox;


			if (friendPicture != null)
			{
				string friendFirstName = "";
				string friendLastName = "";
				try
				{
					friendFirstName = i_Friend.GetFirstName();
					friendLastName = i_Friend.GetLastName();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					float fontSize = 12;
					SizeF firstNameSize = ePaint.Graphics.MeasureString(friendFirstName, new Font("Franklin Gothic Heavy", fontSize));
					SizeF lastNameSize = ePaint.Graphics.MeasureString(friendLastName, new Font("Franklin Gothic Heavy", fontSize));
					PointF locationToDraw = new PointF();

					ePaint.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
					locationToDraw.X = (friendPicture.Width / 2) - (firstNameSize.Width / 2);
					locationToDraw.Y = (friendPicture.Height / (float)1.4) - (firstNameSize.Height / (float)2);
					ePaint.Graphics.DrawString(friendFirstName, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);
					locationToDraw.X = (friendPicture.Width / 2) - (lastNameSize.Width / 2);
					locationToDraw.Y = (friendPicture.Height / (float)1.1) - (lastNameSize.Height / (float)2);
					ePaint.Graphics.DrawString(friendLastName, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);
				}
			}
		}

		private void fetchInitialDetails()
		{
			string profilePictureURL = "";
			string firstName = "";
			string lastName = "";
			string cityName = "";
			string birthday = "";

			try
			{
				profilePictureURL = m_AppEngine.GetProfilePicture();
				firstName = m_AppEngine.GetFirstName();
				lastName = m_AppEngine.GetLastName();
				cityName = m_AppEngine.GetCity();
				birthday = m_AppEngine.GetBirthday();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				panelUserDetails.SetAllUserDetails(profilePictureURL, firstName, lastName, cityName, birthday);
			}
		}

		private void albumsButton_Click(object sender, EventArgs e)
		{
			displayAlbums();
		}
		private void displayAlbums()
		{
			
			if (m_AlbumsManager == null)
			{
				try
				{
					FacebookObjectCollection<Album> usersAlbums = m_AppEngine.GetAlbums();

					if (usersAlbums != null)
					{
						m_AlbumsManager = new AlbumsManger(m_AppEngine.GetAlbums(), flowLayoutPanelAlbums);
						m_AlbumsManager.AlbumClicked += albumsButtonChangeDescription;
						m_AlbumsManager.displayAlbums();
					}
					else
					{
						MessageBox.Show("User has no albums.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				albumsButton.Text = "Albums";
				m_AlbumsManager.displayAlbums();
			}
		}

		private void albumsButtonChangeDescription()
		{
			albumsButton.Text = "Back To Albums";
		}

		private void eventsButton_Click(object sender, EventArgs e)
		{
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
			FacebookObjectCollection<Event> allEvents;
			listBoxEvents.Items.Clear();
			try
			{
				allEvents = m_AppEngine.GetEvents();
				if(allEvents!=null && allEvents.Count>0)
				{
					listBoxEvents.DisplayMember = "Name";
					foreach (Event fbEvent in allEvents)
					{
						listBoxEvents.Items.Add(fbEvent);
					}
				}
				else
				{
					MessageBox.Show("No Events to retrieve :(");

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fetchPosts()
		{
			FacebookObjectCollection<Post> allPosts;

			tableLayoutPanelPosts.Controls.Clear();
			tableLayoutPanelPosts.RowStyles.Clear();
			try
			{
				allPosts = m_AppEngine.GetPosts();

				foreach (Post currentPost in allPosts)
				{
					bool isLegalPost = false;
					Label postDetails = new Label();
					postDetails.Text = string.Format("Posted at: {0}{1}Post Type: {2}{3}"
						, currentPost.CreatedTime.ToString(), Environment.NewLine, currentPost.Type, Environment.NewLine);
					postDetails.AutoSize = true;

					if (currentPost.Message != null)
					{
						addPostData(currentPost.Message, ref isLegalPost);
					}
					if (currentPost.Caption != null)
					{
						addPostData(currentPost.Caption, ref isLegalPost);
					}

					if (currentPost.Type == Post.eType.photo)
					{
						PictureWrapper postPictureWrapper = new PictureWrapper(currentPost.PictureURL);
						PictureBox postPicture = postPictureWrapper.PictureBox;

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
					if (allPosts.Count == 0)
					{
						MessageBox.Show("No Posts to retrieve :(");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void addPostData(string i_Content, ref bool io_IsLegalPost)
		{
			if (i_Content.Length > 0)
			{
				Label message = new Label();
				message.Text = i_Content;
				message.AutoSize = true;
				tableLayoutPanelPosts.Controls.Add(message);
				io_IsLegalPost = true;
			}
		}

		private void postsButton_Click(object sender, EventArgs e)
		{
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

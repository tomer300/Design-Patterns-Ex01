using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFacebookApp.View
{
	public delegate void albumClickedNotifyDelegate();
	internal class AlbumsManger
	{
		private FacebookObjectCollection<Album> m_AlbumsOfUser;
		private Panel m_PanelToDisplayIn;
		public event albumClickedNotifyDelegate AlbumClicked;
		internal AlbumsManger(FacebookObjectCollection<Album> i_AlbumsOfUser, Panel i_PanelToDisplayIn)
		{
			m_AlbumsOfUser = i_AlbumsOfUser;
			m_PanelToDisplayIn = i_PanelToDisplayIn;
		}
		internal void displayAlbums()
		{
			bool hasShownMessageBox = false;
			string albumPictureURL = "";
			m_PanelToDisplayIn.Controls.Clear();
			foreach (Album currentAlbum in m_AlbumsOfUser)
			{
				if (currentAlbum.Count > 0)
				{
					PictureWrapper currentAlbumPictureWrapper;
					PictureBox currentAlbumPictureBox;

					try
					{
						albumPictureURL = currentAlbum.CoverPhoto.PictureNormalURL;
					}
					catch (Facebook.FacebookApiException ex)
					{
						/*if (!hasShownMessageBox)
						{
							MessageBox.Show(ex.Message);
							hasShownMessageBox=true;
						}*/
						//current album has no cover photo.
					}
					finally
					{
						currentAlbumPictureWrapper = new PictureWrapper(albumPictureURL);
						currentAlbumPictureBox = currentAlbumPictureWrapper.PictureBox;
						currentAlbumPictureBox.Cursor = Cursors.Hand;
						currentAlbumPictureBox.MouseEnter += new EventHandler(album_Enter);
						currentAlbumPictureBox.MouseLeave += new EventHandler(album_Leave);
						currentAlbumPictureBox.Click += (sender, e) => album_Click(currentAlbum);
						m_PanelToDisplayIn.Controls.Add(currentAlbumPictureBox);
					}
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
		private void album_Enter(object sender, EventArgs e)
		{
			PictureBox albumHovered = sender as PictureBox;
			if (albumHovered != null)
			{
				albumHovered.BorderStyle = BorderStyle.Fixed3D;
			}
		}

		private void album_Click(Album i_ClickedAlbum)
		{
			m_PanelToDisplayIn.Controls.Clear();
			if(m_PanelToDisplayIn.Parent is HomePanel)
			{
				AlbumClicked.Invoke();
			}
			foreach (Photo currentPhoto in i_ClickedAlbum.Photos)
			{
				PictureWrapper currentPictureWrapper = new PictureWrapper(currentPhoto.PictureNormalURL);
				PictureBox currentPhotoPictureBox = currentPictureWrapper.PictureBox;
				m_PanelToDisplayIn.Controls.Add(currentPhotoPictureBox);
			}
		}
	}
}

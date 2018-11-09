using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model;
using System;
using System.Collections.Generic;
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
			m_PanelToDisplayIn.Controls.Clear();
			foreach (Album currAlbum in m_AlbumsOfUser)
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
					m_PanelToDisplayIn.Controls.Add(currAlbumPictureBox);
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

		private void album_Clicked(Album i_ClickedAlbum)
		{
			m_PanelToDisplayIn.Controls.Clear();
			//AlbumClicked.Invoke();
			foreach (Photo currPhoto in i_ClickedAlbum.Photos)
			{
				PictureBox currPhotoPictureBox = new PictureBox();
				currPhotoPictureBox.Width = 100;
				currPhotoPictureBox.Height = 100;
				currPhotoPictureBox.LoadAsync(currPhoto.PictureNormalURL);
				currPhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				m_PanelToDisplayIn.Controls.Add(currPhotoPictureBox);
			}
		}
	}
}

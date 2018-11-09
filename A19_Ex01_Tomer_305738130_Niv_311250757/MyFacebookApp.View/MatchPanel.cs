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
	public partial class MatchPanel : UserControl, ILogoutable, IBackable
	{
		private AppEngine m_AppEngine;

		public MatchPanel(AppEngine i_AppEngine)
		{
			InitializeComponent();
			m_AppEngine = i_AppEngine;
		}

		public void AddBackToHomeButton(Button i_BackToHomeButton)
		{
			panelMatch.Controls.Add(i_BackToHomeButton);
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			panelMatch.Controls.Add(i_LogoutButton);
		}

		private void findMeAMatchButton_Click(object sender, EventArgs e)
		{
			FacebookObjectCollection<AppUser> potentialMatches = m_AppEngine.FindAMatch(checkBoxGirls.Checked, checkBoxBoys.Checked,
				comboBoxAgeRanges.Items[comboBoxAgeRanges.SelectedIndex].ToString());
			//string matchFullName = "";
			flowLayoutPanelMatchPictures.Controls.Clear();
			panelUserDetails.Visible = false;
			foreach (AppUser currentPotentialMatch in potentialMatches)
			{
				PictureBox matchPic = new PictureBox();

				//match = string.Format("{0} {1}", currContact.GetFirstName(), currContact.GetLastName());
				matchPic.Width = 100;
				matchPic.Height = 100;
				matchPic.LoadAsync(currentPotentialMatch.GetProfilePicture());
				matchPic.SizeMode = PictureBoxSizeMode.StretchImage;
				//matchPic.Name = contactFullName;
				matchPic.Click += (user, ex) => match_Click(currentPotentialMatch);
				flowLayoutPanelMatchPictures.Controls.Add(matchPic);
			}
		}

		private void match_Click(AppUser currentPotentialMatch)
		{
			AlbumsManger matchAlbumsManager = new AlbumsManger(currentPotentialMatch.GetAlbums(), flowLayoutPanelMatchPictures);
			matchAlbumsManager.displayAlbums();
			panelUserDetails.Visible = true;
			panelUserDetails.SetAllUserDetails(currentPotentialMatch.GetProfilePicture(), currentPotentialMatch.GetFirstName(), 
				currentPotentialMatch.GetLastName(), currentPotentialMatch.GetCity(), currentPotentialMatch.GetBirthday());
		}

	}
}

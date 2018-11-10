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
			Controls.Add(i_BackToHomeButton);
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

		private void findMeAMatchButton_Click(object sender, EventArgs e)
		{
			if (checkedGenferPreference())
			{
				FacebookObjectCollection<AppUser> potentialMatches = m_AppEngine.FindAMatch(checkBoxGirls.Checked, checkBoxBoys.Checked,
					comboBoxAgeRanges.Items[comboBoxAgeRanges.SelectedIndex].ToString());
				flowLayoutPanelMatchPictures.Controls.Clear();
				panelUserDetails.Visible = false;
				foreach (AppUser currentPotentialMatch in potentialMatches)
				{
					PictureWrapper matchPicWrapper = new PictureWrapper(currentPotentialMatch.GetProfilePicture());
					PictureBox matchPic = matchPicWrapper.PictureBox;
					matchPic.Cursor = Cursors.Hand;
					matchPic.Click += (user, ex) => match_Click(currentPotentialMatch);
					flowLayoutPanelMatchPictures.Controls.Add(matchPic);
				}

				if(potentialMatches.Count == 0)
				{
					MessageBox.Show("No love for you today :(");
				}
			}
			else
			{
				MessageBox.Show("Please choose prefered gender.");
			}
		}

		private bool checkedGenferPreference()
		{
			bool choseGender = false;

			if(checkBoxBoys.Checked || checkBoxGirls.Checked)
			{
				choseGender = true;
			}

			return choseGender;
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

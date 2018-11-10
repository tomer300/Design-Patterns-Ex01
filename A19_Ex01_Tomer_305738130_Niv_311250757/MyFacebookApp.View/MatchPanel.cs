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
					PictureWrapper matchPicWrapper;
					string profilePictureURL = "";
					try
					{
						profilePictureURL = currentPotentialMatch.GetProfilePicture();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					finally
					{
						matchPicWrapper = new PictureWrapper(profilePictureURL);
						PictureBox matchPic = matchPicWrapper.PictureBox;
						matchPic.Cursor = Cursors.Hand;
						matchPic.Click += (user, ex) => match_Click(currentPotentialMatch);
						flowLayoutPanelMatchPictures.Controls.Add(matchPic);
					}
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
			string profilePictureURL = "";
			string potentialMatchFirstName = "";
			string potentialMatchLastName = "";
			string potentialMatchCity = "";
			string potentialMatchBirthday = "";

			try
			{
				profilePictureURL = currentPotentialMatch.GetProfilePicture();
				potentialMatchFirstName = currentPotentialMatch.GetFirstName();
				potentialMatchLastName = currentPotentialMatch.GetLastName();
				potentialMatchCity = currentPotentialMatch.GetCity();
				potentialMatchBirthday = currentPotentialMatch.GetBirthday();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				panelUserDetails.SetAllUserDetails(profilePictureURL, potentialMatch
					,
				potentialMatchLastName, potentialMatchCity, potentialMatchBirthday);
			}
		}

	}
}

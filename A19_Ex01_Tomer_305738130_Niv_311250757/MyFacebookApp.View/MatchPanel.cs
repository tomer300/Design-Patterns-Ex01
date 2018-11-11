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
			if (checkedGenderPreference())
			{
				FacebookObjectCollection<AppUser> potentialMatches = m_AppEngine.FindAMatch(checkBoxGirls.Checked, checkBoxBoys.Checked,
					comboBoxAgeRanges.Items[comboBoxAgeRanges.SelectedIndex].ToString());
				bool hasShownMessageBox = false;

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
						if (!hasShownMessageBox)
						{
							MessageBox.Show(ex.Message);
							hasShownMessageBox = true;
						}
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

		private bool checkedGenderPreference()
		{
			bool choseGender = false;

			if(checkBoxBoys.Checked || checkBoxGirls.Checked)
			{
				choseGender = true;
			}

			return choseGender;
		}

		private void match_Click(AppUser i_PotentialMatch)
		{
			AlbumsManger matchAlbumsManager;
			FacebookObjectCollection<Album> matchAlbums;
			string profilePictureURL = "";
			string potentialMatchFirstName = "";
			string potentialMatchLastName = "";
			string potentialMatchCity = "";
			string potentialMatchBirthday = "";

			try
			{
				matchAlbums = i_PotentialMatch.GetAlbums();
				if(matchAlbums!=null)
				{
					matchAlbumsManager = new AlbumsManger(matchAlbums, flowLayoutPanelMatchPictures);
					matchAlbumsManager.displayAlbums();
				}	
				
				profilePictureURL = i_PotentialMatch.GetProfilePicture();
				potentialMatchFirstName = i_PotentialMatch.GetFirstName();
				potentialMatchLastName = i_PotentialMatch.GetLastName();
				potentialMatchCity = i_PotentialMatch.GetCity();
				potentialMatchBirthday = i_PotentialMatch.GetBirthday();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				panelUserDetails.SetAllUserDetails(profilePictureURL, potentialMatchFirstName,
				potentialMatchLastName, potentialMatchCity, potentialMatchBirthday);
				panelUserDetails.Visible = true;
			}
		}

	}
}

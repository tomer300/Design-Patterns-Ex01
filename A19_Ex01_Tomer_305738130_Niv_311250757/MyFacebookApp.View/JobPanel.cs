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
	public partial class JobPanel : UserControl, ILogoutable, IBackable
	{
		private AppEngine m_AppEngine;
		private int m_LastChosenContactIndex;

		public JobPanel(AppEngine i_AppEngine)
		{
			InitializeComponent();
			m_AppEngine = i_AppEngine;
		}

		public void AddLogoutButton(Button i_LogoutButton)
		{
			Controls.Add(i_LogoutButton);
		}

		public void AddBackToHomeButton(Button i_BackToHomeButton)
		{
			Controls.Add(i_BackToHomeButton);
		}

		private void findAJobButton_Click(object sender, EventArgs e)
		{
			FacebookObjectCollection<AppUser> hitechWorkerContacts;
			bool hasShownMessageBox = false;

			listBoxJobs.Items.Clear();
			flowLayoutPanelContactPhotos.Controls.Clear();
			try
			{
				hitechWorkerContacts = m_AppEngine.FindHitechWorkersContacts();


				foreach (AppUser currentContact in hitechWorkerContacts)
				{
					string contactFullName = "";
					string profilePictureURL = "";
					string contactFirstName = "";
					string contactLastName = "";
					string workPlace = "";
					try
					{
						profilePictureURL = currentContact.GetProfilePicture();
						contactFirstName = currentContact.GetFirstName();
						contactLastName = currentContact.GetLastName();
						workPlace = currentContact.GetWorkPlace().Name;
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
						PictureWrapper contactPictureWrapper = new PictureWrapper(profilePictureURL);
						PictureBox contactPic = contactPictureWrapper.PictureBox;
						contactFullName = string.Format("{0} {1}", contactFirstName, contactLastName);
						contactPic.Name = contactFullName;
						contactPic.Click += new EventHandler(contactPic_Click);
						flowLayoutPanelContactPhotos.Controls.Add(contactPic);
						listBoxJobs.Items.Add(new ContactItem(new KeyValuePair<string, string>(contactFullName,
							string.Format("{0} works at", contactFullName, workPlace))));
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			listBoxJobs.SelectedIndexChanged += new EventHandler(contactInfo_Click);
		}

		private void contactInfo_Click(object sender, EventArgs e)
		{
			PictureBox lastChosenContactPhoto = flowLayoutPanelContactPhotos.Controls[m_LastChosenContactIndex] as PictureBox;
			ContactItem contactClicked;
			PictureBox contactPicture;
			string contactName = "";

			if (lastChosenContactPhoto != null)
			{
				lastChosenContactPhoto.BorderStyle = BorderStyle.None;
			}

			m_LastChosenContactIndex = listBoxJobs.SelectedIndex;
			contactClicked = listBoxJobs.Items[m_LastChosenContactIndex] as ContactItem;
			if (contactClicked != null)
			{
				contactName = contactClicked.Contact.Key;
				foreach (Control currentPicture in flowLayoutPanelContactPhotos.Controls)
				{
					contactPicture = currentPicture as PictureBox;
					if (contactPicture != null)
					{
						if (contactPicture.Name.Equals(contactName))
						{
							contactPicture.BorderStyle = BorderStyle.Fixed3D;
							contactPicture.Focus();
						}
					}
				}
			}
		}

		private void contactPic_Click(object sender, EventArgs e)
		{
			PictureBox clickedContact = sender as PictureBox;
			ContactItem currentContactInfo;
			string contactName;

			if(clickedContact != null)
			{
				contactName = clickedContact.Name;
				foreach(object currentItem in listBoxJobs.Items)
				{
					currentContactInfo = currentItem as ContactItem;
					if(currentContactInfo != null)
					{
						if(currentContactInfo.Contact.Key.Equals(contactName))
						{
							listBoxJobs.SetSelected(listBoxJobs.Items.IndexOf(currentItem), true);
							break;
						}
					}
				}
			}
		}

		private class ContactItem
		{
			public KeyValuePair<string, string> Contact { get; private set; }
			public ContactItem(KeyValuePair<string, string> i_Contact)
			{
				Contact = i_Contact;
			}
			public override string ToString()
			{
				return Contact.Value;
			}
		}
	}
}

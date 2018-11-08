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
			this.panelJob.Controls.Add(i_LogoutButton);
		}

		public void AddBackToHomeButton(Button i_BackToHomeButton)
		{
			this.panelJob.Controls.Add(i_BackToHomeButton);
		}

		private void findAJobButton_Click(object sender, EventArgs e)
		{
			//FacebookObjectCollection<AppUser> hitechWorkerContacts = m_AppEngine.FindHitechWorkersContacts();
			FacebookObjectCollection<AppUser> hitechWorkerContacts = m_AppEngine.GetFriends();

			foreach (AppUser currContact in hitechWorkerContacts)
			{
				string contactInfo = "";
				string contactItemName = "";
				PictureBox contactPic = new PictureBox();

				contactPic.Width = 100;
				contactPic.Height = 100;
				contactPic.LoadAsync(currContact.GetProfilePicture());
				contactPic.SizeMode = PictureBoxSizeMode.StretchImage;
				contactPic.Name = string.Format("{0} {1}", currContact.GetFirstName(),
					currContact.GetLastName());
				contactPic.Click += new EventHandler(contactPic_Click);
				flowLayoutPanelContactPhotos.Controls.Add(contactPic);

				contactInfo = string.Format("Name: {0} {1}", currContact.GetFirstName(), currContact.GetLastName());
				contactItemName = string.Format("{0} {1}", currContact.GetFirstName(), currContact.GetLastName());
				listBoxJobs.Items.Add(new ContactItem(new KeyValuePair<string, string>(contactItemName, contactInfo)));
			}

			listBoxJobs.SelectedIndexChanged += new EventHandler(contactInfo_Click);
		}

		private void contactInfo_Click(object sender, EventArgs e)
		{
			PictureBox lastChosenContactPhoto = flowLayoutPanelContactPhotos.Controls[m_LastChosenContactIndex] as PictureBox;
			string contactName = "";

			if(lastChosenContactPhoto != null)
			{
				lastChosenContactPhoto.BorderStyle = BorderStyle.None;
			}

			m_LastChosenContactIndex = listBoxJobs.SelectedIndex;
			ContactItem contactClicked = listBoxJobs.Items[m_LastChosenContactIndex] as ContactItem;
			if(contactClicked != null)
			{
				contactName = contactClicked.Contact.Key;
				foreach (Control currentPicture in flowLayoutPanelContactPhotos.Controls)
				{
					PictureBox contactPicture = currentPicture as PictureBox;
					if (contactPicture != null)
					{
						if (contactPicture.Name.Equals(contactName))
						{
							contactPicture.BorderStyle = BorderStyle.Fixed3D;
						}
					}

				}
			}
			
			
		}

		private void contactPic_Click(object sender, EventArgs e)
		{
			PictureBox clickedContact = sender as PictureBox;
			string contactName;

			if(clickedContact != null)
			{
				contactName = clickedContact.Name;
				foreach(object currentItem in listBoxJobs.Items)
				{
					ContactItem currentContactInfo = currentItem as ContactItem;
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
		class ContactItem
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

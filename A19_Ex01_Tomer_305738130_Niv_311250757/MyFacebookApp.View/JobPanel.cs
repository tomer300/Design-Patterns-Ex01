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
	}
}

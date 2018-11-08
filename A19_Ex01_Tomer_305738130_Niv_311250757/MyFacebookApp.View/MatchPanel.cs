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
	}
}

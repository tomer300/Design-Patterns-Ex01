using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFacebookApp.View
{
	public class RoundedButton : Button
	{
		private readonly Image r_BasicImage = Properties.Resources.basicRoundedButtonIcon as Image;
		private readonly Image r_HoverImage = Properties.Resources.hoverRoundedButtonIcon as Image;
		private readonly Image r_ClickImage = Properties.Resources.clickRoundedButtonIcon as Image;

		public RoundedButton()
		{
			this.Width = 130;
			this.Height = 40;
			this.BackColor = Color.Transparent;
			this.BackgroundImage = Properties.Resources.basicRoundedButtonIcon;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.FlatAppearance.BorderSize = 0;
			this.FlatAppearance.MouseDownBackColor = Color.Transparent;
			this.FlatAppearance.MouseOverBackColor = Color.Transparent;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MouseDown += RoundedButton_MouseDown;
			this.MouseUp += RoundedButton_MouseUp;
			this.MouseEnter += RoundedButton_MouseEnter;
			this.MouseLeave += RoundedButton_MouseLeave;
			this.Font = new Font("Century Gothic", 12);
			this.ForeColor = Color.FromArgb(41, 34, 62);
		}

		private void RoundedButton_MouseLeave(object sender, EventArgs e)
		{
			RoundedButton hoveredButton = sender as RoundedButton;

			if (hoveredButton != null)
			{
				hoveredButton.BackgroundImage = r_BasicImage;
			}
		}

		private void RoundedButton_MouseEnter(object sender, EventArgs e)
		{
			RoundedButton hoveredButton = sender as RoundedButton;

			if (hoveredButton != null)
			{
				hoveredButton.BackgroundImage = r_HoverImage;
			}
		}

		private void RoundedButton_MouseUp(object sender, MouseEventArgs e)
		{
			RoundedButton clickedButton = sender as RoundedButton;

			if (clickedButton != null)
			{
				clickedButton.BackgroundImage = r_BasicImage;
			}
		}

		private void RoundedButton_MouseDown(object sender, MouseEventArgs e)
		{
			RoundedButton clickedButton = sender as RoundedButton;
			if (clickedButton != null)
			{
				clickedButton.BackgroundImage = r_ClickImage;
			}
		}
	}
}

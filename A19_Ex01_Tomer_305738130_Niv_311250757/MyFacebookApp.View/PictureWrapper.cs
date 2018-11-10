using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFacebookApp.View
{
	public class PictureWrapper
	{
		public PictureBox PictureBox { get; private set; }

		public PictureWrapper(string i_PictureURL)
		{
			PictureBox = new PictureBox();
			PictureBox.Height = 100;
			PictureBox.Width = 100;
			if (i_PictureURL.Length > 0)
			{
				PictureBox.LoadAsync(i_PictureURL);
				PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				createEmptyPhoto();
			}
		}

		private void createEmptyPhoto()
		{
			PictureBox.BackColor = System.Drawing.Color.Gray;
			PictureBox.Paint += new PaintEventHandler((sender, e) =>
			{
				e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
				float fontSize = 12;
				string noPictureMessage = "No Picture";
				SizeF noPictureMessageSize = e.Graphics.MeasureString(noPictureMessage, new Font("Franklin Gothic Heavy", fontSize));
				PointF locationToDraw = new PointF();
				locationToDraw.X = (PictureBox.Width / 2) - (noPictureMessageSize.Width / 2);
				locationToDraw.Y = (PictureBox.Height / (float)1.4) - (noPictureMessageSize.Height / (float)2);
				e.Graphics.DrawString(noPictureMessage, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);
			});
		}
	}
}

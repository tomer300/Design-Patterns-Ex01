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

		public PictureWrapper(string i_PictureURL, int i_Width = 100, int i_Height= 100, PictureBoxSizeMode i_SizeMode = PictureBoxSizeMode.StretchImage)
		{
            PictureBox = new PictureBox { Width = i_Width, Height = i_Height };
			if (!string.IsNullOrEmpty(i_PictureURL))
			{
				PictureBox.LoadAsync(i_PictureURL);
				PictureBox.SizeMode = i_SizeMode;
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
				float	fontSize = 12;
				string	noPictureMessage = "No Picture";
				SizeF	noPictureMessageSize;
				PointF	locationToDraw = new PointF();

				e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
				noPictureMessageSize = e.Graphics.MeasureString(noPictureMessage, new Font("Franklin Gothic Heavy", fontSize));
				locationToDraw.X = (PictureBox.Width / 2) - (noPictureMessageSize.Width / 2);
				locationToDraw.Y = (PictureBox.Height / (float)1.4) - (noPictureMessageSize.Height / (float)2);
				e.Graphics.DrawString(noPictureMessage, new Font("Franklin Gothic Heavy", fontSize), Brushes.White, locationToDraw);
			});
		}
	}
}

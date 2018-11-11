using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFacebookApp.View
{
	class RoundedButton : Button
	{
		private GraphicsPath GetRoundPath(RectangleF i_Rectangle, int i_Radius)
		{
			float r2 = i_Radius / 2f;
			GraphicsPath GraphPath = new GraphicsPath();

			GraphPath.AddArc(i_Rectangle.X, i_Rectangle.Y, i_Radius, i_Radius, 180, 90);
			GraphPath.AddLine(i_Rectangle.X + r2, i_Rectangle.Y, i_Rectangle.Width - r2, i_Rectangle.Y);
			GraphPath.AddArc(i_Rectangle.X + i_Rectangle.Width - i_Radius, i_Rectangle.Y, i_Radius, i_Radius, 270, 90);
			GraphPath.AddLine(i_Rectangle.Width, i_Rectangle.Y + r2, i_Rectangle.Width, i_Rectangle.Height - r2);
			GraphPath.AddArc(i_Rectangle.X + i_Rectangle.Width - i_Radius,
							 i_Rectangle.Y + i_Rectangle.Height - i_Radius, i_Radius, i_Radius, 0, 90);
			GraphPath.AddLine(i_Rectangle.Width - r2, i_Rectangle.Height, i_Rectangle.X + r2, i_Rectangle.Height);
			GraphPath.AddArc(i_Rectangle.X, i_Rectangle.Y + i_Rectangle.Height - i_Radius, i_Radius, i_Radius, 90, 90);
			GraphPath.AddLine(i_Rectangle.X, i_Rectangle.Height - r2, i_Rectangle.X, i_Rectangle.Y + r2);
			GraphPath.CloseFigure();

			return GraphPath;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
			GraphicsPath GraphPath = GetRoundPath(Rect, 50);

			this.Region = new Region(GraphPath);
			using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
			{
				pen.Alignment = PenAlignment.Inset;
				e.Graphics.DrawPath(pen, GraphPath);
			}
		}
	}
}

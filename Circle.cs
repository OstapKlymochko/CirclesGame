using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

class Circle : PictureBox
{
	public static Dictionary<Color, int> points = new Dictionary<Color, int>()
	{
		{Color.Red, 10 },
		{Color.Yellow, 5 },
		{Color.Blue, 0 },
		{Color.Green, -20 }
	};
	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		using (var gp = new GraphicsPath())
		{
			gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
			this.Region = new Region(gp);
		}
	}

}

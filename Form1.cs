using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Timer = System.Timers.Timer;

namespace game
{
	public partial class Form1 : Form
	{
		private Random rnd = new Random();
		private int points = 0;
		private int record = 0;
		private int delay;
		public int Points
		{
			get
			{
				return points;
			}
			set
			{
				points = value;
				PointsCounter.Text = "Бали: " + points.ToString();
				if (points < 0)
				{
					StopGame_Click(this, null);
				}
			}
		}
		public int Record
		{
			get
			{
				return record;
			}
			set
			{
				record = value;
				RecordLabel.Text = "Рекорд: " + record.ToString();
			}
		}
		private Color[] colors = new[]
		{
			Color.Red,
			Color.Yellow,
			Color.Blue,
			Color.Green,
		};
		private Color getRandomColor()
		{
			return colors[rnd.Next(0, colors.Length)];
		}
		public Form1()
		{
			InitializeComponent();
			this.BackColor = Color.Gray;
			PointsCounter.Text = "Бали: " + points;
			RecordLabel.Text = "Рекорд: " + record.ToString();
			delay = 3 * this.GameTimer.Interval; 
		}
		private async void drawCircle()
		{
			int d = rnd.Next(20, 50);
			Circle circle = new Circle();
			circle.Height = d;
			circle.Width = d;
			circle.BackColor = this.getRandomColor();
			int x = rnd.Next(d, PlayGround.Width - d);
			int y = rnd.Next(d, PlayGround.Height - d);
			circle.Location = new Point(x, y);
			circle.Click += Circle_Click;
			PlayGround.Controls.Add(circle);
			Timer asd = new Timer(delay);
			asd.Elapsed += (sender, e) => remove(sender, circle);
			asd.Start();
		}
		private void remove(object sender, Circle c)
		{
			(sender as Timer).Dispose();
			if (PlayGround.Controls.Contains(c))
			{
				Points = c.BackColor == Color.Green ? Points : Points - Circle.points[c.BackColor];
				PlayGround.Controls.Remove(c);
			}
		}
		private void GameTimer_Tick(object sender, EventArgs e)
		{
			drawCircle();
		}

		private void StartGame_Click(object sender, EventArgs e)
		{
			StartGame.Enabled = false;
			StopGame.Enabled = true;
			GameTimer.Enabled = true;
			this.Points = 0;
			this.Record = 0;
		}

		private void StopGame_Click(object sender, EventArgs e)
		{
			StartGame.Enabled = true;
			StopGame.Enabled = false;
			GameTimer.Enabled = false;
			PlayGround.Controls.Clear();
			this.delay = 2400;
			GameTimer.Interval = 800;
		}
		private void Circle_Click(object sender, EventArgs e)
		{
			Circle item = sender as Circle;
			GameTimer.Interval = GameTimer.Interval <= 200 ? 200 : GameTimer.Interval - 20;
			this.Points += Circle.points[item.BackColor];
			this.Record += Circle.points[item.BackColor];
			this.PlayGround.Controls.Remove(item);
		}
	}
}
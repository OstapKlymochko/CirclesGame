namespace game
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			PointsCounter = new Label();
			PlayGround = new Panel();
			StartGame = new Button();
			GameTimer = new System.Windows.Forms.Timer(components);
			StopGame = new Button();
			RecordLabel = new Label();
			SuspendLayout();
			// 
			// PointsCounter
			// 
			PointsCounter.AutoSize = true;
			PointsCounter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			PointsCounter.Location = new Point(12, 9);
			PointsCounter.Name = "PointsCounter";
			PointsCounter.Size = new Size(72, 30);
			PointsCounter.TabIndex = 0;
			PointsCounter.Text = "label1";
			PointsCounter.Click += PointsCounter_Click;
			// 
			// PlayGround
			// 
			PlayGround.BackColor = Color.Transparent;
			PlayGround.Location = new Point(179, 9);
			PlayGround.Name = "PlayGround";
			PlayGround.Size = new Size(831, 539);
			PlayGround.TabIndex = 2;
			PlayGround.Paint += PlayGround_Paint;
			// 
			// StartGame
			// 
			StartGame.Location = new Point(12, 398);
			StartGame.Name = "StartGame";
			StartGame.Size = new Size(128, 30);
			StartGame.TabIndex = 3;
			StartGame.Text = "Розпочати гру!";
			StartGame.UseVisualStyleBackColor = true;
			StartGame.Click += StartGame_Click;
			// 
			// GameTimer
			// 
			GameTimer.Interval = 800;
			GameTimer.Tick += GameTimer_Tick;
			// 
			// StopGame
			// 
			StopGame.Enabled = false;
			StopGame.Location = new Point(12, 455);
			StopGame.Name = "StopGame";
			StopGame.Size = new Size(128, 30);
			StopGame.TabIndex = 4;
			StopGame.Text = "Зупинити гру";
			StopGame.UseVisualStyleBackColor = true;
			StopGame.Click += StopGame_Click;
			// 
			// RecordLabel
			// 
			RecordLabel.AutoSize = true;
			RecordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			RecordLabel.Location = new Point(12, 58);
			RecordLabel.Name = "RecordLabel";
			RecordLabel.Size = new Size(72, 30);
			RecordLabel.TabIndex = 5;
			RecordLabel.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1031, 571);
			Controls.Add(RecordLabel);
			Controls.Add(StopGame);
			Controls.Add(StartGame);
			Controls.Add(PlayGround);
			Controls.Add(PointsCounter);
			Name = "Form1";
			Text = "Гра в кульки";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public Label PointsCounter;
		public Panel PlayGround;
		private Button StartGame;
		private System.Windows.Forms.Timer GameTimer;
		private Button StopGame;
		public Label RecordLabel;
	}
}
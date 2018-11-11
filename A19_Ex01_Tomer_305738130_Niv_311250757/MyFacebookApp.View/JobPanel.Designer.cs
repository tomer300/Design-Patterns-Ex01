namespace MyFacebookApp.View
{
	partial class JobPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanelContactPhotos = new System.Windows.Forms.FlowLayoutPanel();
			this.listBoxJobs = new System.Windows.Forms.ListBox();
			this.findAJobButton = new RoundedButton();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// flowLayoutPanelContactPhotos
			// 
			this.flowLayoutPanelContactPhotos.AutoScroll = true;
			this.flowLayoutPanelContactPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanelContactPhotos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelContactPhotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.flowLayoutPanelContactPhotos.Location = new System.Drawing.Point(101, 347);
			this.flowLayoutPanelContactPhotos.Name = "flowLayoutPanelContactPhotos";
			this.flowLayoutPanelContactPhotos.Size = new System.Drawing.Size(732, 168);
			this.flowLayoutPanelContactPhotos.TabIndex = 5;
			// 
			// listBoxJobs
			// 
			this.listBoxJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxJobs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.listBoxJobs.FormattingEnabled = true;
			this.listBoxJobs.ItemHeight = 23;
			this.listBoxJobs.Location = new System.Drawing.Point(208, 183);
			this.listBoxJobs.Name = "listBoxJobs";
			this.listBoxJobs.Size = new System.Drawing.Size(529, 142);
			this.listBoxJobs.TabIndex = 4;
			// 
			// findAJobButton
			// 
			this.findAJobButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findAJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.findAJobButton.Location = new System.Drawing.Point(379, 113);
			this.findAJobButton.Name = "findAJobButton";
			this.findAJobButton.Size = new System.Drawing.Size(163, 55);
			this.findAJobButton.TabIndex = 3;
			this.findAJobButton.Text = "Find me a job!";
			this.findAJobButton.UseVisualStyleBackColor = true;
			this.findAJobButton.Click += new System.EventHandler(this.findAJobButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.label1.Location = new System.Drawing.Point(174, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(706, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Find friends who can help you in your job - hunt in Hi-Tech!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// JobPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flowLayoutPanelContactPhotos);
			this.Controls.Add(this.listBoxJobs);
			this.Controls.Add(this.findAJobButton);
			this.Name = "JobPanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContactPhotos;
		private System.Windows.Forms.ListBox listBoxJobs;
		private RoundedButton findAJobButton;
		private System.Windows.Forms.Label label1;
	}
}

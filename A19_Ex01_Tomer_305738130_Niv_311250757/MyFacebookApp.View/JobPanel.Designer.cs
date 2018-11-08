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
			this.listBoxJobs = new System.Windows.Forms.ListBox();
			this.findAJobButton = new System.Windows.Forms.Button();
			this.panelJob = new System.Windows.Forms.Panel();
			this.flowLayoutPanelContactPhotos = new System.Windows.Forms.FlowLayoutPanel();
			this.panelJob.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxJobs
			// 
			this.listBoxJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxJobs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.listBoxJobs.FormattingEnabled = true;
			this.listBoxJobs.ItemHeight = 23;
			this.listBoxJobs.Location = new System.Drawing.Point(206, 162);
			this.listBoxJobs.Name = "listBoxJobs";
			this.listBoxJobs.Size = new System.Drawing.Size(529, 142);
			this.listBoxJobs.TabIndex = 1;
			// 
			// findAJobButton
			// 
			this.findAJobButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findAJobButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.findAJobButton.Location = new System.Drawing.Point(376, 66);
			this.findAJobButton.Name = "findAJobButton";
			this.findAJobButton.Size = new System.Drawing.Size(163, 55);
			this.findAJobButton.TabIndex = 0;
			this.findAJobButton.Text = "Find me a job!";
			this.findAJobButton.UseVisualStyleBackColor = true;
			this.findAJobButton.Click += new System.EventHandler(this.findAJobButton_Click);
			// 
			// panelJob
			// 
			this.panelJob.Controls.Add(this.flowLayoutPanelContactPhotos);
			this.panelJob.Controls.Add(this.listBoxJobs);
			this.panelJob.Controls.Add(this.findAJobButton);
			this.panelJob.Location = new System.Drawing.Point(1, 0);
			this.panelJob.Name = "panelJob";
			this.panelJob.Size = new System.Drawing.Size(935, 536);
			this.panelJob.TabIndex = 3;
			// 
			// flowLayoutPanelContactPhotos
			// 
			this.flowLayoutPanelContactPhotos.AutoScroll = true;
			this.flowLayoutPanelContactPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanelContactPhotos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelContactPhotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.flowLayoutPanelContactPhotos.Location = new System.Drawing.Point(99, 330);
			this.flowLayoutPanelContactPhotos.Name = "flowLayoutPanelContactPhotos";
			this.flowLayoutPanelContactPhotos.Size = new System.Drawing.Size(734, 168);
			this.flowLayoutPanelContactPhotos.TabIndex = 2;
			// 
			// JobPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.panelJob);
			this.Name = "JobPanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.panelJob.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox listBoxJobs;
		private System.Windows.Forms.Button findAJobButton;
		private System.Windows.Forms.Panel panelJob;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContactPhotos;
	}
}

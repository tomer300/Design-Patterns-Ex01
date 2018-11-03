namespace MyFacebookApp.View
{
	partial class FacebookView
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMainButtons = new System.Windows.Forms.Panel();
			this.loadDetailsButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.findDateButton = new System.Windows.Forms.Button();
			this.findJobButton = new System.Windows.Forms.Button();
			this.panelFaceBookTitle = new System.Windows.Forms.Panel();
			this.panelHomePage = new System.Windows.Forms.Panel();
			this.LabelAppName = new System.Windows.Forms.Label();
			this.LabelUserName = new System.Windows.Forms.Label();
			this.PictureBoxUserProfile = new System.Windows.Forms.PictureBox();
			this.listViewPosts = new System.Windows.Forms.ListView();
			this.postsButton = new System.Windows.Forms.Button();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.eventsButton = new System.Windows.Forms.Button();
			this.albumsButton = new System.Windows.Forms.Button();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePAgeTop = new System.Windows.Forms.Panel();
			this.panelMainButtons.SuspendLayout();
			this.panelFaceBookTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).BeginInit();
			this.panelHomePAgeTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainButtons
			// 
			this.panelMainButtons.Controls.Add(this.loadDetailsButton);
			this.panelMainButtons.Controls.Add(this.loginButton);
			this.panelMainButtons.Controls.Add(this.findDateButton);
			this.panelMainButtons.Controls.Add(this.findJobButton);
			this.panelMainButtons.Controls.Add(this.panelFaceBookTitle);
			this.panelMainButtons.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMainButtons.Location = new System.Drawing.Point(0, 0);
			this.panelMainButtons.Name = "panelMainButtons";
			this.panelMainButtons.Size = new System.Drawing.Size(216, 536);
			this.panelMainButtons.TabIndex = 0;
			// 
			// loadDetailsButton
			// 
			this.loadDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loadDetailsButton.FlatAppearance.BorderSize = 0;
			this.loadDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadDetailsButton.Image = global::MyFacebookApp.View.Properties.Resources.loadButtonIcon;
			this.loadDetailsButton.Location = new System.Drawing.Point(0, 204);
			this.loadDetailsButton.Name = "loadDetailsButton";
			this.loadDetailsButton.Size = new System.Drawing.Size(216, 103);
			this.loadDetailsButton.TabIndex = 6;
			this.loadDetailsButton.Text = "Load Details";
			this.loadDetailsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.loadDetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.loadDetailsButton.UseVisualStyleBackColor = true;
			this.loadDetailsButton.Click += new System.EventHandler(this.loadDetailsButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Image = global::MyFacebookApp.View.Properties.Resources.loginButtonIcon;
			this.loginButton.Location = new System.Drawing.Point(0, 95);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(216, 103);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Login With Facebook";
			this.loginButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// findDateButton
			// 
			this.findDateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.findDateButton.FlatAppearance.BorderSize = 0;
			this.findDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findDateButton.Image = global::MyFacebookApp.View.Properties.Resources.dateButtonIcon;
			this.findDateButton.Location = new System.Drawing.Point(0, 422);
			this.findDateButton.Name = "findDateButton";
			this.findDateButton.Size = new System.Drawing.Size(216, 103);
			this.findDateButton.TabIndex = 4;
			this.findDateButton.Text = "Find A Date";
			this.findDateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.findDateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.findDateButton.UseVisualStyleBackColor = true;
			// 
			// findJobButton
			// 
			this.findJobButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.findJobButton.FlatAppearance.BorderSize = 0;
			this.findJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findJobButton.Image = global::MyFacebookApp.View.Properties.Resources.jobButtonIcon;
			this.findJobButton.Location = new System.Drawing.Point(0, 313);
			this.findJobButton.Name = "findJobButton";
			this.findJobButton.Size = new System.Drawing.Size(216, 103);
			this.findJobButton.TabIndex = 3;
			this.findJobButton.Text = "Find A Job";
			this.findJobButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.findJobButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.findJobButton.UseVisualStyleBackColor = true;
			this.findJobButton.Click += new System.EventHandler(this.findJobButton_Click);
			// 
			// panelFaceBookTitle
			// 
			this.panelFaceBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
			this.panelFaceBookTitle.Controls.Add(this.panelHomePage);
			this.panelFaceBookTitle.Controls.Add(this.LabelAppName);
			this.panelFaceBookTitle.Location = new System.Drawing.Point(0, 0);
			this.panelFaceBookTitle.Name = "panelFaceBookTitle";
			this.panelFaceBookTitle.Size = new System.Drawing.Size(216, 95);
			this.panelFaceBookTitle.TabIndex = 0;
			// 
			// panelHomePage
			// 
			this.panelHomePage.Location = new System.Drawing.Point(215, 0);
			this.panelHomePage.Name = "panelHomePage";
			this.panelHomePage.Size = new System.Drawing.Size(942, 536);
			this.panelHomePage.TabIndex = 1;
			// 
			// LabelAppName
			// 
			this.LabelAppName.AutoSize = true;
			this.LabelAppName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.LabelAppName.Location = new System.Drawing.Point(-1, 33);
			this.LabelAppName.Name = "LabelAppName";
			this.LabelAppName.Size = new System.Drawing.Size(217, 34);
			this.LabelAppName.TabIndex = 0;
			this.LabelAppName.Text = "Facebook App";
			this.LabelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelUserName
			// 
			this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelUserName.Location = new System.Drawing.Point(806, 95);
			this.LabelUserName.Name = "LabelUserName";
			this.LabelUserName.Size = new System.Drawing.Size(136, 21);
			this.LabelUserName.TabIndex = 1;
			// 
			// PictureBoxUserProfile
			// 
			this.PictureBoxUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureBoxUserProfile.Location = new System.Drawing.Point(806, 3);
			this.PictureBoxUserProfile.Name = "PictureBoxUserProfile";
			this.PictureBoxUserProfile.Size = new System.Drawing.Size(136, 95);
			this.PictureBoxUserProfile.TabIndex = 0;
			this.PictureBoxUserProfile.TabStop = false;
			// 
			// listViewPosts
			// 
			this.listViewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listViewPosts.Location = new System.Drawing.Point(216, 207);
			this.listViewPosts.Name = "listViewPosts";
			this.listViewPosts.Size = new System.Drawing.Size(473, 132);
			this.listViewPosts.TabIndex = 15;
			this.listViewPosts.UseCompatibleStateImageBehavior = false;
			// 
			// postsButton
			// 
			this.postsButton.AutoSize = true;
			this.postsButton.Enabled = false;
			this.postsButton.Location = new System.Drawing.Point(216, 168);
			this.postsButton.Name = "postsButton";
			this.postsButton.Size = new System.Drawing.Size(122, 33);
			this.postsButton.TabIndex = 14;
			this.postsButton.Text = "Posts";
			this.postsButton.UseVisualStyleBackColor = true;
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 23;
			this.listBoxEvents.Location = new System.Drawing.Point(691, 383);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(463, 142);
			this.listBoxEvents.TabIndex = 13;
			// 
			// eventsButton
			// 
			this.eventsButton.AutoSize = true;
			this.eventsButton.Enabled = false;
			this.eventsButton.Location = new System.Drawing.Point(695, 344);
			this.eventsButton.Name = "eventsButton";
			this.eventsButton.Size = new System.Drawing.Size(122, 33);
			this.eventsButton.TabIndex = 12;
			this.eventsButton.Text = "Events";
			this.eventsButton.UseVisualStyleBackColor = true;
			// 
			// albumsButton
			// 
			this.albumsButton.AutoSize = true;
			this.albumsButton.Enabled = false;
			this.albumsButton.Location = new System.Drawing.Point(222, 345);
			this.albumsButton.Name = "albumsButton";
			this.albumsButton.Size = new System.Drawing.Size(122, 33);
			this.albumsButton.TabIndex = 11;
			this.albumsButton.Text = "Albums";
			this.albumsButton.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelAlbums
			// 
			this.flowLayoutPanelAlbums.AutoScroll = true;
			this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(222, 383);
			this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
			this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(467, 142);
			this.flowLayoutPanelAlbums.TabIndex = 10;
			// 
			// panelHomePAgeTop
			// 
			this.panelHomePAgeTop.Controls.Add(this.LabelUserName);
			this.panelHomePAgeTop.Controls.Add(this.PictureBoxUserProfile);
			this.panelHomePAgeTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHomePAgeTop.Location = new System.Drawing.Point(216, 0);
			this.panelHomePAgeTop.Name = "panelHomePAgeTop";
			this.panelHomePAgeTop.Size = new System.Drawing.Size(942, 151);
			this.panelHomePAgeTop.TabIndex = 9;
			// 
			// FacebookView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1158, 536);
			this.Controls.Add(this.listViewPosts);
			this.Controls.Add(this.postsButton);
			this.Controls.Add(this.listBoxEvents);
			this.Controls.Add(this.eventsButton);
			this.Controls.Add(this.albumsButton);
			this.Controls.Add(this.flowLayoutPanelAlbums);
			this.Controls.Add(this.panelHomePAgeTop);
			this.Controls.Add(this.panelMainButtons);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FacebookView";
			this.Text = "Facebook App";
			this.panelMainButtons.ResumeLayout(false);
			this.panelFaceBookTitle.ResumeLayout(false);
			this.panelFaceBookTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).EndInit();
			this.panelHomePAgeTop.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panelMainButtons;
        private System.Windows.Forms.Button findDateButton;
        private System.Windows.Forms.Panel panelFaceBookTitle;
        private System.Windows.Forms.Label LabelAppName;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button loadDetailsButton;
        private System.Windows.Forms.Button findJobButton;
		private System.Windows.Forms.Panel panelHomePage;
		private System.Windows.Forms.Label LabelUserName;
		private System.Windows.Forms.PictureBox PictureBoxUserProfile;
		private System.Windows.Forms.ListView listViewPosts;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button eventsButton;
		private System.Windows.Forms.Button albumsButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
		private System.Windows.Forms.Panel panelHomePAgeTop;
	}
}


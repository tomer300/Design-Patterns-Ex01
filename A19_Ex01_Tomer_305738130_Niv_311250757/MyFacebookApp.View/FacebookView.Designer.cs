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
			this.loadDetailsAppButton = new System.Windows.Forms.Button();
			this.loginAppButton = new System.Windows.Forms.Button();
			this.findAMatchAppButton = new System.Windows.Forms.Button();
			this.findJobAppButton = new System.Windows.Forms.Button();
			this.panelFaceBookTitle = new System.Windows.Forms.Panel();
			this.LabelAppName = new System.Windows.Forms.Label();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelHomePage = new System.Windows.Forms.Panel();
			this.listViewPosts = new System.Windows.Forms.ListView();
			this.postsButton = new System.Windows.Forms.Button();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.eventsButton = new System.Windows.Forms.Button();
			this.albumsButton = new System.Windows.Forms.Button();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePAgeTop = new System.Windows.Forms.Panel();
			this.LabelUserName = new System.Windows.Forms.Label();
			this.PictureBoxUserProfile = new System.Windows.Forms.PictureBox();
			this.panelMainButtons.SuspendLayout();
			this.panelFaceBookTitle.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelHomePage.SuspendLayout();
			this.panelHomePAgeTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMainButtons
			// 
			this.panelMainButtons.Controls.Add(this.loadDetailsAppButton);
			this.panelMainButtons.Controls.Add(this.loginAppButton);
			this.panelMainButtons.Controls.Add(this.findAMatchAppButton);
			this.panelMainButtons.Controls.Add(this.findJobAppButton);
			this.panelMainButtons.Controls.Add(this.panelFaceBookTitle);
			this.panelMainButtons.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMainButtons.Location = new System.Drawing.Point(0, 0);
			this.panelMainButtons.Name = "panelMainButtons";
			this.panelMainButtons.Size = new System.Drawing.Size(216, 536);
			this.panelMainButtons.TabIndex = 0;
			// 
			// loadDetailsAppButton
			// 
			this.loadDetailsAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loadDetailsAppButton.Enabled = false;
			this.loadDetailsAppButton.FlatAppearance.BorderSize = 0;
			this.loadDetailsAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadDetailsAppButton.Image = global::MyFacebookApp.View.Properties.Resources.loadButtonIcon;
			this.loadDetailsAppButton.Location = new System.Drawing.Point(0, 204);
			this.loadDetailsAppButton.Name = "loadDetailsAppButton";
			this.loadDetailsAppButton.Size = new System.Drawing.Size(216, 103);
			this.loadDetailsAppButton.TabIndex = 6;
			this.loadDetailsAppButton.Text = "Load Details";
			this.loadDetailsAppButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.loadDetailsAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.loadDetailsAppButton.UseVisualStyleBackColor = true;
			this.loadDetailsAppButton.Click += new System.EventHandler(this.loadDetailsButton_Click);
			// 
			// loginAppButton
			// 
			this.loginAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginAppButton.FlatAppearance.BorderSize = 0;
			this.loginAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginAppButton.Image = global::MyFacebookApp.View.Properties.Resources.loginButtonIcon;
			this.loginAppButton.Location = new System.Drawing.Point(0, 95);
			this.loginAppButton.Name = "loginAppButton";
			this.loginAppButton.Size = new System.Drawing.Size(216, 103);
			this.loginAppButton.TabIndex = 5;
			this.loginAppButton.Text = "Login With Facebook";
			this.loginAppButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.loginAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.loginAppButton.UseVisualStyleBackColor = true;
			this.loginAppButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// findAMatchAppButton
			// 
			this.findAMatchAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.findAMatchAppButton.Enabled = false;
			this.findAMatchAppButton.FlatAppearance.BorderSize = 0;
			this.findAMatchAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findAMatchAppButton.Image = global::MyFacebookApp.View.Properties.Resources.dateButtonIcon;
			this.findAMatchAppButton.Location = new System.Drawing.Point(0, 422);
			this.findAMatchAppButton.Name = "findAMatchAppButton";
			this.findAMatchAppButton.Size = new System.Drawing.Size(216, 103);
			this.findAMatchAppButton.TabIndex = 4;
			this.findAMatchAppButton.Text = "Find A Match";
			this.findAMatchAppButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.findAMatchAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.findAMatchAppButton.UseVisualStyleBackColor = true;
			this.findAMatchAppButton.Click += new System.EventHandler(this.findAMatchAppButton_Click);
			// 
			// findJobAppButton
			// 
			this.findJobAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.findJobAppButton.Enabled = false;
			this.findJobAppButton.FlatAppearance.BorderSize = 0;
			this.findJobAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findJobAppButton.Image = global::MyFacebookApp.View.Properties.Resources.jobButtonIcon;
			this.findJobAppButton.Location = new System.Drawing.Point(0, 313);
			this.findJobAppButton.Name = "findJobAppButton";
			this.findJobAppButton.Size = new System.Drawing.Size(216, 103);
			this.findJobAppButton.TabIndex = 3;
			this.findJobAppButton.Text = "Find A Job";
			this.findJobAppButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.findJobAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.findJobAppButton.UseVisualStyleBackColor = true;
			this.findJobAppButton.Click += new System.EventHandler(this.findJobButton_Click);
			// 
			// panelFaceBookTitle
			// 
			this.panelFaceBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
			this.panelFaceBookTitle.Controls.Add(this.LabelAppName);
			this.panelFaceBookTitle.Location = new System.Drawing.Point(0, 0);
			this.panelFaceBookTitle.Name = "panelFaceBookTitle";
			this.panelFaceBookTitle.Size = new System.Drawing.Size(216, 95);
			this.panelFaceBookTitle.TabIndex = 0;
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
			// panelMain
			// 
			this.panelMain.Controls.Add(this.panelHomePage);
			this.panelMain.Location = new System.Drawing.Point(222, 3);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(936, 533);
			this.panelMain.TabIndex = 1;
			// 
			// panelHomePage
			// 
			this.panelHomePage.Controls.Add(this.listViewPosts);
			this.panelHomePage.Controls.Add(this.postsButton);
			this.panelHomePage.Controls.Add(this.listBoxEvents);
			this.panelHomePage.Controls.Add(this.eventsButton);
			this.panelHomePage.Controls.Add(this.albumsButton);
			this.panelHomePage.Controls.Add(this.flowLayoutPanelAlbums);
			this.panelHomePage.Controls.Add(this.panelHomePAgeTop);
			this.panelHomePage.Location = new System.Drawing.Point(1, -2);
			this.panelHomePage.Name = "panelHomePage";
			this.panelHomePage.Size = new System.Drawing.Size(935, 536);
			this.panelHomePage.TabIndex = 2;
			// 
			// listViewPosts
			// 
			this.listViewPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listViewPosts.Location = new System.Drawing.Point(0, 204);
			this.listViewPosts.Name = "listViewPosts";
			this.listViewPosts.Size = new System.Drawing.Size(473, 132);
			this.listViewPosts.TabIndex = 22;
			this.listViewPosts.UseCompatibleStateImageBehavior = false;
			// 
			// postsButton
			// 
			this.postsButton.AutoSize = true;
			this.postsButton.Enabled = false;
			this.postsButton.Location = new System.Drawing.Point(0, 165);
			this.postsButton.Name = "postsButton";
			this.postsButton.Size = new System.Drawing.Size(122, 33);
			this.postsButton.TabIndex = 21;
			this.postsButton.Text = "Posts";
			this.postsButton.UseVisualStyleBackColor = true;
			this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 23;
			this.listBoxEvents.Location = new System.Drawing.Point(475, 380);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(463, 142);
			this.listBoxEvents.TabIndex = 20;
			// 
			// eventsButton
			// 
			this.eventsButton.AutoSize = true;
			this.eventsButton.Enabled = false;
			this.eventsButton.Location = new System.Drawing.Point(479, 341);
			this.eventsButton.Name = "eventsButton";
			this.eventsButton.Size = new System.Drawing.Size(122, 33);
			this.eventsButton.TabIndex = 19;
			this.eventsButton.Text = "Events";
			this.eventsButton.UseVisualStyleBackColor = true;
			this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
			// 
			// albumsButton
			// 
			this.albumsButton.AutoSize = true;
			this.albumsButton.Enabled = false;
			this.albumsButton.Location = new System.Drawing.Point(6, 342);
			this.albumsButton.Name = "albumsButton";
			this.albumsButton.Size = new System.Drawing.Size(122, 33);
			this.albumsButton.TabIndex = 18;
			this.albumsButton.Text = "Albums";
			this.albumsButton.UseVisualStyleBackColor = true;
			this.albumsButton.Click += new System.EventHandler(this.albumsButton_Click);
			// 
			// flowLayoutPanelAlbums
			// 
			this.flowLayoutPanelAlbums.AutoScroll = true;
			this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(6, 380);
			this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
			this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(467, 142);
			this.flowLayoutPanelAlbums.TabIndex = 17;
			// 
			// panelHomePAgeTop
			// 
			this.panelHomePAgeTop.Controls.Add(this.LabelUserName);
			this.panelHomePAgeTop.Controls.Add(this.PictureBoxUserProfile);
			this.panelHomePAgeTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHomePAgeTop.Location = new System.Drawing.Point(0, 0);
			this.panelHomePAgeTop.Name = "panelHomePAgeTop";
			this.panelHomePAgeTop.Size = new System.Drawing.Size(935, 151);
			this.panelHomePAgeTop.TabIndex = 16;
			// 
			// LabelUserName
			// 
			this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelUserName.Location = new System.Drawing.Point(796, 95);
			this.LabelUserName.Name = "LabelUserName";
			this.LabelUserName.Size = new System.Drawing.Size(136, 21);
			this.LabelUserName.TabIndex = 1;
			// 
			// PictureBoxUserProfile
			// 
			this.PictureBoxUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureBoxUserProfile.Location = new System.Drawing.Point(796, 3);
			this.PictureBoxUserProfile.Name = "PictureBoxUserProfile";
			this.PictureBoxUserProfile.Size = new System.Drawing.Size(136, 95);
			this.PictureBoxUserProfile.TabIndex = 0;
			this.PictureBoxUserProfile.TabStop = false;
			// 
			// backToHomePageFromJobPanelButton
			//
			this.backToHomePageFromJobPanelButton = new System.Windows.Forms.Button();
			this.backToHomePageFromJobPanelButton.Location = new System.Drawing.Point(-1, 0);
			this.backToHomePageFromJobPanelButton.Name = "backToHomePageFromJobPanelButton";
			this.backToHomePageFromJobPanelButton.Size = new System.Drawing.Size(160, 55);
			this.backToHomePageFromJobPanelButton.TabIndex = 2;
			this.backToHomePageFromJobPanelButton.Text = "Back To Home";
			this.backToHomePageFromJobPanelButton.UseVisualStyleBackColor = true;
			this.backToHomePageFromJobPanelButton.Click += new System.EventHandler(backToHomePAge);
			// 
			// FacebookView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1158, 536);
			this.Controls.Add(this.panelMain);
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
			this.panelMain.ResumeLayout(false);
			this.panelHomePage.ResumeLayout(false);
			this.panelHomePage.PerformLayout();
			this.panelHomePAgeTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelMainButtons;
        private System.Windows.Forms.Button findAMatchAppButton;
        private System.Windows.Forms.Panel panelFaceBookTitle;
        private System.Windows.Forms.Label LabelAppName;
        private System.Windows.Forms.Button loginAppButton;
        private System.Windows.Forms.Button loadDetailsAppButton;
        private System.Windows.Forms.Button findJobAppButton;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelHomePage;
		private System.Windows.Forms.ListView listViewPosts;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button eventsButton;
		private System.Windows.Forms.Button albumsButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
		private System.Windows.Forms.Panel panelHomePAgeTop;
		private System.Windows.Forms.Label LabelUserName;
		private System.Windows.Forms.PictureBox PictureBoxUserProfile;
		private System.Windows.Forms.Panel panelFindJob;
		private System.Windows.Forms.Panel panelFindAMatch;
		private System.Windows.Forms.ListBox listBoxJobs;
		private System.Windows.Forms.Button findAJobButton;
		private System.Windows.Forms.Button backToHomePageFromJobPanelButton;
		private System.Windows.Forms.Button findMeAMatchButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMatchPictures;
		private System.Windows.Forms.Label labelBetweenAges;
		private System.Windows.Forms.ComboBox comboBoxAgeRanges;
		private System.Windows.Forms.Label labelInterestedIn;
		private System.Windows.Forms.CheckBox checkBoxBoys;
		private System.Windows.Forms.CheckBox checkBoxGirls;

	}
}


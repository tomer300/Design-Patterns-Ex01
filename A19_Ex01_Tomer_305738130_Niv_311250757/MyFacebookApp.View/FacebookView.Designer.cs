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
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelHomePage = new System.Windows.Forms.Panel();
			this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
			this.friendsButton = new System.Windows.Forms.Button();
			this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
			this.postsButton = new System.Windows.Forms.Button();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.eventsButton = new System.Windows.Forms.Button();
			this.albumsButton = new System.Windows.Forms.Button();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePageTop = new System.Windows.Forms.Panel();
			this.labelCityInfo = new System.Windows.Forms.Label();
			this.labelBirthdayInfo = new System.Windows.Forms.Label();
			this.labelLastNameInfo = new System.Windows.Forms.Label();
			this.labelFirstNameInfo = new System.Windows.Forms.Label();
			this.labelCity = new System.Windows.Forms.Label();
			this.labelBirthDay = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.LabelUserName = new System.Windows.Forms.Label();
			this.PictureBoxUserProfile = new System.Windows.Forms.PictureBox();
			this.backToHomePageFromJobPanelButton = new System.Windows.Forms.Button();
			this.findJobAppButton = new System.Windows.Forms.Button();
			this.findAMatchAppButton = new System.Windows.Forms.Button();
			this.loadDetailsAppButton = new System.Windows.Forms.Button();
			this.panelMainButtons = new System.Windows.Forms.Panel();
			this.loginAppButton = new System.Windows.Forms.Button();
			this.panelFaceBookTitle = new System.Windows.Forms.Panel();
			this.labelAppName = new System.Windows.Forms.Label();
			this.panelShadowColorLight = new System.Windows.Forms.Panel();
			this.panelShadowColorDark = new System.Windows.Forms.Panel();
			this.panelMain.SuspendLayout();
			this.panelHomePage.SuspendLayout();
			this.panelHomePageTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).BeginInit();
			this.panelMainButtons.SuspendLayout();
			this.panelFaceBookTitle.SuspendLayout();
			this.panelShadowColorLight.SuspendLayout();
			this.SuspendLayout();
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
			this.panelHomePage.Controls.Add(this.flowLayoutPanelFriends);
			this.panelHomePage.Controls.Add(this.friendsButton);
			this.panelHomePage.Controls.Add(this.tableLayoutPanelPosts);
			this.panelHomePage.Controls.Add(this.postsButton);
			this.panelHomePage.Controls.Add(this.listBoxEvents);
			this.panelHomePage.Controls.Add(this.eventsButton);
			this.panelHomePage.Controls.Add(this.albumsButton);
			this.panelHomePage.Controls.Add(this.flowLayoutPanelAlbums);
			this.panelHomePage.Controls.Add(this.panelHomePageTop);
			this.panelHomePage.Location = new System.Drawing.Point(1, -2);
			this.panelHomePage.Name = "panelHomePage";
			this.panelHomePage.Size = new System.Drawing.Size(935, 536);
			this.panelHomePage.TabIndex = 2;
			// 
			// flowLayoutPanelFriends
			// 
			this.flowLayoutPanelFriends.AutoScroll = true;
			this.flowLayoutPanelFriends.Location = new System.Drawing.Point(479, 196);
			this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
			this.flowLayoutPanelFriends.Size = new System.Drawing.Size(444, 142);
			this.flowLayoutPanelFriends.TabIndex = 18;
			// 
			// friendsButton
			// 
			this.friendsButton.AutoSize = true;
			this.friendsButton.Enabled = false;
			this.friendsButton.Location = new System.Drawing.Point(479, 157);
			this.friendsButton.Name = "friendsButton";
			this.friendsButton.Size = new System.Drawing.Size(122, 33);
			this.friendsButton.TabIndex = 23;
			this.friendsButton.Text = "Friends";
			this.friendsButton.UseVisualStyleBackColor = true;
			this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
			// 
			// tableLayoutPanelPosts
			// 
			this.tableLayoutPanelPosts.AutoScroll = true;
			this.tableLayoutPanelPosts.ColumnCount = 1;
			this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Location = new System.Drawing.Point(6, 196);
			this.tableLayoutPanelPosts.Name = "tableLayoutPanelPosts";
			this.tableLayoutPanelPosts.RowCount = 1;
			this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Size = new System.Drawing.Size(463, 140);
			this.tableLayoutPanelPosts.TabIndex = 22;
			// 
			// postsButton
			// 
			this.postsButton.AutoSize = true;
			this.postsButton.Enabled = false;
			this.postsButton.Location = new System.Drawing.Point(6, 157);
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
			this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 23;
			this.listBoxEvents.Location = new System.Drawing.Point(475, 380);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(448, 138);
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
			this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(463, 142);
			this.flowLayoutPanelAlbums.TabIndex = 17;
			// 
			// panelHomePageTop
			// 
			this.panelHomePageTop.Controls.Add(this.labelCityInfo);
			this.panelHomePageTop.Controls.Add(this.labelBirthdayInfo);
			this.panelHomePageTop.Controls.Add(this.labelLastNameInfo);
			this.panelHomePageTop.Controls.Add(this.labelFirstNameInfo);
			this.panelHomePageTop.Controls.Add(this.labelCity);
			this.panelHomePageTop.Controls.Add(this.labelBirthDay);
			this.panelHomePageTop.Controls.Add(this.labelLastName);
			this.panelHomePageTop.Controls.Add(this.labelFirstName);
			this.panelHomePageTop.Controls.Add(this.LabelUserName);
			this.panelHomePageTop.Controls.Add(this.PictureBoxUserProfile);
			this.panelHomePageTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHomePageTop.Location = new System.Drawing.Point(0, 0);
			this.panelHomePageTop.Name = "panelHomePageTop";
			this.panelHomePageTop.Size = new System.Drawing.Size(935, 151);
			this.panelHomePageTop.TabIndex = 16;
			// 
			// labelCityInfo
			// 
			this.labelCityInfo.AutoSize = true;
			this.labelCityInfo.Location = new System.Drawing.Point(308, 62);
			this.labelCityInfo.Name = "labelCityInfo";
			this.labelCityInfo.Size = new System.Drawing.Size(49, 23);
			this.labelCityInfo.TabIndex = 9;
			this.labelCityInfo.Text = "N/A";
			this.labelCityInfo.Visible = false;
			// 
			// labelBirthdayInfo
			// 
			this.labelBirthdayInfo.AutoSize = true;
			this.labelBirthdayInfo.Location = new System.Drawing.Point(308, 90);
			this.labelBirthdayInfo.Name = "labelBirthdayInfo";
			this.labelBirthdayInfo.Size = new System.Drawing.Size(49, 23);
			this.labelBirthdayInfo.TabIndex = 8;
			this.labelBirthdayInfo.Text = "N/A";
			this.labelBirthdayInfo.Visible = false;
			// 
			// labelLastNameInfo
			// 
			this.labelLastNameInfo.AutoSize = true;
			this.labelLastNameInfo.Location = new System.Drawing.Point(308, 34);
			this.labelLastNameInfo.Name = "labelLastNameInfo";
			this.labelLastNameInfo.Size = new System.Drawing.Size(49, 23);
			this.labelLastNameInfo.TabIndex = 7;
			this.labelLastNameInfo.Text = "N/A";
			this.labelLastNameInfo.Visible = false;
			// 
			// labelFirstNameInfo
			// 
			this.labelFirstNameInfo.AutoSize = true;
			this.labelFirstNameInfo.Location = new System.Drawing.Point(308, 11);
			this.labelFirstNameInfo.Name = "labelFirstNameInfo";
			this.labelFirstNameInfo.Size = new System.Drawing.Size(49, 23);
			this.labelFirstNameInfo.TabIndex = 6;
			this.labelFirstNameInfo.Text = "N/A";
			this.labelFirstNameInfo.Visible = false;
			// 
			// labelCity
			// 
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(185, 62);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(52, 23);
			this.labelCity.TabIndex = 5;
			this.labelCity.Text = "City:";
			this.labelCity.Visible = false;
			// 
			// labelBirthDay
			// 
			this.labelBirthDay.AutoSize = true;
			this.labelBirthDay.Location = new System.Drawing.Point(185, 90);
			this.labelBirthDay.Name = "labelBirthDay";
			this.labelBirthDay.Size = new System.Drawing.Size(93, 23);
			this.labelBirthDay.TabIndex = 4;
			this.labelBirthDay.Text = "Birthday:";
			this.labelBirthDay.Visible = false;
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(185, 34);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(117, 23);
			this.labelLastName.TabIndex = 3;
			this.labelLastName.Text = "Last name:";
			this.labelLastName.Visible = false;
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(185, 11);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(113, 23);
			this.labelFirstName.TabIndex = 2;
			this.labelFirstName.Text = "First name:";
			this.labelFirstName.Visible = false;
			// 
			// LabelUserName
			// 
			this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelUserName.Location = new System.Drawing.Point(6, 103);
			this.LabelUserName.Name = "LabelUserName";
			this.LabelUserName.Size = new System.Drawing.Size(107, 21);
			this.LabelUserName.TabIndex = 1;
			// 
			// PictureBoxUserProfile
			// 
			this.PictureBoxUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureBoxUserProfile.Location = new System.Drawing.Point(6, 11);
			this.PictureBoxUserProfile.Name = "PictureBoxUserProfile";
			this.PictureBoxUserProfile.Size = new System.Drawing.Size(107, 95);
			this.PictureBoxUserProfile.TabIndex = 0;
			this.PictureBoxUserProfile.TabStop = false;
			// 
			// backToHomePageFromJobPanelButton
			// 
			this.backToHomePageFromJobPanelButton.Location = new System.Drawing.Point(-1, 0);
			this.backToHomePageFromJobPanelButton.Name = "backToHomePageFromJobPanelButton";
			this.backToHomePageFromJobPanelButton.Size = new System.Drawing.Size(160, 55);
			this.backToHomePageFromJobPanelButton.TabIndex = 2;
			this.backToHomePageFromJobPanelButton.Text = "Back To Home";
			this.backToHomePageFromJobPanelButton.UseVisualStyleBackColor = true;
			this.backToHomePageFromJobPanelButton.Click += new System.EventHandler(this.backToHomePAge);
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
			// panelFaceBookTitle
			// 
			this.panelFaceBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
			this.panelFaceBookTitle.Controls.Add(this.labelAppName);
			this.panelFaceBookTitle.Location = new System.Drawing.Point(0, 0);
			this.panelFaceBookTitle.Name = "panelFaceBookTitle";
			this.panelFaceBookTitle.Size = new System.Drawing.Size(216, 95);
			this.panelFaceBookTitle.TabIndex = 0;
			// 
			// labelAppName
			// 
			this.labelAppName.AutoSize = true;
			this.labelAppName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.labelAppName.Location = new System.Drawing.Point(-1, 33);
			this.labelAppName.Name = "labelAppName";
			this.labelAppName.Size = new System.Drawing.Size(217, 34);
			this.labelAppName.TabIndex = 0;
			this.labelAppName.Text = "Facebook App";
			this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelShadowColorLight
			// 
			this.panelShadowColorLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
			this.panelShadowColorLight.Controls.Add(this.panelShadowColorDark);
			this.panelShadowColorLight.Location = new System.Drawing.Point(214, 0);
			this.panelShadowColorLight.Name = "panelShadowColorLight";
			this.panelShadowColorLight.Size = new System.Drawing.Size(5, 537);
			this.panelShadowColorLight.TabIndex = 1;
			// 
			// panelShadowColorDark
			// 
			this.panelShadowColorDark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
			this.panelShadowColorDark.Location = new System.Drawing.Point(-2, 0);
			this.panelShadowColorDark.Name = "panelShadowColorDark";
			this.panelShadowColorDark.Size = new System.Drawing.Size(5, 537);
			this.panelShadowColorDark.TabIndex = 2;
			// 
			// FacebookView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1158, 536);
			this.Controls.Add(this.panelShadowColorLight);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelMainButtons);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FacebookView";
			this.Text = "Facebook App";
			this.panelMain.ResumeLayout(false);
			this.panelHomePage.ResumeLayout(false);
			this.panelHomePage.PerformLayout();
			this.panelHomePageTop.ResumeLayout(false);
			this.panelHomePageTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).EndInit();
			this.panelMainButtons.ResumeLayout(false);
			this.panelFaceBookTitle.ResumeLayout(false);
			this.panelFaceBookTitle.PerformLayout();
			this.panelShadowColorLight.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelHomePage;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button eventsButton;
		private System.Windows.Forms.Button albumsButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
		private System.Windows.Forms.Panel panelHomePageTop;
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
		private System.Windows.Forms.Button friendsButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
		private System.Windows.Forms.Label labelCityInfo;
		private System.Windows.Forms.Label labelBirthdayInfo;
		private System.Windows.Forms.Label labelLastNameInfo;
		private System.Windows.Forms.Label labelFirstNameInfo;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelBirthDay;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Button findJobAppButton;
		private System.Windows.Forms.Button findAMatchAppButton;
		private System.Windows.Forms.Button loadDetailsAppButton;
		private System.Windows.Forms.Panel panelMainButtons;
		private System.Windows.Forms.Button loginAppButton;
		private System.Windows.Forms.Panel panelFaceBookTitle;
		private System.Windows.Forms.Label labelAppName;
		private System.Windows.Forms.Panel panelShadowColorLight;
		private System.Windows.Forms.Panel panelShadowColorDark;
	}
}


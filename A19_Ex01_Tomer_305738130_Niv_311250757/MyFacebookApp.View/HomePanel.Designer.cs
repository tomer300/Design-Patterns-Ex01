﻿namespace MyFacebookApp.View
{
	partial class HomePanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
			this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePageTop = new System.Windows.Forms.Panel();
			this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanelBorderPosts = new System.Windows.Forms.FlowLayoutPanel();
			this.eventsRoundedButton = new MyFacebookApp.View.RoundedButton();
			this.albumsRoundedButton = new MyFacebookApp.View.RoundedButton();
			this.friendsRoundedButton = new MyFacebookApp.View.RoundedButton();
			this.postsRoundedButton = new MyFacebookApp.View.RoundedButton();
			this.panelUserDetails = new MyFacebookApp.View.UserDetailsPanel();
			this.panelHomePageTop.SuspendLayout();
			this.flowLayoutPanelBorderPosts.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanelFriends
			// 
			this.flowLayoutPanelFriends.AutoScroll = true;
			this.flowLayoutPanelFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.flowLayoutPanelFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanelFriends.Location = new System.Drawing.Point(475, 189);
			this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
			this.flowLayoutPanelFriends.Size = new System.Drawing.Size(458, 140);
			this.flowLayoutPanelFriends.TabIndex = 26;
			// 
			// tableLayoutPanelPosts
			// 
			this.tableLayoutPanelPosts.AutoScroll = true;
			this.tableLayoutPanelPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.tableLayoutPanelPosts.ColumnCount = 1;
			this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanelPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.tableLayoutPanelPosts.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanelPosts.Name = "tableLayoutPanelPosts";
			this.tableLayoutPanelPosts.RowCount = 1;
			this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Size = new System.Drawing.Size(450, 133);
			this.tableLayoutPanelPosts.TabIndex = 31;
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.IntegralHeight = false;
			this.listBoxEvents.ItemHeight = 23;
			this.listBoxEvents.Location = new System.Drawing.Point(475, 383);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(458, 142);
			this.listBoxEvents.TabIndex = 29;
			// 
			// flowLayoutPanelAlbums
			// 
			this.flowLayoutPanelAlbums.AutoScroll = true;
			this.flowLayoutPanelAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.flowLayoutPanelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(6, 383);
			this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
			this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(458, 142);
			this.flowLayoutPanelAlbums.TabIndex = 25;
			// 
			// panelHomePageTop
			// 
			this.panelHomePageTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.panelHomePageTop.Controls.Add(this.checkBoxRememberMe);
			this.panelHomePageTop.Controls.Add(this.panelUserDetails);
			this.panelHomePageTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHomePageTop.Location = new System.Drawing.Point(0, 0);
			this.panelHomePageTop.Name = "panelHomePageTop";
			this.panelHomePageTop.Size = new System.Drawing.Size(936, 133);
			this.panelHomePageTop.TabIndex = 24;
			// 
			// checkBoxRememberMe
			// 
			this.checkBoxRememberMe.AutoSize = true;
			this.checkBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.checkBoxRememberMe.Location = new System.Drawing.Point(615, 16);
			this.checkBoxRememberMe.Name = "checkBoxRememberMe";
			this.checkBoxRememberMe.Size = new System.Drawing.Size(177, 27);
			this.checkBoxRememberMe.TabIndex = 1;
			this.checkBoxRememberMe.Text = "Remember Me";
			this.checkBoxRememberMe.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelBorderPosts
			// 
			this.flowLayoutPanelBorderPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.flowLayoutPanelBorderPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanelBorderPosts.Controls.Add(this.tableLayoutPanelPosts);
			this.flowLayoutPanelBorderPosts.Location = new System.Drawing.Point(6, 189);
			this.flowLayoutPanelBorderPosts.Name = "flowLayoutPanelBorderPosts";
			this.flowLayoutPanelBorderPosts.Size = new System.Drawing.Size(458, 140);
			this.flowLayoutPanelBorderPosts.TabIndex = 27;
			// 
			// eventsRoundedButton
			// 
			this.eventsRoundedButton.BackColor = System.Drawing.Color.Transparent;
			this.eventsRoundedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eventsRoundedButton.BackgroundImage")));
			this.eventsRoundedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.eventsRoundedButton.FlatAppearance.BorderSize = 0;
			this.eventsRoundedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.eventsRoundedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.eventsRoundedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.eventsRoundedButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.eventsRoundedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
			this.eventsRoundedButton.Location = new System.Drawing.Point(479, 336);
			this.eventsRoundedButton.Name = "eventsRoundedButton";
			this.eventsRoundedButton.Size = new System.Drawing.Size(142, 40);
			this.eventsRoundedButton.TabIndex = 36;
			this.eventsRoundedButton.Text = "Events";
			this.eventsRoundedButton.UseVisualStyleBackColor = false;
			this.eventsRoundedButton.Click += new System.EventHandler(this.eventsButton_Click);
			// 
			// albumsRoundedButton
			// 
			this.albumsRoundedButton.BackColor = System.Drawing.Color.Transparent;
			this.albumsRoundedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("albumsRoundedButton.BackgroundImage")));
			this.albumsRoundedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.albumsRoundedButton.FlatAppearance.BorderSize = 0;
			this.albumsRoundedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.albumsRoundedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.albumsRoundedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.albumsRoundedButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.albumsRoundedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
			this.albumsRoundedButton.Location = new System.Drawing.Point(6, 336);
			this.albumsRoundedButton.Name = "albumsRoundedButton";
			this.albumsRoundedButton.Size = new System.Drawing.Size(142, 40);
			this.albumsRoundedButton.TabIndex = 35;
			this.albumsRoundedButton.Text = "Albums";
			this.albumsRoundedButton.UseVisualStyleBackColor = false;
			this.albumsRoundedButton.Click += new System.EventHandler(this.albumsButton_Click);
			// 
			// friendsRoundedButton
			// 
			this.friendsRoundedButton.BackColor = System.Drawing.Color.Transparent;
			this.friendsRoundedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendsRoundedButton.BackgroundImage")));
			this.friendsRoundedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.friendsRoundedButton.FlatAppearance.BorderSize = 0;
			this.friendsRoundedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.friendsRoundedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.friendsRoundedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.friendsRoundedButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.friendsRoundedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
			this.friendsRoundedButton.Location = new System.Drawing.Point(479, 143);
			this.friendsRoundedButton.Name = "friendsRoundedButton";
			this.friendsRoundedButton.Size = new System.Drawing.Size(142, 40);
			this.friendsRoundedButton.TabIndex = 34;
			this.friendsRoundedButton.Text = "Friends";
			this.friendsRoundedButton.UseVisualStyleBackColor = false;
			this.friendsRoundedButton.Click += new System.EventHandler(this.friendsButton_Click);
			// 
			// postsRoundedButton
			// 
			this.postsRoundedButton.BackColor = System.Drawing.Color.Transparent;
			this.postsRoundedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("postsRoundedButton.BackgroundImage")));
			this.postsRoundedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.postsRoundedButton.FlatAppearance.BorderSize = 0;
			this.postsRoundedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.postsRoundedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.postsRoundedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.postsRoundedButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.postsRoundedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
			this.postsRoundedButton.Location = new System.Drawing.Point(6, 143);
			this.postsRoundedButton.Name = "postsRoundedButton";
			this.postsRoundedButton.Size = new System.Drawing.Size(142, 40);
			this.postsRoundedButton.TabIndex = 33;
			this.postsRoundedButton.Text = "Posts";
			this.postsRoundedButton.UseVisualStyleBackColor = false;
			this.postsRoundedButton.Click += new System.EventHandler(this.postsButton_Click);
			// 
			// panelUserDetails
			// 
			this.panelUserDetails.Location = new System.Drawing.Point(0, 0);
			this.panelUserDetails.Name = "panelUserDetails";
			this.panelUserDetails.Size = new System.Drawing.Size(548, 130);
			this.panelUserDetails.TabIndex = 0;
			// 
			// HomePanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.eventsRoundedButton);
			this.Controls.Add(this.albumsRoundedButton);
			this.Controls.Add(this.friendsRoundedButton);
			this.Controls.Add(this.postsRoundedButton);
			this.Controls.Add(this.flowLayoutPanelBorderPosts);
			this.Controls.Add(this.flowLayoutPanelFriends);
			this.Controls.Add(this.listBoxEvents);
			this.Controls.Add(this.flowLayoutPanelAlbums);
			this.Controls.Add(this.panelHomePageTop);
			this.Name = "HomePanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.panelHomePageTop.ResumeLayout(false);
			this.panelHomePageTop.PerformLayout();
			this.flowLayoutPanelBorderPosts.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
		private System.Windows.Forms.Panel panelHomePageTop;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBorderPosts;
		private System.Windows.Forms.CheckBox checkBoxRememberMe;
		private MyFacebookApp.View.UserDetailsPanel panelUserDetails;
		private MyFacebookApp.View.RoundedButton postsRoundedButton;
		private MyFacebookApp.View.RoundedButton friendsRoundedButton;
		private MyFacebookApp.View.RoundedButton albumsRoundedButton;
		private MyFacebookApp.View.RoundedButton eventsRoundedButton;
	}
}

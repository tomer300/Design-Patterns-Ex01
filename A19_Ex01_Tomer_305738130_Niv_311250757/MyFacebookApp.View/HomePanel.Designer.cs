
namespace MyFacebookApp.View
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
			this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePageTop = new System.Windows.Forms.Panel();
			this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
			this.panelUserDetails = new MyFacebookApp.View.UserDetailsPanel();
			this.flowLayoutPanelBorderPosts = new System.Windows.Forms.FlowLayoutPanel();
			this.postsButton = new System.Windows.Forms.Button();
			this.friendsButton = new System.Windows.Forms.Button();
			this.albumsButton = new System.Windows.Forms.Button();
			this.eventsButton = new System.Windows.Forms.Button();
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
			this.checkBoxRememberMe.Location = new System.Drawing.Point(781, 60);
			this.checkBoxRememberMe.Name = "checkBoxRememberMe";
			this.checkBoxRememberMe.Size = new System.Drawing.Size(177, 27);
			this.checkBoxRememberMe.TabIndex = 1;
			this.checkBoxRememberMe.Text = "Remember Me";
			this.checkBoxRememberMe.UseVisualStyleBackColor = true;
			// 
			// panelUserDetails
			// 
			this.panelUserDetails.Location = new System.Drawing.Point(0, 0);
			this.panelUserDetails.Name = "panelUserDetails";
			this.panelUserDetails.Size = new System.Drawing.Size(548, 130);
			this.panelUserDetails.TabIndex = 0;
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
			// postsButton
			// 
			this.postsButton.Location = new System.Drawing.Point(11, 140);
			this.postsButton.Name = "postsButton";
			this.postsButton.Size = new System.Drawing.Size(103, 43);
			this.postsButton.TabIndex = 30;
			this.postsButton.Text = "Posts";
			this.postsButton.UseVisualStyleBackColor = true;
			this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
			// 
			// friendsButton
			// 
			this.friendsButton.Location = new System.Drawing.Point(475, 140);
			this.friendsButton.Name = "friendsButton";
			this.friendsButton.Size = new System.Drawing.Size(103, 43);
			this.friendsButton.TabIndex = 31;
			this.friendsButton.Text = "Friends";
			this.friendsButton.UseVisualStyleBackColor = true;
			this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
			// 
			// albumsButton
			// 
			this.albumsButton.Location = new System.Drawing.Point(11, 335);
			this.albumsButton.Name = "albumsButton";
			this.albumsButton.Size = new System.Drawing.Size(103, 43);
			this.albumsButton.TabIndex = 32;
			this.albumsButton.Text = "Albums";
			this.albumsButton.UseVisualStyleBackColor = true;
			this.albumsButton.Click += new System.EventHandler(this.albumsButton_Click);
			// 
			// eventsButton
			// 
			this.eventsButton.Location = new System.Drawing.Point(475, 334);
			this.eventsButton.Name = "eventsButton";
			this.eventsButton.Size = new System.Drawing.Size(103, 43);
			this.eventsButton.TabIndex = 33;
			this.eventsButton.Text = "Events";
			this.eventsButton.UseVisualStyleBackColor = true;
			this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
			// 
			// HomePanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.eventsButton);
			this.Controls.Add(this.albumsButton);
			this.Controls.Add(this.friendsButton);
			this.Controls.Add(this.postsButton);
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
		private UserDetailsPanel panelUserDetails;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBorderPosts;
		private System.Windows.Forms.CheckBox checkBoxRememberMe;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.Button friendsButton;
		private System.Windows.Forms.Button albumsButton;
		private System.Windows.Forms.Button eventsButton;
	}
}

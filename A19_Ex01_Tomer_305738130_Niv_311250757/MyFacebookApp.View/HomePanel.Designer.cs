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
			this.panelHomePageTop = new System.Windows.Forms.Panel();
			this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
			this.albumsButton = new System.Windows.Forms.Button();
			this.eventsButton = new System.Windows.Forms.Button();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.postsButton = new System.Windows.Forms.Button();
			this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
			this.friendsButton = new System.Windows.Forms.Button();
			this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHomePage = new System.Windows.Forms.Panel();
			this.panelUserDetails = new MyFacebookApp.View.UserDetailsPanel();
			this.panelHomePageTop.SuspendLayout();
			this.panelHomePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHomePageTop
			// 
			this.panelHomePageTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.panelHomePageTop.Controls.Add(this.panelUserDetails);
			this.panelHomePageTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHomePageTop.Location = new System.Drawing.Point(0, 0);
			this.panelHomePageTop.Name = "panelHomePageTop";
			this.panelHomePageTop.Size = new System.Drawing.Size(936, 151);
			this.panelHomePageTop.TabIndex = 16;
			// 
			// flowLayoutPanelAlbums
			// 
			this.flowLayoutPanelAlbums.AutoScroll = true;
			this.flowLayoutPanelAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(6, 380);
			this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
			this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(463, 142);
			this.flowLayoutPanelAlbums.TabIndex = 17;
			// 
			// albumsButton
			// 
			this.albumsButton.AutoSize = true;
			this.albumsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.albumsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.albumsButton.Location = new System.Drawing.Point(6, 342);
			this.albumsButton.Name = "albumsButton";
			this.albumsButton.Size = new System.Drawing.Size(122, 33);
			this.albumsButton.TabIndex = 18;
			this.albumsButton.Text = "Albums";
			this.albumsButton.UseVisualStyleBackColor = true;
			this.albumsButton.Click += new System.EventHandler(this.albumsButton_Click);
			// 
			// eventsButton
			// 
			this.eventsButton.AutoSize = true;
			this.eventsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.eventsButton.Location = new System.Drawing.Point(479, 341);
			this.eventsButton.Name = "eventsButton";
			this.eventsButton.Size = new System.Drawing.Size(122, 33);
			this.eventsButton.TabIndex = 19;
			this.eventsButton.Text = "Events";
			this.eventsButton.UseVisualStyleBackColor = true;
			this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.listBoxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 23;
			this.listBoxEvents.Location = new System.Drawing.Point(475, 380);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(448, 115);
			this.listBoxEvents.TabIndex = 20;
			// 
			// postsButton
			// 
			this.postsButton.AutoSize = true;
			this.postsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.postsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.postsButton.Location = new System.Drawing.Point(6, 157);
			this.postsButton.Name = "postsButton";
			this.postsButton.Size = new System.Drawing.Size(122, 33);
			this.postsButton.TabIndex = 21;
			this.postsButton.Text = "Posts";
			this.postsButton.UseVisualStyleBackColor = true;
			this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
			// 
			// tableLayoutPanelPosts
			// 
			this.tableLayoutPanelPosts.AutoScroll = true;
			this.tableLayoutPanelPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.tableLayoutPanelPosts.ColumnCount = 1;
			this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanelPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.tableLayoutPanelPosts.Location = new System.Drawing.Point(6, 196);
			this.tableLayoutPanelPosts.Name = "tableLayoutPanelPosts";
			this.tableLayoutPanelPosts.RowCount = 1;
			this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelPosts.Size = new System.Drawing.Size(463, 140);
			this.tableLayoutPanelPosts.TabIndex = 22;
			// 
			// friendsButton
			// 
			this.friendsButton.AutoSize = true;
			this.friendsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.friendsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.friendsButton.Location = new System.Drawing.Point(479, 157);
			this.friendsButton.Name = "friendsButton";
			this.friendsButton.Size = new System.Drawing.Size(122, 33);
			this.friendsButton.TabIndex = 23;
			this.friendsButton.Text = "Friends";
			this.friendsButton.UseVisualStyleBackColor = true;
			this.friendsButton.Click += new System.EventHandler(this.friendsButton_Click);
			// 
			// flowLayoutPanelFriends
			// 
			this.flowLayoutPanelFriends.AutoScroll = true;
			this.flowLayoutPanelFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.flowLayoutPanelFriends.Location = new System.Drawing.Point(479, 196);
			this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
			this.flowLayoutPanelFriends.Size = new System.Drawing.Size(444, 142);
			this.flowLayoutPanelFriends.TabIndex = 18;
			// 
			// panelHomePage
			// 
			this.panelHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.panelHomePage.Controls.Add(this.flowLayoutPanelFriends);
			this.panelHomePage.Controls.Add(this.friendsButton);
			this.panelHomePage.Controls.Add(this.tableLayoutPanelPosts);
			this.panelHomePage.Controls.Add(this.postsButton);
			this.panelHomePage.Controls.Add(this.listBoxEvents);
			this.panelHomePage.Controls.Add(this.eventsButton);
			this.panelHomePage.Controls.Add(this.albumsButton);
			this.panelHomePage.Controls.Add(this.flowLayoutPanelAlbums);
			this.panelHomePage.Controls.Add(this.panelHomePageTop);
			this.panelHomePage.Location = new System.Drawing.Point(0, 0);
			this.panelHomePage.Name = "panelHomePage";
			this.panelHomePage.Size = new System.Drawing.Size(936, 533);
			this.panelHomePage.TabIndex = 3;
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
			this.Controls.Add(this.panelHomePage);
			this.Name = "HomePanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.panelHomePageTop.ResumeLayout(false);
			this.panelHomePage.ResumeLayout(false);
			this.panelHomePage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHomePageTop;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
		private System.Windows.Forms.Button albumsButton;
		private System.Windows.Forms.Button eventsButton;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Button postsButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
		private System.Windows.Forms.Button friendsButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
		private System.Windows.Forms.Panel panelHomePage;
		private UserDetailsPanel panelUserDetails;
	}
}

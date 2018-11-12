namespace MyFacebookApp.View
{
	partial class MatchPanel
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
			this.flowLayoutPanelMatchPictures = new System.Windows.Forms.FlowLayoutPanel();
			this.labelBetweenAges = new System.Windows.Forms.Label();
			this.comboBoxAgeRanges = new System.Windows.Forms.ComboBox();
			this.labelInterestedIn = new System.Windows.Forms.Label();
			this.checkBoxBoys = new System.Windows.Forms.CheckBox();
			this.checkBoxGirls = new System.Windows.Forms.CheckBox();
			this.panelUserDetails = new MyFacebookApp.View.UserDetailsPanel();
			this.findMeAMatchButton = new MyFacebookApp.View.RoundedButton();
			this.SuspendLayout();
			// 
			// flowLayoutPanelMatchPictures
			// 
			this.flowLayoutPanelMatchPictures.AutoScroll = true;
			this.flowLayoutPanelMatchPictures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flowLayoutPanelMatchPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.flowLayoutPanelMatchPictures.Location = new System.Drawing.Point(14, 299);
			this.flowLayoutPanelMatchPictures.Name = "flowLayoutPanelMatchPictures";
			this.flowLayoutPanelMatchPictures.Size = new System.Drawing.Size(908, 196);
			this.flowLayoutPanelMatchPictures.TabIndex = 13;
			// 
			// labelBetweenAges
			// 
			this.labelBetweenAges.AutoSize = true;
			this.labelBetweenAges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBetweenAges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.labelBetweenAges.Location = new System.Drawing.Point(71, 165);
			this.labelBetweenAges.Name = "labelBetweenAges";
			this.labelBetweenAges.Size = new System.Drawing.Size(157, 23);
			this.labelBetweenAges.TabIndex = 12;
			this.labelBetweenAges.Text = "Between Ages:";
			// 
			// comboBoxAgeRanges
			// 
			this.comboBoxAgeRanges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxAgeRanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.comboBoxAgeRanges.FormattingEnabled = true;
			this.comboBoxAgeRanges.Items.AddRange(new object[] {
            "18-20",
            "21-25",
            "26-30",
            "31-35",
            "36-40",
            "41-45",
            "46-50",
            "50+"});
			this.comboBoxAgeRanges.Location = new System.Drawing.Point(75, 198);
			this.comboBoxAgeRanges.Name = "comboBoxAgeRanges";
			this.comboBoxAgeRanges.Size = new System.Drawing.Size(208, 31);
			this.comboBoxAgeRanges.TabIndex = 11;
			this.comboBoxAgeRanges.Text = "18-20";
			// 
			// labelInterestedIn
			// 
			this.labelInterestedIn.AutoSize = true;
			this.labelInterestedIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInterestedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.labelInterestedIn.Location = new System.Drawing.Point(71, 62);
			this.labelInterestedIn.Name = "labelInterestedIn";
			this.labelInterestedIn.Size = new System.Drawing.Size(136, 23);
			this.labelInterestedIn.TabIndex = 10;
			this.labelInterestedIn.Text = "Interested In:";
			// 
			// checkBoxBoys
			// 
			this.checkBoxBoys.AutoSize = true;
			this.checkBoxBoys.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxBoys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.checkBoxBoys.Location = new System.Drawing.Point(75, 130);
			this.checkBoxBoys.Name = "checkBoxBoys";
			this.checkBoxBoys.Size = new System.Drawing.Size(75, 27);
			this.checkBoxBoys.TabIndex = 9;
			this.checkBoxBoys.Text = "Boys";
			this.checkBoxBoys.UseVisualStyleBackColor = true;
			// 
			// checkBoxGirls
			// 
			this.checkBoxGirls.AutoSize = true;
			this.checkBoxGirls.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxGirls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.checkBoxGirls.Location = new System.Drawing.Point(75, 97);
			this.checkBoxGirls.Name = "checkBoxGirls";
			this.checkBoxGirls.Size = new System.Drawing.Size(71, 27);
			this.checkBoxGirls.TabIndex = 8;
			this.checkBoxGirls.Text = "Girls";
			this.checkBoxGirls.UseVisualStyleBackColor = true;
			// 
			// panelUserDetails
			// 
			this.panelUserDetails.Location = new System.Drawing.Point(345, 45);
			this.panelUserDetails.Name = "panelUserDetails";
			this.panelUserDetails.Size = new System.Drawing.Size(548, 130);
			this.panelUserDetails.TabIndex = 15;
			this.panelUserDetails.Visible = false;
			// 
			// findMeAMatchButton
			// 
			this.findMeAMatchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findMeAMatchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.findMeAMatchButton.Location = new System.Drawing.Point(90, 235);
			this.findMeAMatchButton.Name = "findMeAMatchButton";
			this.findMeAMatchButton.Size = new System.Drawing.Size(163, 55);
			this.findMeAMatchButton.TabIndex = 14;
			this.findMeAMatchButton.Text = "Find me a match!";
			this.findMeAMatchButton.UseVisualStyleBackColor = true;
			this.findMeAMatchButton.Click += new System.EventHandler(this.findMeAMatchButton_Click);
			// 
			// MatchPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.panelUserDetails);
			this.Controls.Add(this.findMeAMatchButton);
			this.Controls.Add(this.flowLayoutPanelMatchPictures);
			this.Controls.Add(this.labelBetweenAges);
			this.Controls.Add(this.comboBoxAgeRanges);
			this.Controls.Add(this.labelInterestedIn);
			this.Controls.Add(this.checkBoxBoys);
			this.Controls.Add(this.checkBoxGirls);
			this.Name = "MatchPanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserDetailsPanel panelUserDetails;
		private RoundedButton findMeAMatchButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMatchPictures;
		private System.Windows.Forms.Label labelBetweenAges;
		private System.Windows.Forms.ComboBox comboBoxAgeRanges;
		private System.Windows.Forms.Label labelInterestedIn;
		private System.Windows.Forms.CheckBox checkBoxBoys;
		private System.Windows.Forms.CheckBox checkBoxGirls;
	}
}

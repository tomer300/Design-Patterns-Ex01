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
			this.panelMatch = new System.Windows.Forms.Panel();
			this.findMeAMatchButton = new System.Windows.Forms.Button();
			this.flowLayoutPanelGirlsPictures = new System.Windows.Forms.FlowLayoutPanel();
			this.labelBetweenAges = new System.Windows.Forms.Label();
			this.comboBoxAgeRanges = new System.Windows.Forms.ComboBox();
			this.labelInterestedIn = new System.Windows.Forms.Label();
			this.checkBoxBoys = new System.Windows.Forms.CheckBox();
			this.checkBoxGirls = new System.Windows.Forms.CheckBox();
			this.panelUserDetails = new MyFacebookApp.View.UserDetailsPanel();
			this.panelMatch.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMatch
			// 
			this.panelMatch.Controls.Add(this.panelUserDetails);
			this.panelMatch.Controls.Add(this.findMeAMatchButton);
			this.panelMatch.Controls.Add(this.flowLayoutPanelGirlsPictures);
			this.panelMatch.Controls.Add(this.labelBetweenAges);
			this.panelMatch.Controls.Add(this.comboBoxAgeRanges);
			this.panelMatch.Controls.Add(this.labelInterestedIn);
			this.panelMatch.Controls.Add(this.checkBoxBoys);
			this.panelMatch.Controls.Add(this.checkBoxGirls);
			this.panelMatch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.panelMatch.Location = new System.Drawing.Point(1, 0);
			this.panelMatch.Name = "panelMatch";
			this.panelMatch.Size = new System.Drawing.Size(935, 536);
			this.panelMatch.TabIndex = 3;
			// 
			// findMeAMatchButton
			// 
			this.findMeAMatchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.findMeAMatchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.findMeAMatchButton.Location = new System.Drawing.Point(76, 276);
			this.findMeAMatchButton.Name = "findMeAMatchButton";
			this.findMeAMatchButton.Size = new System.Drawing.Size(209, 39);
			this.findMeAMatchButton.TabIndex = 6;
			this.findMeAMatchButton.Text = "Find me a match!";
			this.findMeAMatchButton.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelGirlsPictures
			// 
			this.flowLayoutPanelGirlsPictures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flowLayoutPanelGirlsPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.flowLayoutPanelGirlsPictures.Location = new System.Drawing.Point(15, 327);
			this.flowLayoutPanelGirlsPictures.Name = "flowLayoutPanelGirlsPictures";
			this.flowLayoutPanelGirlsPictures.Size = new System.Drawing.Size(908, 196);
			this.flowLayoutPanelGirlsPictures.TabIndex = 5;
			// 
			// labelBetweenAges
			// 
			this.labelBetweenAges.AutoSize = true;
			this.labelBetweenAges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBetweenAges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.labelBetweenAges.Location = new System.Drawing.Point(72, 194);
			this.labelBetweenAges.Name = "labelBetweenAges";
			this.labelBetweenAges.Size = new System.Drawing.Size(157, 23);
			this.labelBetweenAges.TabIndex = 4;
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
            "25-30",
            "31-35",
            "36-40",
            "41-45",
            "46-50",
            "50+"});
			this.comboBoxAgeRanges.Location = new System.Drawing.Point(76, 229);
			this.comboBoxAgeRanges.Name = "comboBoxAgeRanges";
			this.comboBoxAgeRanges.Size = new System.Drawing.Size(208, 31);
			this.comboBoxAgeRanges.TabIndex = 3;
			// 
			// labelInterestedIn
			// 
			this.labelInterestedIn.AutoSize = true;
			this.labelInterestedIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInterestedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.labelInterestedIn.Location = new System.Drawing.Point(72, 86);
			this.labelInterestedIn.Name = "labelInterestedIn";
			this.labelInterestedIn.Size = new System.Drawing.Size(136, 23);
			this.labelInterestedIn.TabIndex = 2;
			this.labelInterestedIn.Text = "Interested In:";
			// 
			// checkBoxBoys
			// 
			this.checkBoxBoys.AutoSize = true;
			this.checkBoxBoys.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxBoys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.checkBoxBoys.Location = new System.Drawing.Point(76, 154);
			this.checkBoxBoys.Name = "checkBoxBoys";
			this.checkBoxBoys.Size = new System.Drawing.Size(75, 27);
			this.checkBoxBoys.TabIndex = 1;
			this.checkBoxBoys.Text = "Boys";
			this.checkBoxBoys.UseVisualStyleBackColor = true;
			// 
			// checkBoxGirls
			// 
			this.checkBoxGirls.AutoSize = true;
			this.checkBoxGirls.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxGirls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.checkBoxGirls.Location = new System.Drawing.Point(76, 121);
			this.checkBoxGirls.Name = "checkBoxGirls";
			this.checkBoxGirls.Size = new System.Drawing.Size(71, 27);
			this.checkBoxGirls.TabIndex = 0;
			this.checkBoxGirls.Text = "Girls";
			this.checkBoxGirls.UseVisualStyleBackColor = true;
			// 
			// panelUserDetails
			// 
			this.panelUserDetails.Location = new System.Drawing.Point(349, 69);
			this.panelUserDetails.Name = "panelUserDetails";
			this.panelUserDetails.Size = new System.Drawing.Size(548, 130);
			this.panelUserDetails.TabIndex = 7;
			this.panelUserDetails.Visible = false;
			// 
			// MatchPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.panelMatch);
			this.Name = "MatchPanel";
			this.Size = new System.Drawing.Size(936, 537);
			this.panelMatch.ResumeLayout(false);
			this.panelMatch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMatch;
		private System.Windows.Forms.Button findMeAMatchButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGirlsPictures;
		private System.Windows.Forms.Label labelBetweenAges;
		private System.Windows.Forms.ComboBox comboBoxAgeRanges;
		private System.Windows.Forms.Label labelInterestedIn;
		private System.Windows.Forms.CheckBox checkBoxBoys;
		private System.Windows.Forms.CheckBox checkBoxGirls;
		private UserDetailsPanel panelUserDetails;
	}
}

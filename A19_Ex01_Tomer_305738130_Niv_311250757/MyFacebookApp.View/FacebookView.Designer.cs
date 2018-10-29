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
			this.panel1 = new System.Windows.Forms.Panel();
			this.loadDetailsButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.findDateButton = new System.Windows.Forms.Button();
			this.findJobButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.loadDetailsButton);
			this.panel1.Controls.Add(this.loginButton);
			this.panel1.Controls.Add(this.findDateButton);
			this.panel1.Controls.Add(this.findJobButton);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 531);
			this.panel1.TabIndex = 0;
			// 
			// loadDetailsButton
			// 
			this.loadDetailsButton.FlatAppearance.BorderSize = 0;
			this.loadDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadDetailsButton.Location = new System.Drawing.Point(0, 204);
			this.loadDetailsButton.Name = "loadDetailsButton";
			this.loadDetailsButton.Size = new System.Drawing.Size(216, 103);
			this.loadDetailsButton.TabIndex = 6;
			this.loadDetailsButton.Text = "Load App Details";
			this.loadDetailsButton.UseVisualStyleBackColor = true;
			// 
			// loginButton
			// 
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Location = new System.Drawing.Point(0, 95);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(216, 103);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Login With Facebook";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// findDateButton
			// 
			this.findDateButton.FlatAppearance.BorderSize = 0;
			this.findDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findDateButton.Location = new System.Drawing.Point(0, 422);
			this.findDateButton.Name = "findDateButton";
			this.findDateButton.Size = new System.Drawing.Size(216, 103);
			this.findDateButton.TabIndex = 4;
			this.findDateButton.Text = "Find A Date";
			this.findDateButton.UseVisualStyleBackColor = true;
			// 
			// findJobButton
			// 
			this.findJobButton.FlatAppearance.BorderSize = 0;
			this.findJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.findJobButton.Location = new System.Drawing.Point(0, 313);
			this.findJobButton.Name = "findJobButton";
			this.findJobButton.Size = new System.Drawing.Size(216, 103);
			this.findJobButton.TabIndex = 3;
			this.findJobButton.Text = "Find A Job";
			this.findJobButton.UseVisualStyleBackColor = true;
			this.findJobButton.Click += new System.EventHandler(this.findJobButton_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(158)))), ((int)(((byte)(166)))));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(216, 100);
			this.panel3.TabIndex = 0;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.label1.Location = new System.Drawing.Point(-1, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Facebook App";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(216, 392);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(574, 139);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(216, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(574, 151);
			this.panel4.TabIndex = 2;
			// 
			// FacebookView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(790, 531);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FacebookView";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findDateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button loadDetailsButton;
        private System.Windows.Forms.Button findJobButton;
        private System.Windows.Forms.Panel panel4;
    }
}


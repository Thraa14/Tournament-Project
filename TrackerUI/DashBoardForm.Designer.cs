namespace TrackerUI
{
    partial class DashBoardForm
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
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.TournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadDashboardLabel = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DashboardLabel.Location = new System.Drawing.Point(39, 35);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(378, 40);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoadTournamentButton.Location = new System.Drawing.Point(51, 217);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(252, 44);
            this.LoadTournamentButton.TabIndex = 1;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = false;
            this.LoadTournamentButton.Click += new System.EventHandler(this.LoadTournamentButton_Click);
            // 
            // TournamentDropDown
            // 
            this.TournamentDropDown.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDropDown.FormattingEnabled = true;
            this.TournamentDropDown.Location = new System.Drawing.Point(12, 162);
            this.TournamentDropDown.Name = "TournamentDropDown";
            this.TournamentDropDown.Size = new System.Drawing.Size(327, 31);
            this.TournamentDropDown.TabIndex = 2;
            this.TournamentDropDown.SelectedIndexChanged += new System.EventHandler(this.TournamentDropDown_SelectedIndexChanged);
            // 
            // LoadDashboardLabel
            // 
            this.LoadDashboardLabel.AutoSize = true;
            this.LoadDashboardLabel.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadDashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadDashboardLabel.Location = new System.Drawing.Point(12, 108);
            this.LoadDashboardLabel.Name = "LoadDashboardLabel";
            this.LoadDashboardLabel.Size = new System.Drawing.Size(327, 33);
            this.LoadDashboardLabel.TabIndex = 3;
            this.LoadDashboardLabel.Text = "Load Existing Tournament";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTournamentButton.Location = new System.Drawing.Point(39, 393);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(368, 44);
            this.CreateTournamentButton.TabIndex = 4;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(450, 468);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadDashboardLabel);
            this.Controls.Add(this.TournamentDropDown);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.DashboardLabel);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DashboardLabel;
        private Button LoadTournamentButton;
        private ComboBox TournamentDropDown;
        private Label LoadDashboardLabel;
        private Button CreateTournamentButton;
    }
}
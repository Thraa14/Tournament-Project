namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.FeeTextBox = new System.Windows.Forms.TextBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.CreateNewTeamlinkLabel = new System.Windows.Forms.LinkLabel();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.TeamsListBox = new System.Windows.Forms.ListBox();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.RemoveTeamButton = new System.Windows.Forms.Button();
            this.RemovePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Sitka Text", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(289, 42);
            this.CreateTournamentLabel.TabIndex = 0;
            this.CreateTournamentLabel.Text = "Create Tournament";
            this.CreateTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentNameTextBox
            // 
            this.TournamentNameTextBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameTextBox.Location = new System.Drawing.Point(30, 111);
            this.TournamentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TournamentNameTextBox.Name = "TournamentNameTextBox";
            this.TournamentNameTextBox.Size = new System.Drawing.Size(235, 28);
            this.TournamentNameTextBox.TabIndex = 1;
            this.TournamentNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddTeamButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTeamButton.Location = new System.Drawing.Point(72, 307);
            this.AddTeamButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(145, 40);
            this.AddTeamButton.TabIndex = 2;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = false;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TournamentNameLabel.Location = new System.Drawing.Point(30, 66);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(197, 30);
            this.TournamentNameLabel.TabIndex = 3;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EntryFeeLabel.Location = new System.Drawing.Point(27, 163);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(107, 30);
            this.EntryFeeLabel.TabIndex = 4;
            this.EntryFeeLabel.Text = "Entry Fee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.EntryFeeLabel_Click);
            // 
            // FeeTextBox
            // 
            this.FeeTextBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeeTextBox.Location = new System.Drawing.Point(170, 166);
            this.FeeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FeeTextBox.Name = "FeeTextBox";
            this.FeeTextBox.Size = new System.Drawing.Size(95, 28);
            this.FeeTextBox.TabIndex = 5;
            this.FeeTextBox.TextChanged += new System.EventHandler(this.FeeTextBox_TextChanged);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectTeamLabel.Location = new System.Drawing.Point(27, 216);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(131, 30);
            this.SelectTeamLabel.TabIndex = 6;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.SelectTeamLabel_Click);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(28, 268);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(235, 31);
            this.SelectTeamDropDown.TabIndex = 7;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.Location = new System.Drawing.Point(72, 357);
            this.CreatePrizeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(145, 37);
            this.CreatePrizeButton.TabIndex = 8;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = false;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreateNewTeamlinkLabel
            // 
            this.CreateNewTeamlinkLabel.ActiveLinkColor = System.Drawing.Color.Green;
            this.CreateNewTeamlinkLabel.AutoSize = true;
            this.CreateNewTeamlinkLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateNewTeamlinkLabel.Location = new System.Drawing.Point(170, 223);
            this.CreateNewTeamlinkLabel.Name = "CreateNewTeamlinkLabel";
            this.CreateNewTeamlinkLabel.Size = new System.Drawing.Size(96, 23);
            this.CreateNewTeamlinkLabel.TabIndex = 9;
            this.CreateNewTeamlinkLabel.TabStop = true;
            this.CreateNewTeamlinkLabel.Text = "Create New";
            this.CreateNewTeamlinkLabel.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.CreateNewTeamlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamlinkLabel_LinkClicked);
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrizesLabel.Location = new System.Drawing.Point(358, 223);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(73, 30);
            this.PrizesLabel.TabIndex = 10;
            this.PrizesLabel.Text = "Prizes";
            this.PrizesLabel.Click += new System.EventHandler(this.PrizesLabel_Click);
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TeamLabel.Location = new System.Drawing.Point(358, 66);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(170, 30);
            this.TeamLabel.TabIndex = 11;
            this.TeamLabel.Text = "Teams / Players";
            // 
            // TeamsListBox
            // 
            this.TeamsListBox.FormattingEnabled = true;
            this.TeamsListBox.ItemHeight = 23;
            this.TeamsListBox.Location = new System.Drawing.Point(358, 104);
            this.TeamsListBox.Name = "TeamsListBox";
            this.TeamsListBox.Size = new System.Drawing.Size(238, 96);
            this.TeamsListBox.TabIndex = 12;
            this.TeamsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 23;
            this.PrizesListBox.Location = new System.Drawing.Point(358, 268);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(238, 96);
            this.PrizesListBox.TabIndex = 13;
            this.PrizesListBox.SelectedIndexChanged += new System.EventHandler(this.PrizesListBox_SelectedIndexChanged);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Sitka Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.Location = new System.Drawing.Point(199, 404);
            this.CreateTournamentButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(345, 48);
            this.CreateTournamentButton.TabIndex = 14;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // RemoveTeamButton
            // 
            this.RemoveTeamButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveTeamButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveTeamButton.Location = new System.Drawing.Point(602, 104);
            this.RemoveTeamButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemoveTeamButton.Name = "RemoveTeamButton";
            this.RemoveTeamButton.Size = new System.Drawing.Size(91, 50);
            this.RemoveTeamButton.TabIndex = 15;
            this.RemoveTeamButton.Text = "Remove Selected";
            this.RemoveTeamButton.UseVisualStyleBackColor = false;
            this.RemoveTeamButton.Click += new System.EventHandler(this.RemoveTeamButton_Click);
            // 
            // RemovePrizeButton
            // 
            this.RemovePrizeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemovePrizeButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemovePrizeButton.Location = new System.Drawing.Point(602, 268);
            this.RemovePrizeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemovePrizeButton.Name = "RemovePrizeButton";
            this.RemovePrizeButton.Size = new System.Drawing.Size(91, 50);
            this.RemovePrizeButton.TabIndex = 16;
            this.RemovePrizeButton.Text = "Remove Selected";
            this.RemovePrizeButton.UseVisualStyleBackColor = false;
            this.RemovePrizeButton.Click += new System.EventHandler(this.DeletePrizeButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(705, 493);
            this.Controls.Add(this.RemovePrizeButton);
            this.Controls.Add(this.RemoveTeamButton);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.TeamsListBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.CreateNewTeamlinkLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.FeeTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.TournamentNameTextBox);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament Form";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateTournamentLabel;
        private TextBox TournamentNameTextBox;
        private Button AddTeamButton;
        private Label TournamentNameLabel;
        private Label EntryFeeLabel;
        private TextBox FeeTextBox;
        private Label SelectTeamLabel;
        private ComboBox SelectTeamDropDown;
        private Button CreatePrizeButton;
        private LinkLabel CreateNewTeamlinkLabel;
        private Label PrizesLabel;
        private Label TeamLabel;
        private ListBox TeamsListBox;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
        private Button RemoveTeamButton;
        private Button RemovePrizeButton;
    }
}
namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tournament = new System.Windows.Forms.Label();
            this.NameOFTournament = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.Team1Label = new System.Windows.Forms.Label();
            this.Team2Label = new System.Windows.Forms.Label();
            this.Score1Label = new System.Windows.Forms.Label();
            this.Score2Label = new System.Windows.Forms.Label();
            this.VS = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.ScoreTeam2Value = new System.Windows.Forms.TextBox();
            this.ScoreTeam1Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tournament
            // 
            this.Tournament.AutoSize = true;
            this.Tournament.Location = new System.Drawing.Point(2, 28);
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(199, 39);
            this.Tournament.TabIndex = 0;
            this.Tournament.Text = "Tournament :";
            this.Tournament.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NameOFTournament
            // 
            this.NameOFTournament.AutoSize = true;
            this.NameOFTournament.Location = new System.Drawing.Point(198, 28);
            this.NameOFTournament.Name = "NameOFTournament";
            this.NameOFTournament.Size = new System.Drawing.Size(117, 39);
            this.NameOFTournament.TabIndex = 1;
            this.NameOFTournament.Text = "<None>";
            this.NameOFTournament.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Simple Indust Outline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.Location = new System.Drawing.Point(64, 90);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(77, 29);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // Team1Label
            // 
            this.Team1Label.AutoSize = true;
            this.Team1Label.Font = new System.Drawing.Font("Simple Indust Outline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team1Label.Location = new System.Drawing.Point(304, 170);
            this.Team1Label.Name = "Team1Label";
            this.Team1Label.Size = new System.Drawing.Size(91, 35);
            this.Team1Label.TabIndex = 3;
            this.Team1Label.Text = "Team I";
            this.Team1Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Team2Label
            // 
            this.Team2Label.AutoSize = true;
            this.Team2Label.Font = new System.Drawing.Font("Simple Indust Outline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team2Label.Location = new System.Drawing.Point(298, 350);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(97, 35);
            this.Team2Label.TabIndex = 4;
            this.Team2Label.Text = "Team II";
            this.Team2Label.Click += new System.EventHandler(this.Team2_Click);
            // 
            // Score1Label
            // 
            this.Score1Label.AutoSize = true;
            this.Score1Label.Font = new System.Drawing.Font("Simple Indust Outline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score1Label.Location = new System.Drawing.Point(304, 216);
            this.Score1Label.Name = "Score1Label";
            this.Score1Label.Size = new System.Drawing.Size(70, 29);
            this.Score1Label.TabIndex = 5;
            this.Score1Label.Text = "Score";
            this.Score1Label.Click += new System.EventHandler(this.Score1_Click);
            // 
            // Score2Label
            // 
            this.Score2Label.AutoSize = true;
            this.Score2Label.Font = new System.Drawing.Font("Simple Indust Outline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score2Label.Location = new System.Drawing.Point(304, 388);
            this.Score2Label.Name = "Score2Label";
            this.Score2Label.Size = new System.Drawing.Size(70, 29);
            this.Score2Label.TabIndex = 6;
            this.Score2Label.Text = "Score";
            this.Score2Label.UseWaitCursor = true;
            this.Score2Label.Click += new System.EventHandler(this.label6_Click);
            // 
            // VS
            // 
            this.VS.AutoSize = true;
            this.VS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.VS.Font = new System.Drawing.Font("Simple Indust Outline", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.VS.Location = new System.Drawing.Point(361, 289);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(87, 29);
            this.VS.TabIndex = 7;
            this.VS.Text = "-- VS --";
            this.VS.Click += new System.EventHandler(this.label7_Click);
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("Simple Indust Outline", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ScoreButton.Location = new System.Drawing.Point(487, 278);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(99, 46);
            this.ScoreButton.TabIndex = 8;
            this.ScoreButton.Text = "SCORE";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoundDropdown.Font = new System.Drawing.Font("Simple Indust Outline", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.ItemHeight = 24;
            this.RoundDropdown.Location = new System.Drawing.Point(145, 87);
            this.RoundDropdown.Margin = new System.Windows.Forms.Padding(1);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(125, 32);
            this.RoundDropdown.TabIndex = 9;
            this.RoundDropdown.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // UnplayedCheckBox
            // 
            this.UnplayedCheckBox.AutoSize = true;
            this.UnplayedCheckBox.Font = new System.Drawing.Font("Simple Indust Outline", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UnplayedCheckBox.Location = new System.Drawing.Point(91, 123);
            this.UnplayedCheckBox.Name = "UnplayedCheckBox";
            this.UnplayedCheckBox.Size = new System.Drawing.Size(123, 25);
            this.UnplayedCheckBox.TabIndex = 10;
            this.UnplayedCheckBox.Text = "Unplayed Only";
            this.UnplayedCheckBox.UseVisualStyleBackColor = true;
            this.UnplayedCheckBox.CheckedChanged += new System.EventHandler(this.UnplayedCheckBox_CheckedChanged);
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.Font = new System.Drawing.Font("Simple Indust Outline", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 35;
            this.MatchupListBox.Location = new System.Drawing.Point(40, 190);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(230, 212);
            this.MatchupListBox.TabIndex = 11;
            this.MatchupListBox.SelectedIndexChanged += new System.EventHandler(this.MatchupListBox_SelectedIndexChanged);
            // 
            // ScoreTeam2Value
            // 
            this.ScoreTeam2Value.Font = new System.Drawing.Font("Simple Indust Outline", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreTeam2Value.Location = new System.Drawing.Point(380, 388);
            this.ScoreTeam2Value.Name = "ScoreTeam2Value";
            this.ScoreTeam2Value.Size = new System.Drawing.Size(100, 28);
            this.ScoreTeam2Value.TabIndex = 12;
            this.ScoreTeam2Value.TextChanged += new System.EventHandler(this.TextBoxScoreTeam2_TextChanged);
            // 
            // ScoreTeam1Value
            // 
            this.ScoreTeam1Value.Font = new System.Drawing.Font("Simple Indust Outline", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreTeam1Value.Location = new System.Drawing.Point(380, 216);
            this.ScoreTeam1Value.Name = "ScoreTeam1Value";
            this.ScoreTeam1Value.Size = new System.Drawing.Size(100, 28);
            this.ScoreTeam1Value.TabIndex = 13;
            this.ScoreTeam1Value.TextChanged += new System.EventHandler(this.TextBoxScoreTeam1_TextChanged);
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(610, 487);
            this.Controls.Add(this.ScoreTeam1Value);
            this.Controls.Add(this.ScoreTeam2Value);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedCheckBox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VS);
            this.Controls.Add(this.Score2Label);
            this.Controls.Add(this.Score1Label);
            this.Controls.Add(this.Team2Label);
            this.Controls.Add(this.Team1Label);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.NameOFTournament);
            this.Controls.Add(this.Tournament);
            this.Font = new System.Drawing.Font("Simple Indust Outline", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tournament;
        private Label NameOFTournament;
        private Label RoundLabel;
        private Label Team1Label;
        private Label Team2Label;
        private Label Score1Label;
        private Label Score2Label;
        private Label VS;
        private Button ScoreButton;
        private ComboBox RoundDropdown;
        private CheckBox UnplayedCheckBox;
        private ListBox MatchupListBox;
        private TextBox ScoreTeam2Value;
        private TextBox ScoreTeam1Value;
    }
}
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CellphoneTextBox = new System.Windows.Forms.TextBox();
            this.TournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveSelectedTeamButton = new System.Windows.Forms.Button();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AccessibleName = "CreateTeamLabel";
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.Location = new System.Drawing.Point(6, 0);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(182, 39);
            this.CreateTeamLabel.TabIndex = 0;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(12, 81);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(249, 24);
            this.TeamNameTextBox.TabIndex = 1;
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(12, 146);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(249, 27);
            this.SelectTeamDropDown.TabIndex = 2;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamDropDown_SelectedIndexChanged);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddMemberButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMemberButton.Location = new System.Drawing.Point(67, 179);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(121, 39);
            this.AddMemberButton.TabIndex = 3;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = false;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AccessibleName = "TeamNameLabel";
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.Location = new System.Drawing.Point(12, 48);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(129, 30);
            this.TeamNameLabel.TabIndex = 4;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TeamNameLabel_Click);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AccessibleName = "SelectMemberLabel";
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.Location = new System.Drawing.Point(12, 119);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(176, 24);
            this.SelectTeamLabel.TabIndex = 5;
            this.SelectTeamLabel.Text = "Select Team Member";
            this.SelectTeamLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AccessibleName = "SelectMemberLabel";
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(0, 29);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(96, 24);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First name";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AccessibleName = "SelectMemberLabel";
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondNameLabel.Location = new System.Drawing.Point(0, 67);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(114, 24);
            this.SecondNameLabel.TabIndex = 8;
            this.SecondNameLabel.Text = "Second name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AccessibleName = "SelectMemberLabel";
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(0, 103);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 24);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AccessibleName = "SelectMemberLabel";
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Sitka Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellphoneLabel.Location = new System.Drawing.Point(0, 137);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(88, 24);
            this.CellphoneLabel.TabIndex = 10;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(117, 29);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(132, 31);
            this.FirstNameTextBox.TabIndex = 11;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(117, 67);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(132, 31);
            this.SecondNameTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(117, 103);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(132, 31);
            this.EmailTextBox.TabIndex = 13;
            // 
            // CellphoneTextBox
            // 
            this.CellphoneTextBox.Location = new System.Drawing.Point(117, 137);
            this.CellphoneTextBox.Name = "CellphoneTextBox";
            this.CellphoneTextBox.Size = new System.Drawing.Size(132, 31);
            this.CellphoneTextBox.TabIndex = 14;
            // 
            // TournamentPlayerListBox
            // 
            this.TournamentPlayerListBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentPlayerListBox.FormattingEnabled = true;
            this.TournamentPlayerListBox.ItemHeight = 23;
            this.TournamentPlayerListBox.Location = new System.Drawing.Point(332, 60);
            this.TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            this.TournamentPlayerListBox.Size = new System.Drawing.Size(262, 349);
            this.TournamentPlayerListBox.TabIndex = 15;
            this.TournamentPlayerListBox.SelectedIndexChanged += new System.EventHandler(this.TournamentPlayerListBox_SelectedIndexChanged);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateTeamButton.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamButton.Location = new System.Drawing.Point(202, 426);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(228, 40);
            this.CreateTeamButton.TabIndex = 16;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = false;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.SecondNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.CellphoneTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AddNewMemberGroupBox.Controls.Add(this.SecondNameTextBox);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(12, 224);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(314, 185);
            this.AddNewMemberGroupBox.TabIndex = 17;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // RemoveSelectedTeamButton
            // 
            this.RemoveSelectedTeamButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RemoveSelectedTeamButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveSelectedTeamButton.Location = new System.Drawing.Point(600, 206);
            this.RemoveSelectedTeamButton.Name = "RemoveSelectedTeamButton";
            this.RemoveSelectedTeamButton.Size = new System.Drawing.Size(96, 60);
            this.RemoveSelectedTeamButton.TabIndex = 18;
            this.RemoveSelectedTeamButton.Text = "Remove Selected";
            this.RemoveSelectedTeamButton.UseMnemonic = false;
            this.RemoveSelectedTeamButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedTeamButton.Click += new System.EventHandler(this.RemoveSelectedButton);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateMemberButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.Location = new System.Drawing.Point(52, 398);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(144, 31);
            this.CreateMemberButton.TabIndex = 19;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = false;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(718, 465);
            this.Controls.Add(this.CreateMemberButton);
            this.Controls.Add(this.RemoveSelectedTeamButton);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.TournamentPlayerListBox);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateTeamLabel;
        private TextBox TeamNameTextBox;
        private ComboBox SelectTeamDropDown;
        private Button AddMemberButton;
        private Label TeamNameLabel;
        private Label SelectTeamLabel;
        private Label FirstNameLabel;
        private Label SecondNameLabel;
        private Label EmailLabel;
        private Label CellphoneLabel;
        private TextBox FirstNameTextBox;
        private TextBox SecondNameTextBox;
        private TextBox EmailTextBox;
        private TextBox CellphoneTextBox;
        private ListBox TournamentPlayerListBox;
        private Button CreateTeamButton;
        private GroupBox AddNewMemberGroupBox;
        private Button RemoveSelectedTeamButton;
        private Button CreateMemberButton;
    }
}
namespace TrackerUI
{
    partial class CreatePrize
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
            this.CreatePrizeLabel = new System.Windows.Forms.Label();
            this.placeNumberTextBox = new System.Windows.Forms.TextBox();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.PlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.ORLabel = new System.Windows.Forms.Label();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.PrizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AutoSize = true;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeLabel.Location = new System.Drawing.Point(148, 9);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(210, 47);
            this.CreatePrizeLabel.TabIndex = 0;
            this.CreatePrizeLabel.Text = "Create Prize";
            this.CreatePrizeLabel.Click += new System.EventHandler(this.CreatePrizeLabel_Click);
            // 
            // placeNumberTextBox
            // 
            this.placeNumberTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberTextBox.Location = new System.Drawing.Point(245, 85);
            this.placeNumberTextBox.Name = "placeNumberTextBox";
            this.placeNumberTextBox.Size = new System.Drawing.Size(203, 27);
            this.placeNumberTextBox.TabIndex = 1;
            this.placeNumberTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreatePrizeButton.Location = new System.Drawing.Point(114, 375);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(244, 53);
            this.CreatePrizeButton.TabIndex = 2;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = false;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeClickButton);
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(44, 80);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(164, 32);
            this.PlaceNumberLabel.TabIndex = 7;
            this.PlaceNumberLabel.Text = "Place Number";
            this.PlaceNumberLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizeAmountLabel.Location = new System.Drawing.Point(44, 176);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(158, 32);
            this.PrizeAmountLabel.TabIndex = 8;
            this.PrizeAmountLabel.Text = "Prize Amount";
            this.PrizeAmountLabel.Click += new System.EventHandler(this.PrizeAmountLabel_Click);
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlaceNameLabel.Location = new System.Drawing.Point(44, 126);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(140, 32);
            this.PlaceNameLabel.TabIndex = 9;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountTextBox
            // 
            this.PrizeAmountTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountTextBox.Location = new System.Drawing.Point(245, 181);
            this.PrizeAmountTextBox.Name = "PrizeAmountTextBox";
            this.PrizeAmountTextBox.Size = new System.Drawing.Size(203, 27);
            this.PrizeAmountTextBox.TabIndex = 10;
            this.PrizeAmountTextBox.Text = "0";
            // 
            // PlaceNameTextBox
            // 
            this.PlaceNameTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameTextBox.Location = new System.Drawing.Point(245, 131);
            this.PlaceNameTextBox.Name = "PlaceNameTextBox";
            this.PlaceNameTextBox.Size = new System.Drawing.Size(203, 27);
            this.PlaceNameTextBox.TabIndex = 11;
            this.PlaceNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ORLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ORLabel.Location = new System.Drawing.Point(176, 238);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(100, 32);
            this.ORLabel.TabIndex = 12;
            this.ORLabel.Text = "-- OR --";
            this.ORLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizePercentageLabel.Location = new System.Drawing.Point(44, 297);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(191, 32);
            this.PrizePercentageLabel.TabIndex = 13;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // PrizePercentageTextBox
            // 
            this.PrizePercentageTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageTextBox.Location = new System.Drawing.Point(245, 302);
            this.PrizePercentageTextBox.Name = "PrizePercentageTextBox";
            this.PrizePercentageTextBox.Size = new System.Drawing.Size(203, 27);
            this.PrizePercentageTextBox.TabIndex = 14;
            this.PrizePercentageTextBox.Text = "0";
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(536, 490);
            this.Controls.Add(this.PrizePercentageTextBox);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.PlaceNameTextBox);
            this.Controls.Add(this.PrizeAmountTextBox);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.placeNumberTextBox);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreatePrize";
            this.Text = "CreatePrize";
            this.Load += new System.EventHandler(this.CreatePrize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreatePrizeLabel;
        private TextBox placeNumberTextBox;
        private Button CreatePrizeButton;
        private Label PlaceNumberLabel;
        private Label PrizeAmountLabel;
        private Label PlaceNameLabel;
        private TextBox PrizeAmountTextBox;
        private TextBox PlaceNameTextBox;
        private Label ORLabel;
        private Label PrizePercentageLabel;
        private TextBox PrizePercentageTextBox;
    }
}
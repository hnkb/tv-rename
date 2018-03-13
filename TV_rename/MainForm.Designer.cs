namespace TV_rename
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeasonNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.UsRadio = new System.Windows.Forms.RadioButton();
            this.UkRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RootTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.WikiButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EpisodeNamesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SeasonNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series &name:";
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(89, 12);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.Size = new System.Drawing.Size(162, 22);
            this.SeriesTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Season:";
            // 
            // SeasonNumeric
            // 
            this.SeasonNumeric.Location = new System.Drawing.Point(324, 12);
            this.SeasonNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SeasonNumeric.Name = "SeasonNumeric";
            this.SeasonNumeric.Size = new System.Drawing.Size(48, 22);
            this.SeasonNumeric.TabIndex = 3;
            this.SeasonNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naming:";
            // 
            // UsRadio
            // 
            this.UsRadio.AutoSize = true;
            this.UsRadio.Checked = true;
            this.UsRadio.Location = new System.Drawing.Point(89, 40);
            this.UsRadio.Name = "UsRadio";
            this.UsRadio.Size = new System.Drawing.Size(84, 17);
            this.UsRadio.TabIndex = 5;
            this.UsRadio.TabStop = true;
            this.UsRadio.Text = "&US (season)";
            this.UsRadio.UseVisualStyleBackColor = true;
            // 
            // UkRadio
            // 
            this.UkRadio.AutoSize = true;
            this.UkRadio.Location = new System.Drawing.Point(179, 42);
            this.UkRadio.Name = "UkRadio";
            this.UkRadio.Size = new System.Drawing.Size(77, 17);
            this.UkRadio.TabIndex = 6;
            this.UkRadio.Text = "U&K (series)";
            this.UkRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Folder &root:";
            // 
            // RootTextBox
            // 
            this.RootTextBox.Location = new System.Drawing.Point(89, 65);
            this.RootTextBox.Name = "RootTextBox";
            this.RootTextBox.Size = new System.Drawing.Size(202, 22);
            this.RootTextBox.TabIndex = 8;
            this.RootTextBox.Text = "E:\\Collections\\TV";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(297, 63);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 9;
            this.BrowseButton.Text = "&Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Episode names:";
            // 
            // WikiButton
            // 
            this.WikiButton.Location = new System.Drawing.Point(297, 127);
            this.WikiButton.Name = "WikiButton";
            this.WikiButton.Size = new System.Drawing.Size(75, 44);
            this.WikiButton.TabIndex = 12;
            this.WikiButton.Text = "From &Wikipedia";
            this.WikiButton.UseVisualStyleBackColor = true;
            this.WikiButton.Click += new System.EventHandler(this.WikiButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(156, 298);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 43);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "S&tart";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EpisodeNamesTextBox
            // 
            this.EpisodeNamesTextBox.Location = new System.Drawing.Point(12, 127);
            this.EpisodeNamesTextBox.Multiline = true;
            this.EpisodeNamesTextBox.Name = "EpisodeNamesTextBox";
            this.EpisodeNamesTextBox.Size = new System.Drawing.Size(279, 165);
            this.EpisodeNamesTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quotes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Quotes 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EpisodeNamesTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WikiButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.RootTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UkRadio);
            this.Controls.Add(this.UsRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SeasonNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeriesTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TV rename";
            ((System.ComponentModel.ISupportInitialize)(this.SeasonNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SeasonNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton UsRadio;
        private System.Windows.Forms.RadioButton UkRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RootTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WikiButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox EpisodeNamesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


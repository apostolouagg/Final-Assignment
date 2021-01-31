
namespace ergasia1
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerWelcome = new System.Windows.Forms.Timer(this.components);
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.buttonShowAttemps = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1Settings = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.LightGray;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Enabled = false;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(359, 288);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(119, 38);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(228, 17);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(370, 92);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "WELCOME";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(713, 431);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 38);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerWelcome
            // 
            this.timerWelcome.Interval = 500;
            this.timerWelcome.Tick += new System.EventHandler(this.timerWelcome_Tick);
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Controls.Add(this.textBoxName);
            this.panelWelcome.Controls.Add(this.pictureBoxSettings);
            this.panelWelcome.Controls.Add(this.buttonShowAttemps);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Controls.Add(this.buttonPlay);
            this.panelWelcome.Location = new System.Drawing.Point(5, 12);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(627, 468);
            this.panelWelcome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(292, 194);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 26);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::ergasia1.Properties.Resources.Settings_icon;
            this.pictureBoxSettings.Location = new System.Drawing.Point(0, 399);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(69, 69);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettings.TabIndex = 3;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // buttonShowAttemps
            // 
            this.buttonShowAttemps.BackColor = System.Drawing.Color.LightGray;
            this.buttonShowAttemps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAttemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAttemps.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAttemps.Location = new System.Drawing.Point(352, 428);
            this.buttonShowAttemps.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAttemps.Name = "buttonShowAttemps";
            this.buttonShowAttemps.Size = new System.Drawing.Size(137, 29);
            this.buttonShowAttemps.TabIndex = 7;
            this.buttonShowAttemps.Text = "Show Top 10 Attemps";
            this.buttonShowAttemps.UseVisualStyleBackColor = false;
            this.buttonShowAttemps.Click += new System.EventHandler(this.buttonShowLeaderboard_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightGray;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(713, 431);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 38);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.BackColor = System.Drawing.Color.LightGray;
            this.buttonOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFolder.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(22, 76);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(142, 34);
            this.buttonOpenFolder.TabIndex = 5;
            this.buttonOpenFolder.Text = "Select Pictures\' Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = false;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // label1Settings
            // 
            this.label1Settings.AutoSize = true;
            this.label1Settings.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Settings.Location = new System.Drawing.Point(8, 11);
            this.label1Settings.Name = "label1Settings";
            this.label1Settings.Size = new System.Drawing.Size(175, 40);
            this.label1Settings.TabIndex = 6;
            this.label1Settings.Text = "SETTINGS";
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.buttonOpenFolder);
            this.panelSettings.Controls.Add(this.label1Settings);
            this.panelSettings.Location = new System.Drawing.Point(632, 72);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(200, 284);
            this.panelSettings.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "*12 random pictuers will be selected\r\n from the given folder.";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerWelcome;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1Settings;
        private System.Windows.Forms.Button buttonShowAttemps;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


﻿
namespace ergasia1
{
    partial class TopPlayers
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
            this.labelLeaderboard = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1ShowTime = new System.Windows.Forms.Label();
            this.label2ShowAttemp = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLeaderboard
            // 
            this.labelLeaderboard.AutoSize = true;
            this.labelLeaderboard.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeaderboard.Location = new System.Drawing.Point(86, 9);
            this.labelLeaderboard.Name = "labelLeaderboard";
            this.labelLeaderboard.Size = new System.Drawing.Size(260, 38);
            this.labelLeaderboard.TabIndex = 0;
            this.labelLeaderboard.Text = "TOP 10 ATTEMPS";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 347);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(231, 90);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(160, 322);
            this.listBox2.TabIndex = 2;
            // 
            // label1ShowTime
            // 
            this.label1ShowTime.AutoSize = true;
            this.label1ShowTime.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ShowTime.Location = new System.Drawing.Point(330, 57);
            this.label1ShowTime.Name = "label1ShowTime";
            this.label1ShowTime.Size = new System.Drawing.Size(44, 21);
            this.label1ShowTime.TabIndex = 3;
            this.label1ShowTime.Text = "Time";
            // 
            // label2ShowAttemp
            // 
            this.label2ShowAttemp.AutoSize = true;
            this.label2ShowAttemp.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2ShowAttemp.Location = new System.Drawing.Point(233, 57);
            this.label2ShowAttemp.Name = "label2ShowAttemp";
            this.label2ShowAttemp.Size = new System.Drawing.Size(63, 21);
            this.label2ShowAttemp.TabIndex = 4;
            this.label2ShowAttemp.Text = "Attemp";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(320, 423);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(85, 23);
            this.buttonBackToMenu.TabIndex = 5;
            this.buttonBackToMenu.Text = "Back to Menu";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // TopPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(417, 454);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.label2ShowAttemp);
            this.Controls.Add(this.label1ShowTime);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TopPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopPlayers";
            this.Load += new System.EventHandler(this.TopPlayers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeaderboard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1ShowTime;
        private System.Windows.Forms.Label label2ShowAttemp;
        private System.Windows.Forms.Button buttonBackToMenu;
    }
}
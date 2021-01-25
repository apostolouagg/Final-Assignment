
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
            this.SuspendLayout();
            // 
            // labelLeaderboard
            // 
            this.labelLeaderboard.AutoSize = true;
            this.labelLeaderboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeaderboard.Location = new System.Drawing.Point(86, 9);
            this.labelLeaderboard.Name = "labelLeaderboard";
            this.labelLeaderboard.Size = new System.Drawing.Size(253, 36);
            this.labelLeaderboard.TabIndex = 0;
            this.labelLeaderboard.Text = "TOP 10 ATTEMPS";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 366);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(219, 62);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 364);
            this.listBox2.TabIndex = 2;
            // 
            // TopPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelLeaderboard);
            this.Name = "TopPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLeaderboard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}
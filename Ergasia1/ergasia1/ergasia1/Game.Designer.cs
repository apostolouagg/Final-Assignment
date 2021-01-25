
namespace ergasia1
{
    partial class Game
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
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAttemps = new System.Windows.Forms.Label();
            this.timerGameDuration = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanelCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(262, 137);
            this.flowLayoutPanelCards.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(650, 434);
            this.flowLayoutPanelCards.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(353, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(51, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "label2";
            // 
            // labelAttemps
            // 
            this.labelAttemps.AutoSize = true;
            this.labelAttemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttemps.Location = new System.Drawing.Point(392, 53);
            this.labelAttemps.Name = "labelAttemps";
            this.labelAttemps.Size = new System.Drawing.Size(51, 20);
            this.labelAttemps.TabIndex = 4;
            this.labelAttemps.Text = "label3";
            // 
            // timerGameDuration
            // 
            this.timerGameDuration.Interval = 1000;
            this.timerGameDuration.Tick += new System.EventHandler(this.timerGameDuration_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 100);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:\r\n\r\nUser\'s attemps:\r\n\r\nTime in seconds:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(399, 92);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(51, 20);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "label4";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(515, 605);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(202, 40);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelAttemps);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAttemps;
        private System.Windows.Forms.Timer timerGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonRestart;
    }
}
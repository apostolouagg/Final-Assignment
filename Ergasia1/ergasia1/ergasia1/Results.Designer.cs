
namespace ergasia1
{
    partial class Results
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
            this.label1GoodJob = new System.Windows.Forms.Label();
            this.timer1ForAppearance = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackToGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1GoodJob
            // 
            this.label1GoodJob.BackColor = System.Drawing.Color.LightBlue;
            this.label1GoodJob.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1GoodJob.ForeColor = System.Drawing.Color.Black;
            this.label1GoodJob.Location = new System.Drawing.Point(48, -4);
            this.label1GoodJob.Name = "label1GoodJob";
            this.label1GoodJob.Size = new System.Drawing.Size(230, 56);
            this.label1GoodJob.TabIndex = 0;
            this.label1GoodJob.Text = "GOOD JOB !!!";
            this.label1GoodJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1ForAppearance
            // 
            this.timer1ForAppearance.Interval = 500;
            this.timer1ForAppearance.Tick += new System.EventHandler(this.timer1ForAppearance_Tick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 202);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Info: First on the list is your current attemp.";
            // 
            // buttonBackToGame
            // 
            this.buttonBackToGame.Location = new System.Drawing.Point(215, 366);
            this.buttonBackToGame.Name = "buttonBackToGame";
            this.buttonBackToGame.Size = new System.Drawing.Size(104, 23);
            this.buttonBackToGame.TabIndex = 3;
            this.buttonBackToGame.Text = "Back To Game";
            this.buttonBackToGame.UseVisualStyleBackColor = true;
            this.buttonBackToGame.Click += new System.EventHandler(this.buttonBackToGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attemps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time";
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.LightBlue;
            this.labelUsername.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(-6, 40);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(341, 34);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "label2";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(331, 401);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1GoodJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBackToGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1GoodJob;
        private System.Windows.Forms.Timer timer1ForAppearance;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackToGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsername;
    }
}
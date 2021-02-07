
namespace Chess_Game
{
    partial class Form_Chess_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chess_Game));
            this.label_Player_1 = new System.Windows.Forms.Label();
            this.label_Player_2 = new System.Windows.Forms.Label();
            this.label_Timer_1 = new System.Windows.Forms.Label();
            this.label_Timer_2 = new System.Windows.Forms.Label();
            this.button_Restart = new System.Windows.Forms.Button();
            this.button_ExitToMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.timerUpdateLabels = new System.Windows.Forms.Timer(this.components);
            this.boardBack = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Player_1
            // 
            this.label_Player_1.AutoSize = true;
            this.label_Player_1.BackColor = System.Drawing.Color.Transparent;
            this.label_Player_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Player_1.Location = new System.Drawing.Point(929, 231);
            this.label_Player_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Player_1.Name = "label_Player_1";
            this.label_Player_1.Size = new System.Drawing.Size(173, 28);
            this.label_Player_1.TabIndex = 2;
            this.label_Player_1.Text = "label_Player_1";
            // 
            // label_Player_2
            // 
            this.label_Player_2.AutoSize = true;
            this.label_Player_2.BackColor = System.Drawing.Color.Transparent;
            this.label_Player_2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player_2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Player_2.Location = new System.Drawing.Point(62, 467);
            this.label_Player_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Player_2.Name = "label_Player_2";
            this.label_Player_2.Size = new System.Drawing.Size(173, 28);
            this.label_Player_2.TabIndex = 3;
            this.label_Player_2.Text = "label_Player_2";
            // 
            // label_Timer_1
            // 
            this.label_Timer_1.AutoSize = true;
            this.label_Timer_1.BackColor = System.Drawing.Color.Transparent;
            this.label_Timer_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_1.Location = new System.Drawing.Point(933, 289);
            this.label_Timer_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Timer_1.Name = "label_Timer_1";
            this.label_Timer_1.Size = new System.Drawing.Size(169, 28);
            this.label_Timer_1.TabIndex = 5;
            this.label_Timer_1.Text = "label_Timer_1";
            // 
            // label_Timer_2
            // 
            this.label_Timer_2.AutoSize = true;
            this.label_Timer_2.BackColor = System.Drawing.Color.Transparent;
            this.label_Timer_2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_2.Location = new System.Drawing.Point(62, 509);
            this.label_Timer_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Timer_2.Name = "label_Timer_2";
            this.label_Timer_2.Size = new System.Drawing.Size(169, 28);
            this.label_Timer_2.TabIndex = 6;
            this.label_Timer_2.Text = "label_Timer_2";
            // 
            // button_Restart
            // 
            this.button_Restart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Restart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_Restart.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_Restart.Location = new System.Drawing.Point(956, 724);
            this.button_Restart.Margin = new System.Windows.Forms.Padding(2);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(95, 28);
            this.button_Restart.TabIndex = 7;
            this.button_Restart.Text = "Restart";
            this.button_Restart.UseVisualStyleBackColor = false;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // button_ExitToMenu
            // 
            this.button_ExitToMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ExitToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitToMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_ExitToMenu.ForeColor = System.Drawing.Color.Red;
            this.button_ExitToMenu.Location = new System.Drawing.Point(1065, 724);
            this.button_ExitToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExitToMenu.Name = "button_ExitToMenu";
            this.button_ExitToMenu.Size = new System.Drawing.Size(95, 28);
            this.button_ExitToMenu.TabIndex = 8;
            this.button_ExitToMenu.Text = "Exit To Menu";
            this.button_ExitToMenu.UseVisualStyleBackColor = false;
            this.button_ExitToMenu.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(470, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Date.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Date.Location = new System.Drawing.Point(538, 9);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(130, 28);
            this.label_Date.TabIndex = 11;
            this.label_Date.Text = "label_Date";
            // 
            // timerUpdateLabels
            // 
            this.timerUpdateLabels.Enabled = true;
            this.timerUpdateLabels.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // boardBack
            // 
            this.boardBack.BackgroundImage = global::Chess_Game.Properties.Resources.chessboard;
            this.boardBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardBack.Location = new System.Drawing.Point(305, 130);
            this.boardBack.Name = "boardBack";
            this.boardBack.Size = new System.Drawing.Size(540, 548);
            this.boardBack.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 200);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(867, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 200);
            this.panel2.TabIndex = 16;
            // 
            // buttonWhite
            // 
            this.buttonWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWhite.Location = new System.Drawing.Point(956, 130);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(111, 37);
            this.buttonWhite.TabIndex = 18;
            this.buttonWhite.Text = "Start Game";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.TurnButton_Press);
            // 
            // buttonBlack
            // 
            this.buttonBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlack.Location = new System.Drawing.Point(95, 620);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(111, 37);
            this.buttonBlack.TabIndex = 19;
            this.buttonBlack.Text = "Start Game";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.TurnButton_Press);
            // 
            // Form_Chess_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 763);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boardBack);
            this.Controls.Add(this.label_Player_2);
            this.Controls.Add(this.label_Player_1);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ExitToMenu);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.label_Timer_2);
            this.Controls.Add(this.label_Timer_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Chess_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Chess_Game";
            this.Load += new System.EventHandler(this.Form_Chess_Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Player_1;
        private System.Windows.Forms.Label label_Player_2;
        private System.Windows.Forms.Label label_Timer_1;
        private System.Windows.Forms.Label label_Timer_2;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.Button button_ExitToMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Timer timerUpdateLabels;
        private System.Windows.Forms.Panel boardBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonBlack;
    }
}
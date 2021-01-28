
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
            this.timer_Player1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Player2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_Player_1 = new System.Windows.Forms.Label();
            this.label_Player_2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Timer_1 = new System.Windows.Forms.Label();
            this.label_Timer_2 = new System.Windows.Forms.Label();
            this.button_Restart = new System.Windows.Forms.Button();
            this.button_ExitToMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ChessBoard = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Player1
            // 
            this.timer_Player1.Interval = 1000;
            this.timer_Player1.Tick += new System.EventHandler(this.timer_Player1_Tick);
            // 
            // timer_Player2
            // 
            this.timer_Player2.Interval = 1000;
            this.timer_Player2.Tick += new System.EventHandler(this.timer_Player2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label1.Location = new System.Drawing.Point(97, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1:\r\nPlayer 2:\r\n";
            // 
            // label_Player_1
            // 
            this.label_Player_1.AutoSize = true;
            this.label_Player_1.BackColor = System.Drawing.Color.Transparent;
            this.label_Player_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Player_1.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Player_1.Location = new System.Drawing.Point(212, 53);
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
            this.label_Player_2.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Player_2.Location = new System.Drawing.Point(212, 81);
            this.label_Player_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Player_2.Name = "label_Player_2";
            this.label_Player_2.Size = new System.Drawing.Size(173, 28);
            this.label_Player_2.TabIndex = 3;
            this.label_Player_2.Text = "label_Player_2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label4.Location = new System.Drawing.Point(492, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 56);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer 1:\r\nTimer 2:\r\n";
            // 
            // label_Timer_1
            // 
            this.label_Timer_1.AutoSize = true;
            this.label_Timer_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Timer_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_1.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Timer_1.Location = new System.Drawing.Point(603, 53);
            this.label_Timer_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Timer_1.Name = "label_Timer_1";
            this.label_Timer_1.Size = new System.Drawing.Size(169, 28);
            this.label_Timer_1.TabIndex = 5;
            this.label_Timer_1.Text = "label_Timer_1";
            // 
            // label_Timer_2
            // 
            this.label_Timer_2.AutoSize = true;
            this.label_Timer_2.BackColor = System.Drawing.Color.Black;
            this.label_Timer_2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_2.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Timer_2.Location = new System.Drawing.Point(603, 81);
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
            this.button_Restart.Location = new System.Drawing.Point(461, 13);
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
            this.button_ExitToMenu.Location = new System.Drawing.Point(562, 13);
            this.button_ExitToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.button_ExitToMenu.Name = "button_ExitToMenu";
            this.button_ExitToMenu.Size = new System.Drawing.Size(95, 28);
            this.button_ExitToMenu.TabIndex = 8;
            this.button_ExitToMenu.Text = "Exit To Menu";
            this.button_ExitToMenu.UseVisualStyleBackColor = false;
            this.button_ExitToMenu.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_ChessBoard
            // 
            this.pictureBox_ChessBoard.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox_ChessBoard.Image = global::Chess_Game.Properties.Resources.chessboard;
            this.pictureBox_ChessBoard.Location = new System.Drawing.Point(62, 124);
            this.pictureBox_ChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ChessBoard.Name = "pictureBox_ChessBoard";
            this.pictureBox_ChessBoard.Size = new System.Drawing.Size(595, 522);
            this.pictureBox_ChessBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ChessBoard.TabIndex = 0;
            this.pictureBox_ChessBoard.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Date.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Date.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_Date.Image = global::Chess_Game.Properties.Resources.chess_menu2;
            this.label_Date.Location = new System.Drawing.Point(141, 13);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(130, 28);
            this.label_Date.TabIndex = 11;
            this.label_Date.Text = "label_Date";
            // 
            // Form_Chess_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(742, 647);
            this.Controls.Add(this.label_Player_2);
            this.Controls.Add(this.label_Player_1);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ExitToMenu);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.label_Timer_2);
            this.Controls.Add(this.label_Timer_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ChessBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Chess_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Chess_Game";
            this.Load += new System.EventHandler(this.Form_Chess_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChessBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ChessBoard;
        private System.Windows.Forms.Timer timer_Player1;
        private System.Windows.Forms.Timer timer_Player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Player_1;
        private System.Windows.Forms.Label label_Player_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Timer_1;
        private System.Windows.Forms.Label label_Timer_2;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.Button button_ExitToMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Date;
    }
}
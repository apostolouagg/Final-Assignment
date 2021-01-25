﻿
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ChessBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChessBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Image = global::Chess_Game.Properties.Resources.wallpaper;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(76, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1:\r\nPlayer 2:\r\n";
            // 
            // label_Player_1
            // 
            this.label_Player_1.AutoSize = true;
            this.label_Player_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Player_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Player_1.Location = new System.Drawing.Point(227, 9);
            this.label_Player_1.Name = "label_Player_1";
            this.label_Player_1.Size = new System.Drawing.Size(227, 35);
            this.label_Player_1.TabIndex = 2;
            this.label_Player_1.Text = "label_Player_1";
            // 
            // label_Player_2
            // 
            this.label_Player_2.AutoSize = true;
            this.label_Player_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Player_2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Player_2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Player_2.Location = new System.Drawing.Point(227, 44);
            this.label_Player_2.Name = "label_Player_2";
            this.label_Player_2.Size = new System.Drawing.Size(227, 35);
            this.label_Player_2.TabIndex = 3;
            this.label_Player_2.Text = "label_Player_2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Image = global::Chess_Game.Properties.Resources.wallpaper;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(460, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 70);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer 1:\r\nTimer 2:\r\n";
            // 
            // label_Timer_1
            // 
            this.label_Timer_1.AutoSize = true;
            this.label_Timer_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Timer_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_1.Location = new System.Drawing.Point(604, 6);
            this.label_Timer_1.Name = "label_Timer_1";
            this.label_Timer_1.Size = new System.Drawing.Size(33, 35);
            this.label_Timer_1.TabIndex = 5;
            this.label_Timer_1.Text = "0";
            // 
            // label_Timer_2
            // 
            this.label_Timer_2.AutoSize = true;
            this.label_Timer_2.BackColor = System.Drawing.Color.Black;
            this.label_Timer_2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Timer_2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer_2.Location = new System.Drawing.Point(604, 44);
            this.label_Timer_2.Name = "label_Timer_2";
            this.label_Timer_2.Size = new System.Drawing.Size(33, 35);
            this.label_Timer_2.TabIndex = 6;
            this.label_Timer_2.Text = "0";
            // 
            // button_Restart
            // 
            this.button_Restart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Restart.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_Restart.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_Restart.Location = new System.Drawing.Point(688, 9);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(127, 35);
            this.button_Restart.TabIndex = 7;
            this.button_Restart.Text = "Restart";
            this.button_Restart.UseVisualStyleBackColor = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_Exit.ForeColor = System.Drawing.Color.Red;
            this.button_Exit.Location = new System.Drawing.Point(688, 54);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(127, 35);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chess_Game.Properties.Resources.wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 807);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_ChessBoard
            // 
            this.pictureBox_ChessBoard.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox_ChessBoard.Image = global::Chess_Game.Properties.Resources.chessboard;
            this.pictureBox_ChessBoard.Location = new System.Drawing.Point(55, 95);
            this.pictureBox_ChessBoard.Name = "pictureBox_ChessBoard";
            this.pictureBox_ChessBoard.Size = new System.Drawing.Size(793, 689);
            this.pictureBox_ChessBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ChessBoard.TabIndex = 0;
            this.pictureBox_ChessBoard.TabStop = false;
            // 
            // Form_Chess_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(928, 796);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.label_Timer_2);
            this.Controls.Add(this.label_Timer_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Player_2);
            this.Controls.Add(this.label_Player_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ChessBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Chess_Game";
            this.Text = "Form_Chess_Game";
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
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
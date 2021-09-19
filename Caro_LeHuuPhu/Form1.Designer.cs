
namespace Caro_LeHuuPhu
{
    partial class Form1
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
            this.panelChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonWinPlay1 = new System.Windows.Forms.Button();
            this.buttonUndoPlay1 = new System.Windows.Forms.Button();
            this.buttonTimePlay1 = new System.Windows.Forms.Button();
            this.buttonPlay1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonWinPlay2 = new System.Windows.Forms.Button();
            this.buttonUndoPlay2 = new System.Windows.Forms.Button();
            this.buttonTimePlay2 = new System.Windows.Forms.Button();
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.buttonToPlayer = new System.Windows.Forms.Button();
            this.progressBarCountDownTmer = new System.Windows.Forms.ProgressBar();
            this.timerCountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.timerHightLine = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.BackColor = System.Drawing.Color.Teal;
            this.panelChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChessBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelChessBoard.Location = new System.Drawing.Point(12, 21);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(563, 567);
            this.panelChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Location = new System.Drawing.Point(581, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 90);
            this.panel2.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Yellow;
            this.buttonClear.Location = new System.Drawing.Point(5, 50);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(114, 37);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Yellow;
            this.buttonStart.Location = new System.Drawing.Point(4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 44);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonWinPlay1);
            this.panel3.Controls.Add(this.buttonUndoPlay1);
            this.panel3.Controls.Add(this.buttonTimePlay1);
            this.panel3.Controls.Add(this.buttonPlay1);
            this.panel3.Location = new System.Drawing.Point(581, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 143);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonWinPlay1
            // 
            this.buttonWinPlay1.BackColor = System.Drawing.Color.Olive;
            this.buttonWinPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWinPlay1.Location = new System.Drawing.Point(3, 107);
            this.buttonWinPlay1.Name = "buttonWinPlay1";
            this.buttonWinPlay1.Size = new System.Drawing.Size(115, 31);
            this.buttonWinPlay1.TabIndex = 3;
            this.buttonWinPlay1.Text = "Win-00/00";
            this.buttonWinPlay1.UseVisualStyleBackColor = false;
            // 
            // buttonUndoPlay1
            // 
            this.buttonUndoPlay1.BackColor = System.Drawing.Color.Olive;
            this.buttonUndoPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndoPlay1.Location = new System.Drawing.Point(3, 74);
            this.buttonUndoPlay1.Name = "buttonUndoPlay1";
            this.buttonUndoPlay1.Size = new System.Drawing.Size(115, 31);
            this.buttonUndoPlay1.TabIndex = 2;
            this.buttonUndoPlay1.Text = "Undo-00";
            this.buttonUndoPlay1.UseVisualStyleBackColor = false;
            this.buttonUndoPlay1.Click += new System.EventHandler(this.buttonUndoPlay1_Click);
            // 
            // buttonTimePlay1
            // 
            this.buttonTimePlay1.BackColor = System.Drawing.Color.Olive;
            this.buttonTimePlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimePlay1.Location = new System.Drawing.Point(3, 42);
            this.buttonTimePlay1.Name = "buttonTimePlay1";
            this.buttonTimePlay1.Size = new System.Drawing.Size(115, 31);
            this.buttonTimePlay1.TabIndex = 1;
            this.buttonTimePlay1.Text = "Time: 00:00";
            this.buttonTimePlay1.UseVisualStyleBackColor = false;
            // 
            // buttonPlay1
            // 
            this.buttonPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay1.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPlay1.Location = new System.Drawing.Point(3, 4);
            this.buttonPlay1.Name = "buttonPlay1";
            this.buttonPlay1.Size = new System.Drawing.Size(116, 36);
            this.buttonPlay1.TabIndex = 0;
            this.buttonPlay1.Text = "PLAY 1";
            this.buttonPlay1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonWinPlay2);
            this.panel4.Controls.Add(this.buttonUndoPlay2);
            this.panel4.Controls.Add(this.buttonTimePlay2);
            this.panel4.Controls.Add(this.buttonPlay2);
            this.panel4.Location = new System.Drawing.Point(581, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 156);
            this.panel4.TabIndex = 3;
            // 
            // buttonWinPlay2
            // 
            this.buttonWinPlay2.BackColor = System.Drawing.Color.Olive;
            this.buttonWinPlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWinPlay2.Location = new System.Drawing.Point(3, 116);
            this.buttonWinPlay2.Name = "buttonWinPlay2";
            this.buttonWinPlay2.Size = new System.Drawing.Size(115, 33);
            this.buttonWinPlay2.TabIndex = 3;
            this.buttonWinPlay2.Text = "Win-00/00";
            this.buttonWinPlay2.UseVisualStyleBackColor = false;
            // 
            // buttonUndoPlay2
            // 
            this.buttonUndoPlay2.BackColor = System.Drawing.Color.Olive;
            this.buttonUndoPlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndoPlay2.Location = new System.Drawing.Point(3, 82);
            this.buttonUndoPlay2.Name = "buttonUndoPlay2";
            this.buttonUndoPlay2.Size = new System.Drawing.Size(115, 33);
            this.buttonUndoPlay2.TabIndex = 2;
            this.buttonUndoPlay2.Text = "Undo-00";
            this.buttonUndoPlay2.UseVisualStyleBackColor = false;
            this.buttonUndoPlay2.Click += new System.EventHandler(this.buttonUndoPlay2_Click);
            // 
            // buttonTimePlay2
            // 
            this.buttonTimePlay2.BackColor = System.Drawing.Color.Olive;
            this.buttonTimePlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimePlay2.Location = new System.Drawing.Point(3, 48);
            this.buttonTimePlay2.Name = "buttonTimePlay2";
            this.buttonTimePlay2.Size = new System.Drawing.Size(115, 33);
            this.buttonTimePlay2.TabIndex = 1;
            this.buttonTimePlay2.Text = "Time: 00:00";
            this.buttonTimePlay2.UseVisualStyleBackColor = false;
            // 
            // buttonPlay2
            // 
            this.buttonPlay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonPlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPlay2.Location = new System.Drawing.Point(4, 6);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(114, 35);
            this.buttonPlay2.TabIndex = 0;
            this.buttonPlay2.Text = "PLAY 2";
            this.buttonPlay2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(611, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game caro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(594, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lê Hữu Phú - 18CT1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(582, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến Lượt của:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.Color.Navy;
            this.labelPlayer.Location = new System.Drawing.Point(585, 473);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(71, 18);
            this.labelPlayer.TabIndex = 7;
            this.labelPlayer.Text = "_______";
            // 
            // buttonToPlayer
            // 
            this.buttonToPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToPlayer.Location = new System.Drawing.Point(659, 460);
            this.buttonToPlayer.Name = "buttonToPlayer";
            this.buttonToPlayer.Size = new System.Drawing.Size(43, 33);
            this.buttonToPlayer.TabIndex = 8;
            this.buttonToPlayer.UseVisualStyleBackColor = true;
            // 
            // progressBarCountDownTmer
            // 
            this.progressBarCountDownTmer.BackColor = System.Drawing.Color.Teal;
            this.progressBarCountDownTmer.ForeColor = System.Drawing.Color.Yellow;
            this.progressBarCountDownTmer.Location = new System.Drawing.Point(14, 6);
            this.progressBarCountDownTmer.Name = "progressBarCountDownTmer";
            this.progressBarCountDownTmer.Size = new System.Drawing.Size(683, 8);
            this.progressBarCountDownTmer.Step = 1;
            this.progressBarCountDownTmer.TabIndex = 9;
            this.progressBarCountDownTmer.Value = 100;
            // 
            // timerCountDownTimer
            // 
            this.timerCountDownTimer.Tick += new System.EventHandler(this.timerCountDownTimer_Tick);
            // 
            // timerHightLine
            // 
            this.timerHightLine.Tick += new System.EventHandler(this.timerHightLine_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(714, 602);
            this.Controls.Add(this.progressBarCountDownTmer);
            this.Controls.Add(this.buttonToPlayer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChessBoard);
            this.Name = "Form1";
            this.Text = "frm LeHuuPhu";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonWinPlay1;
        private System.Windows.Forms.Button buttonUndoPlay1;
        private System.Windows.Forms.Button buttonTimePlay1;
        private System.Windows.Forms.Button buttonPlay1;
        private System.Windows.Forms.Button buttonWinPlay2;
        private System.Windows.Forms.Button buttonUndoPlay2;
        private System.Windows.Forms.Button buttonTimePlay2;
        private System.Windows.Forms.Button buttonPlay2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button buttonToPlayer;
        private System.Windows.Forms.ProgressBar progressBarCountDownTmer;
        private System.Windows.Forms.Timer timerCountDownTimer;
        private System.Windows.Forms.Timer timerHightLine;
    }
}


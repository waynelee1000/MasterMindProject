namespace MasterMindProject
{
    partial class FrmMasterMind
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
            this.pnlGuessArea = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lbldifficulty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoreBoard = new System.Windows.Forms.Button();
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnSolutionAt4 = new System.Windows.Forms.Button();
            this.btnSolutionAt3 = new System.Windows.Forms.Button();
            this.btnSolutionAt1 = new System.Windows.Forms.Button();
            this.btnSolutionAt2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.btnGuessAtFour = new System.Windows.Forms.Button();
            this.btnGuessAtOne = new System.Windows.Forms.Button();
            this.btnGuessAtThree = new System.Windows.Forms.Button();
            this.BtnGuessAtTwo = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlScoreboard = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlUserGuess = new System.Windows.Forms.Panel();
            this.lblGuessInstru = new System.Windows.Forms.Label();
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.pnlSolution.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.pnlScoreboard.SuspendLayout();
            this.pnlUserGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGuessArea
            // 
            this.pnlGuessArea.Location = new System.Drawing.Point(57, 320);
            this.pnlGuessArea.Name = "pnlGuessArea";
            this.pnlGuessArea.Size = new System.Drawing.Size(179, 457);
            this.pnlGuessArea.TabIndex = 0;
            this.pnlGuessArea.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(243, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Master Mind";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(464, 77);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 156;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 153;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.Location = new System.Drawing.Point(221, 88);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(75, 23);
            this.BtnHard.TabIndex = 151;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = true;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(221, 59);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 150;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(221, 30);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 149;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lbldifficulty
            // 
            this.lbldifficulty.AutoSize = true;
            this.lbldifficulty.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldifficulty.Location = new System.Drawing.Point(13, 15);
            this.lbldifficulty.Name = "lbldifficulty";
            this.lbldifficulty.Size = new System.Drawing.Size(176, 24);
            this.lbldifficulty.TabIndex = 148;
            this.lbldifficulty.Text = "Choose Your Difficulty:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(321, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 147;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(170, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 17);
            this.lblName.TabIndex = 146;
            this.lblName.Text = "Enter your name:";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(46, 88);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(101, 32);
            this.btnPlayAgain.TabIndex = 159;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(46, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 29);
            this.btnExit.TabIndex = 158;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoreBoard
            // 
            this.btnScoreBoard.Location = new System.Drawing.Point(46, 47);
            this.btnScoreBoard.Name = "btnScoreBoard";
            this.btnScoreBoard.Size = new System.Drawing.Size(101, 32);
            this.btnScoreBoard.TabIndex = 157;
            this.btnScoreBoard.Text = "Score Board";
            this.btnScoreBoard.UseVisualStyleBackColor = true;
            this.btnScoreBoard.Click += new System.EventHandler(this.btnScoreBoard_Click);
            // 
            // pnlSolution
            // 
            this.pnlSolution.Controls.Add(this.lblSolution);
            this.pnlSolution.Controls.Add(this.btnSolutionAt4);
            this.pnlSolution.Controls.Add(this.btnSolutionAt3);
            this.pnlSolution.Controls.Add(this.btnSolutionAt1);
            this.pnlSolution.Controls.Add(this.btnSolutionAt2);
            this.pnlSolution.Location = new System.Drawing.Point(464, 657);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(243, 65);
            this.pnlSolution.TabIndex = 160;
            this.pnlSolution.Visible = false;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(30, 10);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(63, 17);
            this.lblSolution.TabIndex = 141;
            this.lblSolution.Text = "Solution:";
            // 
            // btnSolutionAt4
            // 
            this.btnSolutionAt4.BackColor = System.Drawing.Color.White;
            this.btnSolutionAt4.Location = new System.Drawing.Point(153, 30);
            this.btnSolutionAt4.Name = "btnSolutionAt4";
            this.btnSolutionAt4.Size = new System.Drawing.Size(34, 32);
            this.btnSolutionAt4.TabIndex = 140;
            this.btnSolutionAt4.UseVisualStyleBackColor = false;
            // 
            // btnSolutionAt3
            // 
            this.btnSolutionAt3.BackColor = System.Drawing.Color.White;
            this.btnSolutionAt3.Location = new System.Drawing.Point(113, 30);
            this.btnSolutionAt3.Name = "btnSolutionAt3";
            this.btnSolutionAt3.Size = new System.Drawing.Size(34, 32);
            this.btnSolutionAt3.TabIndex = 139;
            this.btnSolutionAt3.UseVisualStyleBackColor = false;
            // 
            // btnSolutionAt1
            // 
            this.btnSolutionAt1.BackColor = System.Drawing.Color.White;
            this.btnSolutionAt1.Location = new System.Drawing.Point(33, 30);
            this.btnSolutionAt1.Name = "btnSolutionAt1";
            this.btnSolutionAt1.Size = new System.Drawing.Size(34, 32);
            this.btnSolutionAt1.TabIndex = 137;
            this.btnSolutionAt1.UseVisualStyleBackColor = false;
            // 
            // btnSolutionAt2
            // 
            this.btnSolutionAt2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSolutionAt2.Location = new System.Drawing.Point(73, 30);
            this.btnSolutionAt2.Name = "btnSolutionAt2";
            this.btnSolutionAt2.Size = new System.Drawing.Size(34, 32);
            this.btnSolutionAt2.TabIndex = 138;
            this.btnSolutionAt2.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(185, 45);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 32);
            this.btnSubmit.TabIndex = 161;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlHint
            // 
            this.pnlHint.Location = new System.Drawing.Point(249, 320);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(167, 457);
            this.pnlHint.TabIndex = 162;
            this.pnlHint.Visible = false;
            // 
            // btnGuessAtFour
            // 
            this.btnGuessAtFour.BackColor = System.Drawing.Color.Red;
            this.btnGuessAtFour.Location = new System.Drawing.Point(132, 45);
            this.btnGuessAtFour.Name = "btnGuessAtFour";
            this.btnGuessAtFour.Size = new System.Drawing.Size(34, 32);
            this.btnGuessAtFour.TabIndex = 166;
            this.btnGuessAtFour.UseVisualStyleBackColor = false;
            this.btnGuessAtFour.Click += new System.EventHandler(this.button_Click);
            // 
            // btnGuessAtOne
            // 
            this.btnGuessAtOne.BackColor = System.Drawing.Color.Red;
            this.btnGuessAtOne.Location = new System.Drawing.Point(12, 45);
            this.btnGuessAtOne.Name = "btnGuessAtOne";
            this.btnGuessAtOne.Size = new System.Drawing.Size(34, 32);
            this.btnGuessAtOne.TabIndex = 163;
            this.btnGuessAtOne.UseVisualStyleBackColor = false;
            this.btnGuessAtOne.Click += new System.EventHandler(this.button_Click);
            // 
            // btnGuessAtThree
            // 
            this.btnGuessAtThree.BackColor = System.Drawing.Color.Red;
            this.btnGuessAtThree.Location = new System.Drawing.Point(92, 45);
            this.btnGuessAtThree.Name = "btnGuessAtThree";
            this.btnGuessAtThree.Size = new System.Drawing.Size(34, 32);
            this.btnGuessAtThree.TabIndex = 165;
            this.btnGuessAtThree.UseVisualStyleBackColor = false;
            this.btnGuessAtThree.Click += new System.EventHandler(this.button_Click);
            // 
            // BtnGuessAtTwo
            // 
            this.BtnGuessAtTwo.BackColor = System.Drawing.Color.Red;
            this.BtnGuessAtTwo.Location = new System.Drawing.Point(52, 45);
            this.BtnGuessAtTwo.Name = "BtnGuessAtTwo";
            this.BtnGuessAtTwo.Size = new System.Drawing.Size(34, 32);
            this.BtnGuessAtTwo.TabIndex = 164;
            this.BtnGuessAtTwo.UseVisualStyleBackColor = false;
            this.BtnGuessAtTwo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(478, 33);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(163, 23);
            this.btnRules.TabIndex = 167;
            this.btnRules.Text = "Click Here for Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Controls.Add(this.lblInstruction);
            this.pnlDifficulty.Controls.Add(this.lbldifficulty);
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Controls.Add(this.btnMedium);
            this.pnlDifficulty.Controls.Add(this.BtnHard);
            this.pnlDifficulty.Controls.Add(this.btnStart);
            this.pnlDifficulty.Location = new System.Drawing.Point(100, 124);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(520, 180);
            this.pnlDifficulty.TabIndex = 168;
            this.pnlDifficulty.Visible = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(57, 146);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(259, 17);
            this.lblInstruction.TabIndex = 168;
            this.lblInstruction.Text = "Press Start when ready. Timer will Start:\r\n";
            // 
            // pnlScoreboard
            // 
            this.pnlScoreboard.Controls.Add(this.lblTimer);
            this.pnlScoreboard.Controls.Add(this.lblTime);
            this.pnlScoreboard.Controls.Add(this.btnScoreBoard);
            this.pnlScoreboard.Controls.Add(this.btnExit);
            this.pnlScoreboard.Controls.Add(this.btnPlayAgain);
            this.pnlScoreboard.Location = new System.Drawing.Point(464, 320);
            this.pnlScoreboard.Name = "pnlScoreboard";
            this.pnlScoreboard.Size = new System.Drawing.Size(200, 178);
            this.pnlScoreboard.TabIndex = 169;
            this.pnlScoreboard.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(101, 17);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 17);
            this.lblTimer.TabIndex = 161;
            this.lblTimer.Text = "Timer";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(43, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 160;
            this.lblTime.Text = "Time:";
            // 
            // pnlUserGuess
            // 
            this.pnlUserGuess.Controls.Add(this.lblGuessInstru);
            this.pnlUserGuess.Controls.Add(this.btnGuessAtFour);
            this.pnlUserGuess.Controls.Add(this.btnGuessAtThree);
            this.pnlUserGuess.Controls.Add(this.btnGuessAtOne);
            this.pnlUserGuess.Controls.Add(this.BtnGuessAtTwo);
            this.pnlUserGuess.Controls.Add(this.btnSubmit);
            this.pnlUserGuess.Location = new System.Drawing.Point(443, 531);
            this.pnlUserGuess.Name = "pnlUserGuess";
            this.pnlUserGuess.Size = new System.Drawing.Size(290, 103);
            this.pnlUserGuess.TabIndex = 170;
            this.pnlUserGuess.Visible = false;
            // 
            // lblGuessInstru
            // 
            this.lblGuessInstru.AutoSize = true;
            this.lblGuessInstru.Location = new System.Drawing.Point(16, 16);
            this.lblGuessInstru.Name = "lblGuessInstru";
            this.lblGuessInstru.Size = new System.Drawing.Size(199, 17);
            this.lblGuessInstru.TabIndex = 167;
            this.lblGuessInstru.Text = "Click through to choose color :";
            // 
            // timerScore
            // 
            this.timerScore.Interval = 1000;
            // 
            // FrmMasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 833);
            this.Controls.Add(this.pnlUserGuess);
            this.Controls.Add(this.pnlScoreboard);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.pnlHint);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.pnlSolution);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGuessArea);
            this.Name = "FrmMasterMind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSolution.ResumeLayout(false);
            this.pnlSolution.PerformLayout();
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            this.pnlScoreboard.ResumeLayout(false);
            this.pnlScoreboard.PerformLayout();
            this.pnlUserGuess.ResumeLayout(false);
            this.pnlUserGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGuessArea;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label lbldifficulty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoreBoard;
        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnSolutionAt4;
        private System.Windows.Forms.Button btnSolutionAt3;
        private System.Windows.Forms.Button btnSolutionAt1;
        private System.Windows.Forms.Button btnSolutionAt2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Button btnGuessAtFour;
        private System.Windows.Forms.Button btnGuessAtOne;
        private System.Windows.Forms.Button btnGuessAtThree;
        private System.Windows.Forms.Button BtnGuessAtTwo;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Panel pnlScoreboard;
        private System.Windows.Forms.Panel pnlUserGuess;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Timer timerScore;
        private System.Windows.Forms.Label lblGuessInstru;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTime;
    }
}


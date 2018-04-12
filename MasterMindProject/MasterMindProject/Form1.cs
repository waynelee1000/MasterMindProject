using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

using System.Threading;
using System.Windows.Forms;

namespace MasterMindProject
{
    public partial class FrmMasterMind : Form
    {
        public FrmMasterMind()
        {
            InitializeComponent();
        }
        
        private int Easy = 12;
        private int medium = 10;
        private int hard = 8;
        private int numguess = 0;
        private int blackpeg;
        private int whitepeg;
        private int Diffculty;
        private string DiffcultyScore;
        DateTime startTime;
        DateTime endTime;

        private Button[,] guessButton = new Button[12, 4];
        private Button[,] pegButton = new Button[12, 4];

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600, 300); // size the form
        }

        //GuessAreaClass guessArea = new GuessAreaClass();
        GameSolutionClass gameSolution = new GameSolutionClass();
        ScoreBoard scoreBoardClass = new ScoreBoard();
        

        //this dynamatically create the board take take in how much row they want.
        public void CreateBoard(int numRow)
        {
            //size of buttom
            Size size = new Size(30, 30);
            Point loc = new Point(0, 0);
            
            for (int row = 0; row < numRow; row++)
            {
                loc.Y =   row * (size.Height);
                for (int col = 0; col < 4; col++)
                {
                    guessButton[row, col] = new Button();
                    guessButton[row, col].Location = new Point( col * (size.Width), loc.Y);
                    guessButton[row, col].Size = size;

                    guessButton[row, col].BackColor = default(Color);
                    guessButton[row, col].Name = "btn" + row.ToString() + col.ToString();
                    // Add button to the form
                    pnlGuessArea.Controls.Add(guessButton[row, col]);
                    guessButton[row, col].Enabled = false;
                    
                }
            }
        }
        //this dynamically create the peg base on the difficulty. 
        public void createPeg(int numRow) {
            //size of buttom
            Size size = new Size(23, 30);
            Point loc = new Point(0, 0);
            for (int row = 0; row < numRow; row++)
            {
                loc.Y = row * (size.Height);
                for (int col = 0; col < 4; col++)
                {
                    pegButton[row, col] = new Button(); // create button
                    pegButton[row, col].Location = new Point(col * (size.Width), loc.Y);
                    pegButton[row, col].Size = size;
                    pegButton[row, col].BackColor = default(Color);
                    pegButton[row, col].Name = "btn" + row.ToString() + col.ToString();
                    pnlHint.Controls.Add(pegButton[row, col]); // add to form

                    pegButton[row, col].Enabled = false;
                    ///method to reset array
                }
            }
        }

        //this is a button handler to enable user to click through the color. 
        private void btnGuess_Click(object sender, EventArgs e)
        {
                var button = ((Button)sender);

            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Yellow;

            }
            else if (button.BackColor == Color.Yellow)
            {

                button.BackColor = Color.Blue;
            }
            else if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.Green;
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Purple;
            }
            else if (button.BackColor == Color.Purple)
            {
                button.BackColor = Color.Pink;
            }
            else if (button.BackColor == Color.Pink)
            {
                button.BackColor = Color.Red;
            }
            
        }
        //When user click easy difficulty. it will create the board and peg with 12 row. Also enable and disenabling.
        private void btnEasy_Click(object sender, EventArgs e)
        {
            
            CreateBoard(Easy);
            createPeg(Easy);
            solutioninform();
            Diffculty = Easy;
            DiffcultyScore = "Easy";
            btnEasy.Enabled = true;
            btnMedium.Enabled = false;
            BtnHard.Enabled = false;
            
            btnStart.Enabled = true;
        }

        //When user click easy difficulty. it will create the board and peg with 10 row. Also enable and disenabling.
        private void btnMedium_Click(object sender, EventArgs e)
        {
            
            CreateBoard(medium);
            createPeg(medium);
            solutioninform();
            Diffculty = medium;

            DiffcultyScore = "Medium";
            btnEasy.Enabled = false;
            btnMedium.Enabled = true;
            BtnHard.Enabled = false;
            
            btnStart.Enabled = true;

        }

        //When user click easy difficulty. it will create the board and peg with 8 row. Also enable and disenabling.
        private void BtnHard_Click(object sender, EventArgs e)
        {
            
            CreateBoard(hard);
            createPeg(hard);
            solutioninform();
            Diffculty = hard;

            DiffcultyScore = "Hard";
            btnEasy.Enabled = false;
            btnMedium.Enabled = false;
            BtnHard.Enabled = true;

           
            btnStart.Enabled = true;
        }

        //this validate to make sure user input a "name"
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name");
            }
            else
            {
                pnlDifficulty.Visible = true;
                txtName.Enabled = false;
                btnStart.Enabled = false;
                btnOK.Enabled = false;
                scoreBoardClass.Intilized(); // call method to read from currentfile and put into array list
            }
        }

        //when click submit, it will display what user pick into the board, display grey and black peg, check if they win or lose.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            displayGuessInForm();
            gameSolution.guessArea.setUserGuess(getUserGuess());

            gameSolution.blackPegs();
            gameSolution.whitePegs();

            blackpeg = gameSolution.solutionReporting.returnBlackPegs();
            whitepeg = gameSolution.solutionReporting.returnWhitePegs();
            displayPegInForm();

            numguess++;
            MessageBox.Show(gameSolution.displaySolution(), "SOLUTION FOR TESTIN/");  //If you want to use this for testing. This show the solution. 

            //check for winner
            if (gameSolution.solutionReporting.returnBlackPegs() == 4)
            {
                

                btnSubmit.Enabled = false;
                pnlSolution.Visible = true;

                //stop timer,get total time and set it
                timerScore.Stop();
                endTime = DateTime.Now;
                long elapsedTicks = endTime.Ticks - startTime.Ticks;
                MessageBox.Show("You Win");

                TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
                double time = elapsedSpan.TotalSeconds;
                ScoreBoard.playerClass.setTime(time);
                ScoreBoard.playerClass.setDifficulty(DiffcultyScore);
                ScoreBoard.playerClass.setName(txtName.Text);
                
                scoreBoardClass.findAndSaveScore();
                
            }
            //check for lose
            if (numguess == Diffculty)
                {
                    MessageBox.Show("You Lose");
                    timerScore.Stop();
                    pnlSolution.Visible = true;
                    btnSubmit.Enabled = false;
                }
        }
        //use to display guess into form
        public void displayGuessInForm() {
            guessButton[numguess, 0].BackColor = btnGuessAtOne.BackColor;
            guessButton[numguess, 1].BackColor = BtnGuessAtTwo.BackColor;
            guessButton[numguess, 2].BackColor = btnGuessAtThree.BackColor;
            guessButton[numguess, 3].BackColor = btnGuessAtFour.BackColor;
        }
        //use to display peg into form
        public void displayPegInForm() {
            int tempBlack = blackpeg ;
            if (blackpeg != 0)
            {
                for (int i = 0; i < blackpeg; i++)
                {
                    pegButton[numguess, i].BackColor = Color.Black;
                }
            }

            if(whitepeg != 0)
            {
                for (int i = 0; i < whitepeg; i++)
                {
                    pegButton[numguess, tempBlack].BackColor = Color.Gray;
                    tempBlack++;
                }
            }

        }
        //use to display solution into form
        private void solutioninform()
        {
            string[] words = gameSolution.displaySolution().Split(' ');
            btnSolutionAt1.BackColor = Color.FromName(words[0]);
            btnSolutionAt2.BackColor = Color.FromName(words[1]);
            btnSolutionAt3.BackColor = Color.FromName(words[2]);
            btnSolutionAt4.BackColor = Color.FromName(words[3]);
        }
        //get the user guess as a string
        public string getUserGuess() {
            string UserGuess = "";
            Color GuessAtOne = btnGuessAtOne.BackColor;
            string colorAtOne = GuessAtOne.Name;
            Color GuessAtTwo = BtnGuessAtTwo.BackColor;
            string colorAtTwo = GuessAtTwo.Name;
            Color GuessAtThree = btnGuessAtThree.BackColor;
            string colorAtThree = GuessAtThree.Name;
            Color GuessAtFour = btnGuessAtFour.BackColor;
            string colorAtFour = GuessAtFour.Name;
            UserGuess = colorAtOne + " "+ colorAtTwo + " " + colorAtThree +" "+ colorAtFour;
            return UserGuess;
        }

        
        //use to display the rules
        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rule: Make a four colour guess to match AI choice.You have limited guess, when you run out guess, you lose.\n" +
                "To make guess and click throught the color of your choice  and click submit. Use hint on the side to aid your guess.\n A black" +
                " peg = you have match and correct color\n grey peg = correct color\n empty = no correct color or match");
        }
        //when player want to play again. it would set the board.
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            resetgameBoard();
            pnlScoreboard.Visible = false;
            pnlUserGuess.Visible = false;
            pnlSolution.Visible = false;
            pnlHint.Visible = false;
            pnlGuessArea.Visible = false;
        }
        //reset he board method. remove all the button, peg, and reset color.
        public void resetgameBoard() {
            for (int row = 0; row < Diffculty; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (pnlGuessArea.Controls.Contains(guessButton[row, col])){

                    pnlGuessArea.Controls.Remove(guessButton[row, col]);
                    guessButton[row, col].Dispose();
                    pnlHint.Controls.Remove(pegButton[row, col]);
                    pegButton[row, col].Dispose();
                    }
                }
            }
            btnGuessAtOne.BackColor = Color.Red;
            BtnGuessAtTwo.BackColor = Color.Red;
            btnGuessAtThree.BackColor = Color.Red;
            btnGuessAtFour.BackColor = Color.Red;
            btnEasy.Enabled = true  ;
            btnMedium.Enabled = true;
            BtnHard.Enabled = true;
            numguess = 0;

        }
        //close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //when user close the program. it would write from arraylist into updatedfile and copy into currentfile to be read again when user reopen.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            scoreBoardClass.writeOneRecord();
            scoreBoardClass.copyFiles();
            scoreBoardClass.resetPlayerList();
        }
        //when user start the game, timer will start, and give a solution.
        private void btnStart_Click(object sender, EventArgs e)
        {
            gameSolution.setSolution();
            this.Size = new Size(600, 700);
            pnlUserGuess.Visible = true;
            pnlScoreboard.Visible = true;
            pnlGuessArea.Visible = true;
            pnlHint.Visible = true;
            btnStart.Enabled = false;
            btnEasy.Enabled = false;
            BtnHard.Enabled = false;
            btnMedium.Enabled = false;
            btnSubmit.Enabled = true;
            
            timerScore.Tick += (s, ev) => {lblTimer.Text = String.Format("{0:00}", (DateTime.Now - startTime).Seconds)+" sec"; };
            startTime = DateTime.Now;
            timerScore.Interval = 100;       // every 1/10 of a second
            timerScore.Start();
            
        }
        //this display the scoreboard
        private void btnScoreBoard_Click(object sender, EventArgs e)
        {
            
            scoreBoardClass.displayScoreBoard();
        }

        
    }
}

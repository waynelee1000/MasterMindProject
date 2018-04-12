using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//this is class is used to read and write into currentfile, updatedfile. We store information in array and display it. 

namespace MasterMindProject
{

    class ScoreBoard
    {
        private string Otherplayer;
        private string OtherDifficulty;
        private double OtherTime;
        List<string> PlayerList = new List<string>();

        public static PlayerClass playerClass = new PlayerClass();
        private static string currentScoreBoardPath = "currentScoreBoardFile.txt";
        private static string updatedScoreBoardPath = "updatedScoreBoardFile.txt";
        public static currentFileClass currentScoreBoardFile = new currentFileClass(currentScoreBoardPath);
        public static updatedFileClass updatedScoreBoardFile = new updatedFileClass(updatedScoreBoardPath);
        
        public ScoreBoard() {
            
        }
        //this reset the arraylist when program end. Which let the the new information to be readed into
        public void resetPlayerList() {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                PlayerList[i] = null;
            }
        }
        //this create a string object when reading the currentfile
        public void createStringObject(string nextRecord)  // IN: string from the Book Text File
        {
            string[] playerString = nextRecord.Split('*');

            for (int i = 0; i < playerString.Length; i++)
            {
                playerString[i] = playerString[i].Trim();
            }
            
            Otherplayer = playerString[0];
            OtherDifficulty = playerString[1];
            OtherTime = Convert.ToDouble(playerString[2]);

        }

        //compare the current user and other player in same diffuclty if they get the lower time.
        public bool HigherScore()
        {
           
            string Difficulty= playerClass.getDifficulty();
            double time = playerClass.getTime();

            if (OtherDifficulty == Difficulty)//compare difficulty
            {
                if (time < OtherTime)//compare time
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
                
        }
        //this read the currentfile and put them in a list.
        public void Intilized()
        {
            Boolean isEndOfFile = true;
            string nextRecord;
            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);

            while (!isEndOfFile)
            {
                PlayerList.Add(nextRecord);
                nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            }


            currentScoreBoardFile.closeFile();
        }
        //find if user is a new high score and write into the arraylist
        public void findAndSaveScore()
        {
           //get user name, time, and difficulty
            string Difficulty = playerClass.getDifficulty();
            double time = playerClass.getTime();
            string player = playerClass.getName();
            string playerString = player +"     *    "+ Difficulty +"    *    "+ time.ToString() ;

            for (int i = 0; i < PlayerList.Count; i++) {

                createStringObject(PlayerList[i]); // create the object
                if (HigherScore()) { // see if high score
                    PlayerList[i] = playerString; // write into arraylist
                }
                
            }
            
        }
        //write at the end of the program to the updated file
        public void writeOneRecord()
        {
           
            for (int i = 0; i < PlayerList.Count; i++)
            {
                updatedScoreBoardFile.putNextRecord(PlayerList[i]);
            }

            updatedScoreBoardFile.closeFile();
        }
       
        //– closes all external files
        public void closeFiles()
        {
            updatedScoreBoardFile.closeFile();
            currentScoreBoardFile.closeFile();
        }

        //use to display the curent scoreboard
        public void displayScoreBoard()
        {
           
            string Scoreboard = "Make the High score by having a lower time in a difficulty level!!\nEvery Little seconds count.\n\n"+"Name:             Difficulty:           Sec:\n";

            for (int i = 0; i < PlayerList.Count; i++)
            {
                Scoreboard += PlayerList[i] + "\n";
            }
            MessageBox.Show(Scoreboard, "HIGHSCORE");

        }

        //copy what is in the updated file into currrent file. 
        public void copyFiles()
        {
            if (File.Exists("currentScoreBoardFile.txt")) // we need to delete it first to copy. 
            {
                File.Delete("currentScoreBoardFile.txt");
            }
            File.Copy("updatedScoreBoardFile.txt", "currentScoreBoardFile.txt");

        }

    }
}

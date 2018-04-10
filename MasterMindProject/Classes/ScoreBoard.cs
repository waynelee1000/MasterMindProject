using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindProject
{

    class ScoreBoard
    {
        private string Otherplayer;
        private string OtherDifficulty;
        private double OtherTime;
        string[] PlayerList = new string[3];

        public static PlayerClass playerClass = new PlayerClass();
        private static string currentScoreBoardPath = "currentScoreBoardFile.txt";
        private static string updatedScoreBoardPath = "updatedScoreBoardFile.txt";
        public static currentFileClass currentScoreBoardFile = new currentFileClass(currentScoreBoardPath);
        public static updatedFileClass updatedScoreBoardFile = new updatedFileClass(updatedScoreBoardPath);

        public ScoreBoard() {


        }
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

        public bool HigherScore(string nextRecord)
        {
            createStringObject(nextRecord);
            string Difficulty= playerClass.getDifficulty();
            double time = playerClass.getTime();

            if (OtherDifficulty == Difficulty)
            {
                if (time < OtherTime)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            else {
                return false;
            }
            
        }
        public string findAndSaveScore(out Boolean find)
        {
            Boolean isEndOfFile = true;
            string nextRecord;
            find = false;

            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                if (HigherScore(nextRecord))
                {
                    find = true;
                    // CopyRemainingRecords();
                    return (nextRecord);
                }
                else
                {
                    updatedScoreBoardFile.putNextRecord(nextRecord);
                    nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
                } // end If
            } //end While

            return (nextRecord);
            // end While
        }

        public void writeOneRecord()
        {
            string Difficulty = playerClass.getDifficulty();
            double time = playerClass.getTime();
            string player = playerClass.getName();

            string newRecordString = "";

            string[] newRecord = new string[3];
            newRecord[0] = player;
            newRecord[1] = Difficulty;
            newRecord[2] = time.ToString();


            for (int i = 0; i < newRecord.Length - 1; i++)
            {
                newRecordString += newRecord[i] + " * ";
            }
            newRecordString += newRecord[2];

            updatedScoreBoardFile.putNextRecord(newRecordString);
        }

        public void copyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedScoreBoardFile.putNextRecord(nextRecord);
                nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            } // end While
        }

        //– closes all external files
        public void closeFiles()
        {
            updatedScoreBoardFile.closeFile();
            currentScoreBoardFile.closeFile();
        }


        public void displayScoreBoard()
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            File.Open(currentScoreBoardPath, FileMode.Open);
            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
           
                while (!isEndOfFile)

                {
                for (int i = 0; i < PlayerList.Length; i++)
                {
                    PlayerList[i] += nextRecord;
                    File.Open("currentScoreBoardFile.txt", FileMode.Open);
                    nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
                }
                }
             //end While                           

            string Scoreboard = "";
            for (int i = 0; i < PlayerList.Length; i++)
            {
                Scoreboard += PlayerList[i]+"\n";
            }
            MessageBox.Show(Scoreboard);

        }

        public string createStringToDisplay()
        {
            //converts Employee attributes to a string suitable for display in a Message Box to be use to show employee
            string Scoreboard = "";
            Scoreboard += "Name:"+ Otherplayer.ToString()+"*";
            Scoreboard += "Difficuty:"+ OtherDifficulty.ToString() + "*";
            Scoreboard += "Time:"+ OtherTime.ToString() + "*";
            return Scoreboard;

        }
        public void copyFiles()
        {
            if (File.Exists("currentScoreBoardFile.txt"))
            {
                File.Delete("currentScoreBoardFile.txt");
            }
            File.Copy("updatedScoreBoardFile.txt", "currentScoreBoardFile.txt");

        }

    }
}

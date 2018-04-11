﻿using System;
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
        List<string> PlayerList = new List<string>();

        public static PlayerClass playerClass = new PlayerClass();
        private static string currentScoreBoardPath = "currentScoreBoardFile.txt";
        private static string updatedScoreBoardPath = "updatedScoreBoardFile.txt";
        public static currentFileClass currentScoreBoardFile = new currentFileClass(currentScoreBoardPath);
        public static updatedFileClass updatedScoreBoardFile = new updatedFileClass(updatedScoreBoardPath);
        
        public ScoreBoard() {
            
        }
        public void resetPlayerList() {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                PlayerList[i] = null;
            }
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
            else
            {
                return false;
            }
                
        }
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
            
        }

        public void findAndSaveScore()
        {
            currentScoreBoardFile.rewindFile();
            Boolean isEndOfFile = true;
            string nextRecord;
            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);

            string Difficulty = playerClass.getDifficulty();
            double time = playerClass.getTime();
            string player = playerClass.getName();
             
            string playerString = player +" * "+ Difficulty +" * "+ time.ToString();

            int count=0;
            while (!isEndOfFile)
            {
                count++;
                if (HigherScore(nextRecord))

                {
                    PlayerList[count-1] = playerString;
                    isEndOfFile = true;
                }
                else
                {
                  nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
                } // end If
                //} //end While
            }
            
        }

        public void writeOneRecord()
        {
           
            for (int i = 0; i < PlayerList.Count; i++)
            {
                updatedScoreBoardFile.putNextRecord(PlayerList[i]);
            }
            
        }
        /*
        public void copyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedScoreBoardFile.putNextRecord(nextRecord);
                nextRecord = currentScoreBoardFile.getNextRecord(ref isEndOfFile);
            }
            
            // end While
        }*/

        //– closes all external files
        public void closeFiles()
        {
            updatedScoreBoardFile.closeFile();
            currentScoreBoardFile.closeFile();
        }


        public void displayScoreBoard()
        {
           
            string Scoreboard = "";
            for (int i = 0; i < PlayerList.Count; i++)
            {
                Scoreboard += PlayerList[i] + "\n";
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

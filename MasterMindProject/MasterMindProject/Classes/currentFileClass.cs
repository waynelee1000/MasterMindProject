﻿// Current File Class  
// Data stores and methods related to a current (input) text file processed by the project

// Frank Friedman
// CIS 3309

// Adapted from VB Version 1 - Feb 6 2010 by FLF July 18, 2013

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//This class is use to read from the current file using streamReader class and get the number of record readed. We are also able to rewind and clost the file
namespace MasterMindProject
{
    class currentFileClass
    {
        private string currentFilePath;
        private System.IO.StreamReader currentFileSR;   // Reference variable of type SR
        private int recordReadCount;

        // Constructor with file path input
        // Create instance of StreamReader class (type) and store reference
        public currentFileClass(string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + currentFilePath + "Terminate Program.",
                                "Output File Connection Error. can kasdhbds",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end currentFileClass Constructor 



        // Read a record from the current file
        // Returns: the text string read and (through an output argument) a true-false 
        //          indicator for end-of-file
        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            } // end if

            return (nextRecord);
        } // end getNextRecord



        // Get value of number of records read
        public int getRecordsReadCount()
        {
            return recordReadCount;
        } // end getRecordsReadCount



        // Close the input file
        public void closeFile()
        {
            currentFileSR.Close();
        }  // end closeFile
       
      
        // Rewind the input file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR = new System.IO.StreamReader(currentFilePath);
            currentFileSR.DiscardBufferedData();
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }  // end rewindFile

    } // end currentFileClass
} // end namespace










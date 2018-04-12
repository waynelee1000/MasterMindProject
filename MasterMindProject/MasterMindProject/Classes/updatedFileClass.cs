// Updated File Class  
// Data stores and methods related to a current (input) text file processed by the project

// Frank Friedman
// CIS 3309

// Adapted from VB Version 1 - Feb 6 2010 by FLF July 18, 2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This class is use to write to updated file using streamWriter class and get the number of record readedwrite. We are also able to rewind and close the file.
namespace MasterMindProject
{
    public class updatedFileClass
    {

        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;  // Reference variable of type SW
        private int recordWrittenCount;

        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public updatedFileClass(string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                                "Input File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end updatedFileClass Constructor



        // Write a record to the updated file
        public void putNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.",
                                "File Write Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // end Try
            recordWrittenCount += 1;
        } // end puNextRecord



        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        } // end getRecordsWritten



        // Close the output (updated) file
        public void closeFile()
        {
            updatedFileSW.Close();
        } // end closeFile



      
        // Rewind the output file
        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
        

    }
    // end Class
} // end namespace










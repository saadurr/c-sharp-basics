using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    static class WriteFile
    {
        public static void CreateFile(string filename = "test.txt", string path = "D://sandbox-D//")
        {
            filename = path + filename;

            StreamWriter sw = new StreamWriter(filename);
            sw.Close();
        }

        //This function will create a file with the filename if it does not exist
        public static void WriteTextToFile(string text, string filename="D://sandbox-D//test.txt")
        {
            //This will append the text to the file if it already exists
            StreamWriter sw = new StreamWriter(filename, true);
            
            //Writes the text in a buffer
            sw.WriteLine(text);

            //Writes the text in output stream
            sw.Flush();

            //Closes the output stream
            sw.Close();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    static class ReadFile
    {
        public static string readFile(string filename="D://sandbox-D//test.txt")
        {
            StreamReader sr = new StreamReader(filename);

            string line = "", buffer = "";

            //Setting the point from where it will start reading
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            //Reads one line
            line = sr.ReadLine();

            while (line != null)
            {
                //Append to buffer
                buffer += line;

                //End of line
                buffer += "\n";

                //Read next line
                line = sr.ReadLine();
            }

            //Close stream
            sr.Close();

            return buffer;
        }
    }
}

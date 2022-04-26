using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Writing a file
            string text = "This is a new text";
            WriteFile.CreateFile();
            WriteFile.WriteTextToFile(text);

            //Test Reading a file
            string readBuffer = "";
            readBuffer = ReadFile.readFile();
            Console.WriteLine("The contents of the file are:\n");
            Console.WriteLine(readBuffer);
        }
    }
}

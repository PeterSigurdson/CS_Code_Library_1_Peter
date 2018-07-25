// TAGS: FILE_SYSTEM, ARRAYS

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var fileWriter1 = new WriteTextFile();
        // making a string array and outputting it to the screen
        string[] names = new string[] { "david", "albert", "emad", "cryston", "mary", "jordan" };

        fileWriter1.files_string(names);

        fileWriter1.files_line("start of file...\n\n");

        for (int i = 0; i < names.Length; i++)
        {
            fileWriter1.files_line(names[i] + '\n');
        }

        int[] numbers = new int[] { 18, 25, 99, 0, 44 };

        numbers[2] = 75;

        int y = numbers[0] * numbers[3];

        fileWriter1.files_line(Convert.ToString(y));
    }
}

public class WriteTextFile
{
    public void files_string(string[] lines)
    {

        System.IO.File.WriteAllLines(@"C:\area51\WriteLines.txt", lines);

        // Example #4: Append new text to an existing file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
        //using (System.IO.StreamWriter file =
        //    new System.IO.StreamWriter(@"C:\area51\WriteLines2.txt", true))
        //{
        //    file.WriteLine("Fourth line");
        //}
    }

    public void files_line(string line)
    {

        System.IO.File.AppendAllText(@"C:\area51\WriteLines.txt", line);

        // Example #4: Append new text to an existing file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
        //using (System.IO.StreamWriter file =
        //    new System.IO.StreamWriter(@"C:\area51\WriteLines2.txt", true))
        //{
        //    file.WriteLine("Fourth line");
        //}
    }
}

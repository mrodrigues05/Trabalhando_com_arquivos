using System;
using System.Dynamic;
using System.IO;

class sWriter

{
    static void Main(string[] args)
    {
        string Sourcepath = @"C:\Intel\file1.txt";
        string targetPath = @"C:\Intel\file2.txt";

        try
        {

            string[] lines = File.ReadAllLines(Sourcepath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
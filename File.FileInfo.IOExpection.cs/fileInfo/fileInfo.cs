using System;
using System.IO;
class fileInfo
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Intel\file1.txt";
        string targetPath = @"C:\Intel\file2.txt";

        try
        {
            //Copiar um arquivo
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }
    }
}
using System;
using System.IO;

class Using

{
    static void Main(string[] args)
    {
        string path = @"C:\Intel\file1.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }
    }
}
using System;
using System.IO;
class fileStream
{
    static void Main(string[] args)
    {
        string path = @"C:\Intel\file1.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {

            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error accured");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }

    }
}
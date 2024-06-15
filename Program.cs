using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/vinicius/Área de Trabalho/file-fileinfo-ioexception/file1.txt";

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
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
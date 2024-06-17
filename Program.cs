using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "/home/vinicius/Área de Trabalho/file-fileinfo-ioexception/file1.txt";
            string pathTwo = "/home/vinicius/Área de Trabalho/file-fileinfo-ioexception/file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(pathTwo))
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
}
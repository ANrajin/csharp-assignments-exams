using System;
using System.IO;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());

            var parent = d.Parent.Parent.Parent;

            FileInfo fs = new FileInfo($"{parent}/Hello.txt");

            if (fs.Exists)
            {
                File.Move($"{parent}/Hello.txt", $"{parent}/HelloTwo.txt");
            }

            using(StreamWriter sw = fs.CreateText())
            {
                sw.WriteLine("Hello world from C#!");
            }
        }
    }
}

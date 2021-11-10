using System;
using System.IO;

namespace Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo myDir = new DirectoryInfo(@"c:\New Folder");

            string textfilepath = @"c:\New Folder\Scores.txt";
            string textfilepath2 = @"c:\New Folder\NewScores.txt";

            foreach (string line in File.ReadAllLines(textfilepath))
            {
                int value = Convert.ToInt32(line.Substring(line.Length - 2));
                if (value >= 50)
                {
                    value += 5;
                }
                else
                {
                    value += 10;
                }
                string name = line.Substring(0, line.Length - 2);
                name += value;
                string[] myArray = { name };
                //Console.WriteLine(name);
                File.AppendAllLines(textfilepath2, myArray);
            }
        }
    }
}

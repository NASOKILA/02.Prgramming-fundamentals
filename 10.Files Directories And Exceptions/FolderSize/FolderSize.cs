namespace FolderSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Threading.Tasks;

    class FolderSize
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("TestFolder");

            string[] files = Directory.GetFiles("TestFolder");

            double sizeSum = 0;

            foreach (string file in files)
            { 
                FileInfo fInfo = new FileInfo(file);
                sizeSum += fInfo.Length;  
            }

            sizeSum = sizeSum / 1024 / 1024;

            File.WriteAllText("output.txt", "");

            File.AppendAllText("output.txt", sizeSum.ToString());
        }
    }
}

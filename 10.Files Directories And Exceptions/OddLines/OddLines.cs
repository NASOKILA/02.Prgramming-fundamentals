namespace OddLines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Threading.Tasks;

    class OddLines
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 == 1)
                {
                    File.AppendAllText("output.txt",file[i] + Environment.NewLine);                
                }
            }
        }
    }
}

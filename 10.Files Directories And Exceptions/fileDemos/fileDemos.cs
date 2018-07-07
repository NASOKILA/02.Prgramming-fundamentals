namespace fileDemos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    class fileDemos
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText("textFile.txt");

            Console.WriteLine(file);

            string[] file2 = File.ReadAllLines("textFile2.txt");

            Console.WriteLine(string.Join(",\n", file2));


            File.WriteAllText("output.txt", file);

            File.WriteAllLines("output2.txt", file2);

            Console.WriteLine(); Console.WriteLine();

            File.AppendAllText("output.txt", file2[0]);
            string output = File.ReadAllText("output.txt");
            Console.WriteLine(output);

            Console.WriteLine();

            File.AppendAllLines("output2.txt", file2);
            string[] output2 = File.ReadAllLines("output2.txt");
            Console.WriteLine(string.Join(",\n", output2));

            Console.WriteLine(); Console.WriteLine();

            FileInfo fInfo = new FileInfo("output.txt");
            Console.WriteLine(fInfo.Name);

            string str = "naso";

            try
            {
                File.ReadAllText("naso.txt");
            }
            catch (FileNotFoundException Err)
            {
                Console.WriteLine(Err.Message);
            }
            catch (FormatException Err)
            {
                Console.WriteLine(Err.Message);
            }
            catch (Exception Err)
            {
                Console.WriteLine(Err.Message);
            }
        }
    }
}

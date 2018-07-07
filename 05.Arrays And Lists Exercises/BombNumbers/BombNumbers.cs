namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BombNumbers
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List < int > seqList = seq.ToList();
            int[] specialNumAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int specialNumber = specialNumAndPower[0];
            int power= specialNumAndPower[1];

            for (int i = 0; i < seqList.Count; i++)
            {
                if (seqList[i] == specialNumber) {

                    int counter3 = 0;
                    for (int j = i-1; j >= i - power; j--) 
                    {
                        if (j < 0) { break; }
                        seqList.RemoveAt(j); 
                        counter3++;
                    }

                    int counter = 0;
                    int counter2 = i + 1 - counter3;
                    while(counter < power) 
                    {
                        seqList.RemoveAt(counter2);
                        counter++;
                        if (counter2 == seqList.Count) { break; }                      
                    }
                    i = i - counter3;
                }
            }

            for (int i = 0; i < seqList.Count; i++)
            {
                if (seqList[i] != specialNumber) { sum = sum + seqList[i]; }       
            }
           
            Console.WriteLine(sum);
        }
    }
}

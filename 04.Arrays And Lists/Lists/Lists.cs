using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Lists
    {
       public static void Main(string[] args)
        {

            List<int> spisuk = new List<int>();  
            spisuk.Add(3);
            spisuk.Add(4);
            spisuk.Add(5);
            spisuk.Add(6);
            spisuk.Add(5);      
            spisuk.Add(5);   
            spisuk.Add(7);
            spisuk.Add(8);
            
            foreach (var element in spisuk)
            {
                Console.WriteLine(element);
            }
            
            spisuk.Remove(5);
            spisuk.RemoveAt(0);  
                
            Console.WriteLine(); Console.WriteLine();
            foreach (var element in spisuk) {

                Console.WriteLine(element);
            }
            
            spisuk.Insert(2, 2222222); 
            
            Console.WriteLine(); Console.WriteLine();
            foreach (var element in spisuk)
            {
                Console.WriteLine(element);
            }
            
            Console.WriteLine(); Console.WriteLine();
            
            var names = new List<string>()
            {
                "Naskov","Asen", "Ivan","Atanas","Boris"
            };
            
            Console.WriteLine(string.Join(", ", names));

            names.Sort();
            Console.WriteLine(string.Join(", ", names));
            
            names.Sort((a, b) => b.CompareTo(a));  
            
            Console.WriteLine(string.Join(", ", names)); 
        }
    }
}

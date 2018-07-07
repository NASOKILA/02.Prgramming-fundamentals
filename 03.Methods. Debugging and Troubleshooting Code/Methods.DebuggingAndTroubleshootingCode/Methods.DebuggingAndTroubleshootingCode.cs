using System;

namespace Methods.DebuggingAndTroubleshootingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string result =  ReadFullName();
            Console.WriteLine(result);

            Console.WriteLine();

            int result2 = MaxNum();
            Console.WriteLine(result2);
        }
        
        static double GetSquare(double i) { 
            return i * i; 
        }

        static int Function (int i)
        {
            double a = 5.1356;
            double b = 10.5445;
            return  i * (int)a * (int)b; 
        }
        
        static string ReadFullName() 
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName; 
        }
        
        static int MaxNum() {

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            return Math.Max(firstNum, secondNum);

        }
    }
}

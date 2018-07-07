namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            int[] pointOneXAndYArr = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
 
            int[] pointTwoXAndYArr = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            Point P1 = new Point();
            P1.X = pointOneXAndYArr[0];
            P1.Y = pointOneXAndYArr[1];

            Point P2 = new Point() { 
                X = pointTwoXAndYArr[0],
                Y = pointTwoXAndYArr[1],
            };

        double result = CalculateEucledianDistance(P1, P2);
            Console.WriteLine("{0:f3}",result);
        }

        private static double CalculateEucledianDistance(Point p1, Point p2)
        {
            int sideA = Math.Abs(p1.X - p2.X);
            int sideB = Math.Abs(p1.Y - p2.Y);
            double sideC = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            double distance = Math.Sqrt(sideC);

            return distance;
        }
    }
}

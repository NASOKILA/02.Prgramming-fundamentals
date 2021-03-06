﻿namespace ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> Points = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {

                int[] pointsXAndY = Console.ReadLine().Split(' ')
                  .Select(int.Parse).ToArray();

                Point P = new Point()
                {
                    X = pointsXAndY[0],
                    Y = pointsXAndY[1],
                };

                Points.Add(P);
            }


            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                for (int j = i + 1; j < Points.Count; j++)
                {
                    var firstPoint = Points[i];
                    var secondPoint = Points[j];


                    var currentDistance =
                        CalculateEucledianDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }

            Console.WriteLine("{0:f3}", minDistanceSoFar);
            Console.WriteLine($"({firstPointMax.X},{firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X},{secondPointMax.Y})");

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

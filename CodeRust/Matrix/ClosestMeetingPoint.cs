using System;
using System.Collections.Generic;

namespace CodeRust.Matrix
{
    public class ClosestMeetingPoint
    {
        public static void ClosestMeetingPt(IList<Point> points, int m)
        {
            //if(points == null || m < 1) {
            //    return;
            //}
            //double minDistance = Double.MaxValue;
            //Point minPoint = null;
            //for (int i = 1; i < m; i++) {
            //    for (int j = 1; j < m; j++) {
            //        double currentDistance = 0;
            //        foreach(var pt in points) {
            //            currentDistance += pt.CalculateDistance(i+1, j+1);
            //        }
            //        if(currentDistance < minDistance) {
            //            minDistance = currentDistance;
            //            minPoint = new Point(i+1, j+1);
            //        }
            //    }
            //}
            //Console.WriteLine("Output: ");
            //Console.WriteLine("Min distance: " + minDistance + "  Point: " + minPoint.X + "," + minPoint.Y);

            if (points == null || m < 1)
            {
                return;
            }
            int centroidX = 0;
            foreach (var pt in points)
            {
                centroidX += pt.X;
            }
            centroidX = centroidX / points.Count;
            int centroidY = 0;
            foreach (var pt in points)
            {
                centroidY += pt.Y;
            }
            centroidY = centroidY / points.Count;
            double minDistance = Double.MaxValue;
            Point minPoint = new Point(centroidX, centroidY);
            for (int i = centroidX - 1; i < centroidX + 1; i++)
            {
                for (int j = centroidY - 1; j < centroidY + 1; j++)
                {
                    double currentDistance = 0;
                    foreach (var pt in points)
                    {
                        currentDistance += pt.CalculateDistance(i, j);
                    }
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        minPoint = new Point(i, j);
                    }
                }
            }
            Console.WriteLine("Output: ");
            Console.WriteLine("Min distance: " + minDistance + "  Point: " + minPoint.X + "," + minPoint.Y);

        }
       
        public class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            internal double CalculateDistance(Point p)
            {
                double distance;
                distance = Math.Sqrt((p.X - X) * (p.X - X)
                    + (p.Y - Y) * (p.Y - Y));
                return distance;
            }

            internal double CalculateDistance(int x, int y)
            {
                double distance;
                distance = Math.Sqrt((x - X) * (x - X)
                    + (y - Y) * (y - Y));
                return distance;
            }
        }
    }
}

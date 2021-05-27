using System;
using System.Collections.Generic;

namespace LAP2_ITI_CSharp_Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Console.WriteLine(p1.ToString());
            Point3D[] pointArray = new Point3D[50];
            Array.Sort(pointArray, delegate (Point3D p1, Point3D p2) {
                return p1.X.CompareTo(p2.X);
            });

        }
    }
}

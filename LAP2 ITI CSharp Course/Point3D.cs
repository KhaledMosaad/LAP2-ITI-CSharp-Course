using System;
using System.Collections.Generic;
using System.Text;

namespace LAP2_ITI_CSharp_Course
{
    public class Point3D: ICloneable
    {
        private int x;
        private int y;
        private int z;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set {y = value; } }
        public int Z { get { return z; } set { z = value; }}
        public Point3D(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D() : this(0, 0, 0) { }
        
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("Point Coordinates:");
            s.AppendFormat("({0},{1},{2})", this.x, this.y, this.z);
            return s.ToString();
        }
        public override bool Equals(Object o)
        {
            Point3D P = (Point3D)o;
            return (P.x==this.x&&P.y==this.y&&P.z==this.z);
        }

        public Object Clone()
        {
            return new Point3D(this.x, this.y, this.z);
        }
        public static Point3D operator +(Point3D p1,Point3D p2)
        {
            Point3D result = new Point3D(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
            return result;
        }
        public static Point3D operator -(Point3D p1, Point3D p2)
        {
            Point3D result = new Point3D(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
            return result;
        }
        public static Point3D operator *(Point3D p1, Point3D p2)
        {
            Point3D result = new Point3D(p1.x * p2.x, p1.y * p2.y, p1.z * p2.z);
            return result;
        }
        public static Point3D operator /(Point3D p1, Point3D p2)
        {
            Point3D result = new Point3D(p1.x / p2.x, p1.y / p2.y, p1.z / p2.z);
            return result;
        }
        public static Point3D operator -(Point3D p1)
        {
            Point3D result = new Point3D(-p1.x , -p1.y, -p1.z);
            return result;
        }
    }
}

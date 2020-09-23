using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"(x, y, z)=({x}, {y}, {z})";
        }
    }
    class MyStruct1
    {
        static void Main()
        {
            Point3D point;
            point.x = 20;
            point.y = 30;
            point.z = 5;

            Console.WriteLine(point.ToString());

            Point3D point1;
            point1.x = 30;
            point1.y = 40;
            point1.z = 25;

            Console.WriteLine(point1.ToString());

            Point3D point2 = new Point3D(90, 30, 20);

            Console.WriteLine(point2.ToString());

            Point3D point3 = point2;
            point3.z = 900;

            Console.WriteLine(point2.ToString());
            Console.WriteLine(point3.ToString());
        }
    }
}

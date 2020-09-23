using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923
{
    class CPoint3D
    {
        public int x;
        public int y;
        public int z;

        public CPoint3D()
        {
            
        }
        public CPoint3D(int x, int y, int z)
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
    class MyClass1
    {
        static void Main()
        {
            CPoint3D point = new CPoint3D();
            point.x = 20;
            point.y = 30;
            point.z = 5;

            Console.WriteLine(point.ToString());

            CPoint3D point1 = new CPoint3D();
            point1.x = 30;
            point1.y = 40;
            point1.z = 25;

            Console.WriteLine(point1.ToString());

            CPoint3D point2 = new CPoint3D(90, 30, 20);

            Console.WriteLine(point2.ToString());

            CPoint3D point3 = point2;
            point3.z = 900;

            Console.WriteLine(point2.ToString());
            Console.WriteLine(point3.ToString());
        }
    }
}

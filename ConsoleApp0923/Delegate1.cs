using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923
{
    class MyClass
    {
        private int number;
        public static void PrintHello(int val)
        {
            for (int i = 0; i < val; i++) 
                Console.WriteLine("HellO");
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public void Plus(int val)
        {
            number += val;
        }
        public void Minus(int val)
        {
            number -= val;
        }
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }

    delegate void Sample(int value);
    class Delegate1
    {
        
        static void Main()
        {
            MyClass delegate1 = new MyClass();

            //delegate1.Plus(100);
            //delegate1.Minus(10);
            //delegate1.Add(10, 20);
            //Console.WriteLine(delegate1.Number);

            Sample s1 = new Sample(delegate1.Plus);

            s1 += new Sample(delegate1.Minus);
            s1(100);
            s1 -= new Sample(delegate1.Minus);
            s1(100);
            Console.WriteLine(delegate1.Number);

            s1 = delegate1.Minus;
            s1 += delegate1.Plus;
            s1 += delegate1.Plus;
            s1(200);
            Console.WriteLine(delegate1.Number);

            s1 += MyClass.PrintHello;
            s1(4);
        }
    }
}
// lp179345082sg

// SGSINBKRSELBAUY00642
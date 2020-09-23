using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923
{
    delegate void FindDelegate(int Prime);
    class My
    {
        public event FindDelegate FindPrime;
        public void CheckPrime(int maxNum)
        {

            bool bPrime = true;
            for (int i = 2; i < maxNum; i++)
            {
                bPrime = true;
                for (int p = 2; p < i; p++)
                {
                    if (i % p == 0)
                    {
                        bPrime = false;
                        break;
                    }
                }
                if (bPrime)
                {
                    //Console.WriteLine(i);
                    FindPrime(i); // 이벤트 발생
                }
                //break먹고나온건지 다 돌고나온건지 모름
            }
        }
    }
    class Myprime
    {
        static void Main()
        {
            Console.Write("소수를 구하고 싶은 범위의 최대값. :");
            int maxNum = int.Parse(Console.ReadLine());

            My my = new My();
            my.FindPrime += PrintPrime; //이벤트핸들러등록 += 할때마다 늘어남
            my.CheckPrime(maxNum);
            
        }

        private static void PrintPrime(int Prime)
        {
            Console.WriteLine(Prime);
        }
    }
    
}

using System;
using System.Collections;
using System.IO;

namespace ConsoleApp0923
{
    class SingerNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            // 이름이 크면 1, 이름이 작으면 -1, 이름이 같으면 0
            Singer first = x as Singer;
            Singer second = y as Singer;

            if (first.Name.CompareTo(second.Name)==1)
                return 1;
            else if (first.Name.CompareTo(second.Name)==-1)
                return -1;
            else
                return 0;
        }
    }
    class Singer :IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AlbumCnt { get; set; }

        public Singer(string name, int age, int albumCnt)
        {
            Name = name;
            Age = age;
            AlbumCnt = albumCnt;
        }

        public override string ToString()
        {
            return $"{Name} - {Age}세 - {AlbumCnt}집 앨범";
        }

        public int CompareTo(object obj)
        {
            // 나이가 크면 1, 나이가 작으면 -1, 나이가 같으면 0
            Singer sing = obj as Singer;

            if(this.Age >sing.Age) 
                return 1;
            else if (this.Age < sing.Age)
                return -1;
            else 
                return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Singer[] singers = new Singer[5] {
                    new Singer("아이유", 28, 8),
                    new Singer("자우림", 40, 5),
                    new Singer("거미", 35, 5),
                    new Singer("이승철", 50, 15),
                    new Singer("태진아", 65, 5)
            };
            while (true)
            {
                Console.Write("1. 목록보기  2. 나이 오름차순정렬  3. 나이 내림차순정렬  4. 이름 오름차순정렬  5. 나이 내림차순정렬 ");
                int s = Convert.ToInt32(Console.ReadLine());
                SingerNameComparer nameComparer = new SingerNameComparer();
                switch (s)
                {
                    case 1:
                        
                        Console.WriteLine();
                        for (int a = 0; a < singers.Length; a++)
                            Console.WriteLine(singers[a].ToString());
                        Console.WriteLine("======================================"); // 이름
                        Console.WriteLine();
                        break; // 목록출력

                    case 2:
                        //foreach (Singer sing in singers)
                        //{
                        //    Console.WriteLine(sing.ToString());
                        //}

                        Console.WriteLine();
                        object[] singer1 = (object[])singers.Clone();
                        Array.Sort(singer1);

                        foreach (Singer sing in singer1)
                        {
                            Console.WriteLine(sing.ToString());
                        }

                        Console.WriteLine("======================================"); // 이름
                        Console.WriteLine();
                        break;

                    case 3:
                        //foreach (Singer sing in singers)
                        //{
                        //    Console.WriteLine(sing.ToString());
                        //}

                        Console.WriteLine();
                        Array.Sort(singers, nameComparer); // 이름으로 정렬

                        foreach (Singer sing in singers)
                        {
                            Console.WriteLine(sing.ToString());
                        }

                        Console.WriteLine("======================================"); // 이름
                        Console.WriteLine();

                        break;

                    case 4:
                        //foreach (Singer sing in singers)
                        //{
                        //    Console.WriteLine(sing.ToString());
                        //}
                        Console.WriteLine();

                        Array.Sort(singers);

                        foreach (Singer sing in singers)
                        {
                            Console.WriteLine(sing.ToString());
                        }

                        Console.WriteLine("======================================"); // 나이
                        Console.WriteLine();
                        break;

                    case 5:
                        //foreach (Singer sing in singers)
                        //{
                        //    Console.WriteLine(sing.ToString());
                        //}

                        Console.WriteLine();

                        Array.Sort(singers, nameComparer); // 이름으로 정렬

                        foreach (Singer sing in singers)
                        {
                            Console.WriteLine(sing.ToString());
                        }
                        Console.WriteLine("======================================"); // 이름
                        Console.WriteLine();
                        break;

                }
            }
        }
        private static void PrintMem()
        {

        }
    }
}
// 정렬메뉴 추가 - 이름순 정렬-나이순 정렬 고르는거에 따라서 보여주기 목록을 불렀을때 목록은 원상태로 나와야함
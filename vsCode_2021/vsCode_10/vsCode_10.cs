using System;
using static System.Console;

namespace vsCode_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수
            int number = 0;
            int @int = 10; // 비추
            // int int = 10; 불가능
            int a = 10, b = 10, c = 1_000_000;
            Console.WriteLine();
            Console.WriteLine("{0}, {1}, {2}", a, b, c);

            string str = "문자열";
            char ch = '문';
            bool tr = true;
            object obj = "오브젝트";
            object oj = 10;

            const int my_num = 100;

            System.Int32 in32 = 10;

            int min = -2147483648;
            int max = 2147483647;


            // 리터럴
            Console.WriteLine(1000);
            Console.WriteLine("리터럴");
            Console.WriteLine(number);
            Console.WriteLine(true);
        }
    }
}
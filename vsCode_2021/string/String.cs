using System;

namespace String
{
    class String
{
    static void Main(string[] args)
    {
            // 문자열 보간법
            string message = "Heelo";
            Console.WriteLine($"문자열 : {message}");

            int number = 3;
            string result = "홀수";
            Console.WriteLine($"{number}은 {result}이다");


            // string.Format
            string msg = string.Format("{0}님, {1}", "백승수", "안녕하세요");
            Console.WriteLine(msg);

            // bool 값
            bool isTrue = true;
            bool isFalse = false;

            //const 상수
            const int num = 10;
            //num = 11; 불가능


    }
}
}

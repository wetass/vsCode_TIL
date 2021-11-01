using System;
using System.Text;

namespace Defalut
{
    class Program
    {
        static void Main(string[] args)
        {
            // 변수값 디폴트로 초기화
            int i = default; // 0
            double d = default; // 0
            char c = default; // \0
            string s = default; // null

            Console.WriteLine($"{i}, {d}, {c}, {s}");

            // 디폴트 키워드로 c#형식의 기본값 가져오기
            int intDefault = default(int);
            Console.WriteLine(intDefault); // 0

            bool boolDefalut = default(bool);
            Console.WriteLine(boolDefalut); // false

            string strDefault = default(string);
            Console.WriteLine(strDefault); // null

            StringBuilder sbDefault = default(StringBuilder);
            Console.WriteLine(sbDefault); // null

            // 튜플 리터럴
            var t = (100, 200);
            Console.WriteLine(t.Item1); // 100
            Console.WriteLine(t.Item2); // 200

            var (x, y) = (300, 400);
            Console.WriteLine(x); // 300
            Console.WriteLine(y); // 400
        }
    }
}

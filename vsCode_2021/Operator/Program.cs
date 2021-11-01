using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연산자 + - * / % 등등

            int i = 10;
            int j = 20;
            int k = i + j;
            Console.WriteLine(j) ;

            // 나머지 연산자

            int ii = 5;
            int jj = 3;
            int kk = ii % jj;

            // 나머지 연산자 없이 나머지 구하기
            kk = ii - (ii / jj) * jj;
           

            Console.WriteLine(kk);
        }
    }
}

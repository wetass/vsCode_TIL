using System;

namespace BinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 10;

            Console.WriteLine($"십진수: {x} -> 이진수: {Convert.ToString(x,2).PadLeft(8, '0')}");

            Console.WriteLine($"십진수 100을 2진수로 변경 : {Convert.ToString(10, 2)}");
        }
    }
}

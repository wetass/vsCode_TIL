using System;

namespace standard_input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력 메서드
            Console.WriteLine(Console.ReadLine());

            Console.Write("이름을 입력하시오 : ");
            string name = Console.ReadLine();
            Console.WriteLine("안녕하세요. " + name + "님");

            int x = Console.Read();
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToChar(x));

            //형변환
            //int number = 1234;
            //long num = number;

            long num1 = 1234;
            int num2 = (int)num1;

            // 변수의 크기를 벗어나는 형변환
            long l = long.MaxValue;
            Console.WriteLine($"l의값 : {l}");
            int i = (int)l;
            Console.WriteLine($"i의값 : {i}");

            // Convert 형변환
            int a = 0;
            string b = Convert.ToString(a);
            Int32 c = Convert.ToInt32(a);
            double d = Convert.ToDouble(a);
            char e = Convert.ToChar(a);

            // GetType
            int aa = 1;
            char bb = '1';
            string cc = "1";
            bool dd = true;

            Console.WriteLine(aa.GetType());
            Console.WriteLine(bb.GetType());
            Console.WriteLine(cc.GetType());
            Console.WriteLine(dd.GetType());

            Console.WriteLine();
            // Parse 형변환
            string strNumber = "1234";
            int number1 = int.Parse(strNumber);

            // 여러 형식으로 변환
            Console.Write("정수를 입력하시오 : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine($"{number} - {number.GetType()}");
        }
    }
}

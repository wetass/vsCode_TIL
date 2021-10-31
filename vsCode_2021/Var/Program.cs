using System;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "C#";
            Console.WriteLine(name);

            var version = 8.0;
            Console.WriteLine(version);

            var s = Console.ReadLine();
            var c = Convert.ToChar(Console.Read());
            Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
        }
    }
}

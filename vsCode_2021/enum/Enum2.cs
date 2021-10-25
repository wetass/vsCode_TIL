using System;


namespace Enum2
{
    class Enum2
    {
        public enum Colors
        {
            Red = 0,
            Yellow,
            Green,
            Blue
        }

        static void Main(string[] args)
        {
            var color = (Colors)System.Enum.Parse(typeof(Colors), "Red");

            var colorIdx = (int)Colors.Yellow;

            var colorNames = System.Enum.GetNames(typeof(Colors));

            Console.WriteLine(color);
            Console.WriteLine(colorIdx);
            Console.WriteLine(colorNames);
        }
    }
}
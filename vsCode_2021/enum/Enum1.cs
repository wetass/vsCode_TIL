using System;

namespace Enum
{
    class Enum1
    {
        enum City
        {
            Seoul,
            Deajun,
            Busan = 5,
            Jeju = 10
        }

        static void Main(string[] args)
        {
            City myCity;

            myCity = City.Seoul;

            int cityValue = (int)myCity;

            if (myCity == City.Seoul)
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
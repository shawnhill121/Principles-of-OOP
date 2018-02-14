using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfOOP
{
    class Inheritance
    {
        public class Car
        {
            public static int Wheels = 4;
            public static int Doors = 4;
            public static string FuelType = "Gasoline";
        }

        public class Toyota : Car
        {
            public static string Make = "Toyota";
            public static string OriginCountry = "Japan";

        }

        public class Tacoma : Toyota
        {
           public static string Model = "Tacoma";
            public static bool IsTruck = true;
            public static string Color = "Black";

        }
    }
}

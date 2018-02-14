using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfOOP
{
    class Polymorphism
    {
        public class Area
        {
            public static int CalculateArea(int length, int width)
            {
                return (length * width);
            }

            public static int CalculateArea(int length, int width, int depth)
            {
                return (length * width * depth);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfOOP
{
    class Abstraction
    {
        public class Multiply
        {
            public static void By10()
            {
                for(int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(count * 10);
                }
            }

            public static void By20()
            {
                for (int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(count * 20);
                }
            }
        }

        public class Add
        {
            public static void By10()
            {
                for(int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(count + 10);
                }
            }

            public static void By20()
            {
                for (int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(count + 20);
                }
            }
        }
    }
}

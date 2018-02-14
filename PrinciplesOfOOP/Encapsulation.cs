using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfOOP
{
    public class Encapsulation
    {
        private static string iAmPrivate = "I am private. You may not access me.";

        public static string iAmPublic = "I am public. You may access me.";

        public static string iAmReturned()
        {
            return iAmPrivate;
        }
    }
}

using System;

namespace PrinciplesOfOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encapsulation.iAmPublic); //This string is accessable, because it is public.

            // Console.WriteLine(Encapsulation.iAmPrivate); This string is inaccessable, because it is private. 

            Console.WriteLine(Encapsulation.iAmReturned()); //The string 'iAmPrivate' is accessed internally by 'iAmReturned' which returns the value of 'iAmPrivate'

        }
    }
}

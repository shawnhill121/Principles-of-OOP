using System;

namespace PrinciplesOfOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encapsulation.iAmPublic);
            Console.WriteLine("This string is accessable, because it is public.");
            Console.WriteLine(" ");
            
            // Console.WriteLine(Encapsulation.iAmPrivate); This string is inaccessable, because it is private. 

            Console.WriteLine(Encapsulation.iAmReturned());
            Console.WriteLine("The string 'iAmPrivate' is accessed internally by 'iAmReturned' which returns the value of 'iAmPrivate'");

            Console.WriteLine(" ");

            Console.WriteLine("In this example the methods for additon are grouped tother in the 'Add' Class and those for multiplication in the 'Multiply' Class");

            Console.WriteLine(" ");

            Abstraction.Add.By10();

            Console.WriteLine(" ");

            Abstraction.Multiply.By20();

            Console.WriteLine(" ");

            Console.WriteLine("My car is a " + Inheritance.Tacoma.Color + " " + Inheritance.Tacoma.Make + " " + Inheritance.Tacoma.Model + " with " + Inheritance.Tacoma.Doors + " doors.");
            Console.WriteLine("In this example the 'Tacoma' class inherits it's 'Make' from the 'Toyota' class and it's 'Doors' from the 'Car' class by being a sub-class of 'Toyota' which is a sub-class of 'Car'. ");

            Console.WriteLine(" ");

            Console.WriteLine(Polymorphism.Area.CalculateArea(4, 7));
            Console.WriteLine(Polymorphism.Area.CalculateArea(4, 7, 2));

        }
    }
}

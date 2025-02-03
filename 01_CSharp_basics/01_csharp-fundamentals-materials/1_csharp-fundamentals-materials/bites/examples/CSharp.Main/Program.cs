// imports classes, such as `Console` that are defined in the `System` namespace
using System;

// a `namespace` is a container (or scope) for classes
namespace CSharp.Main
{
    // the class definition begins here
    class Program
    {
        // static methods are like Ruby's class methods
        // void means that this method returns nothing
        // the Main method takes an array of strings as an arg - `string[]`
        static void Main(string[] args)
        {
            // The Main method is called automatically when you execute the program
            // When that happens, you'll see "Hello, Makers!" printed to the terminal
            Console.WriteLine("Hello, World!");
        }
    }
}
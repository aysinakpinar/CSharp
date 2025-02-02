using System;

Console.WriteLine("TOP LEVEL");

namespace CSharp.Types
{
  class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Hello, World!");
      }

      static string greeting()
      {
        return "Howdy, Makers!";
      }
      
      static bool csharpIsFun()
      {
        return true;
      }
      
      static char bestLetter()
      {
        return 'C';
      }
      
      static double luckyDecimal()
      {
        return 7.77;
      }
      
      static int luckyInt()
      {
        return 7;
      }
  }
}